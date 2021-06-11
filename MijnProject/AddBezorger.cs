using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijnProject
{
    public partial class AddBezorger : Form
    {
        List<Adress> Adresses = new List<Adress>();
        bool newAd = false;
        Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

        public AddBezorger()
        {
            InitializeComponent();
            using (var ctx = new ProjectContext())
                Adresses = ctx.Adressen.ToList();
            cmbAdress.DataSource = Adresses;
            Global.ModifyForm(this);
        }
        
        private void llblAddAdress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAdress.Visible = true;
            cmbAdress.Enabled = false;
            newAd = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdress.Visible = false;
            cmbAdress.Enabled = true;
            newAd = false;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            string s = "";
            Bezorger lev = new Bezorger();
            Adress ad = new Adress();
            if (txtNaam.Text != "")
                lev.Naam = txtNaam.Text;
            else
                s += "Naam? ";
            lev.Omschrijving = rtbOmschrijving.Text;
            if (txtTel1.Text != "" && txtTel1.Text.ToCharArray().All(c => char.IsDigit(c)))
                lev.Telefoon1 = txtTel1.Text;
            else
                s += "Telefoon1? ";
            if (txtTel2.Text != "" && txtTel2.Text.ToCharArray().All(c => char.IsDigit(c)))
                lev.Telefoon2 = txtTel2.Text;
            if (re.IsMatch(txtEmail.Text))
                lev.Email = txtEmail.Text;
            else
                s += "Email? ";
            if (newAd)
            {
                if (txtStraat.Text != "" && txtStraat.Text.ToCharArray().All(c => char.IsLetter(c)))
                    ad.Straat = txtStraat.Text;
                else
                    s += "Adress: Straat ? ";
                if (txtHuisNr.Text != "" && txtHuisNr.Text.ToCharArray().All(c => char.IsLetterOrDigit(c)))
                    ad.Huisnummer = Convert.ToInt32(txtHuisNr.Text);
                else
                    s += "Adress: Huisnummer ? ";
                if (txttGem.Text != "" && txttGem.Text.ToCharArray().All(c => char.IsLetter(c)))
                    ad.Gemeente = txttGem.Text;
                else
                    s += "Adress: Gemeente ? ";
                if (txtPC.Text != "" && txtPC.Text.ToCharArray().All(c => char.IsDigit(c)))
                    ad.Postcode = txtPC.Text;
                else
                    s += "Adress: Postcode ? ";
                if (txtLand.Text != "" && txtLand.Text.ToCharArray().All(c => char.IsLetterOrDigit(c)))
                    ad.Land = txtLand.Text;
                else
                    s += "Adress: Land ? ";
            }
            if (s == "")
            {
                using (var ctx = new ProjectContext())
                {
                    if (newAd && (ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land) == null))
                        lev.adress = ad;
                    else if (newAd && ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land) != null)
                        lev.adress = ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land);
                    else if (!newAd)
                        lev.adress = ctx.Adressen.FirstOrDefault(a => a.AdressId == ((Adress)cmbAdress.SelectedItem).AdressId);
                    ctx.Bezorgers.Add(lev);
                    ctx.SaveChanges();
                    Databeheer.Deliverers = ctx.Bezorgers.Include("adress").ToList();
                }
                Databeheer.dgv_Deliverer.DataSource = null;
                Databeheer.dgv_Deliverer.DataSource = Databeheer.Deliverers;
                btnToevoegen.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(s);
                s = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAdress_TextUpdate(object sender, EventArgs e)
        {
            Global.Adresses = this.Adresses;
            Global.cmbAdress_TextUpdate(sender, e);
        }

        private void cmbAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.Adresses = this.Adresses;
            Global.cmbAdress_KeyPress(sender, e);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
