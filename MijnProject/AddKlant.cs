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
    public partial class AddKlant : Form
    {
        List<Adress> Adresses = new List<Adress>();
        bool newAd = false;
        public AddKlant()
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
            Klant klt = new Klant();
            Adress ad = new Adress();
            string s = "";
            Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (txtVnaam.Text != "" && txtVnaam.Text.ToCharArray().All(c => char.IsLetter(c)))
                klt.Voornaam = txtVnaam.Text;
            else
                s += "Voornaam ? ";
            if (txtAnaam.Text != "" && txtAnaam.Text.ToCharArray().All(c => char.IsLetter(c)))
                klt.achternaam = txtAnaam.Text;
            else
                s += "Achternaam ? ";
            if (dtpGD.Value != null && dtpGD.Value < DateTime.Now)
                klt.Geboortdatum = dtpGD.Value;
            else
                s += "Geboortdatum ? ";
            if (txtTel1.Text != ""  && txtTel1.Text.ToCharArray().All(c => char.IsDigit(c)))
            {
                klt.Telefoon1 = txtTel1.Text;
                if(txtTel2.Text != "")
                    klt.Telefoon2 = txtTel2.Text;
            }
            else
                s += "Telefoon ? ";
            if (re.IsMatch(txtEmail.Text))
                klt.Email = txtEmail.Text;
            else
                s += "Email ? ";
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
            klt.IsBedrijf = cbBedrijf.Checked;
                if (txtBTW.Text != "")
                    klt.BTWNummer = txtBTW.Text;
                else
                    s += "BTW nummer ? ";
            klt.IngevoegdDatum = DateTime.UtcNow;
                if (rtbComentaar.Text != "")
                    klt.Commentaar = rtbComentaar.Text;
                if (s == "")
                {
                    using (var ctx = new ProjectContext())
                    {
                    if (newAd && (ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land) == null))
                    { 
                        klt.adress = ad;
                        ctx.SaveChanges();
                        Adresses = ctx.Adressen.ToList();
                        cmbAdress.DataSource = Adresses;
                    }
                    else if (newAd && ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land) != null)
                        klt.adress = ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land);
                    else if (!newAd)
                        klt.adress = ctx.Adressen.FirstOrDefault(a => a.AdressId == ((Adress)cmbAdress.SelectedItem).AdressId);
                    klt.IngevoegdDoor =ctx.Users.FirstOrDefault(u=>u.UserId==Login.user.UserId) ;
                    ctx.Klanten.Add(klt);
                        ctx.SaveChanges();
                        Databeheer.Klanten = ctx.Klanten.Include("Adress").Include("IngevoegdDoor").ToList();
                    AddOrder.Klanten = ctx.Klanten.Include("Adress").Include("IngevoegdDoor").ToList();
                    EditOrder.Klanten= ctx.Klanten.Include("Adress").Include("IngevoegdDoor").ToList();
                }
                if (AddOrder.cmb_Klanten != null)
                {
                    AddOrder.cmb_Klanten.DataSource = null;
                    AddOrder.cmb_Klanten.DataSource = AddOrder.Klanten;
                }
                if (EditOrder.cmb_Klanten != null)
                {
                    EditOrder.cmb_Klanten.DataSource = EditOrder.Klanten;
                    EditOrder.cmb_Klanten.Text = klt.ToString();
                }
                if(Databeheer.dgv_klanten!=null)
                    Databeheer.loaddgvklants();
                    
                    this.DialogResult = DialogResult.OK;
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

        private void cmbAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.Adresses = this.Adresses;
            Global.cmbAdress_KeyPress(sender, e);
        }

        private void cmbAdress_TextUpdate(object sender, EventArgs e)
        {
            Global.Adresses = this.Adresses;
            Global.cmbAdress_TextUpdate(sender, e);
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
