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
    public partial class AddUser : Form
    {
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        public AddUser()
        {
            InitializeComponent();
            Global.ModifyForm(this);
            List<Adress> Adresses = new List<Adress>();
            cmbRoles.DataSource = Enum.GetValues(typeof(RoleUser));
            using (var ctx = new ProjectContext())
                Adresses = ctx.Adressen.ToList();
            cmbAdress.DataSource = Adresses;
        }
        bool newAd = false;
        private void button1_Click(object sender, EventArgs e)
        {
            User us = new User();
            Adress ad = new Adress();
            string s = "";
            Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Regex re1 = new Regex("^(?=.*?[A-Za-z])(?=.*?[0-9])(?=.*?[#?!@$%^_&*-]).{8,}$");
            if (txtVnaam.Text != "" && txtVnaam.Text.ToCharArray().All(c => char.IsLetter(c)))
                us.Voornaam = txtVnaam.Text;
            else
                s+="Voornaam ? ";
            if (txtAnaam.Text != "" && txtAnaam.Text.ToCharArray().All(c => char.IsLetter(c)))
                us.Achternaam = txtAnaam.Text;
            else
                s+="Achternaam ? ";
            if (dtpGD.Value != null && dtpGD.Value < DateTime.Now)
                us.Geboortdatum = dtpGD.Value;
            else
                s += "Geboortdatum ? ";
            if (txtTel.Text != "" && txtTel.Text.ToCharArray().All(c => char.IsDigit(c)))
                us.Telefoon = txtTel.Text;
            else
                s += "Telefoon ? ";
            if (re.IsMatch(txtEmail.Text))
                us.Email = txtEmail.Text;
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
            User u=null;
            using(var ctx=new ProjectContext())
            {
                u = ctx.Users.FirstOrDefault(U => U.Username == txtUsername.Text);
            }
            if (txtUsername.Text != "" && txtUsername.Text.ToCharArray().All(c => char.IsLetter(c)) &&u==null)
                us.Username = txtUsername.Text;
            else
                s += "Usernaam ? ";
            if (re1.IsMatch(txtWachtwoord1.Text) && txtWachtwoord1.Text == txtWachtwoord2.Text)
                us.Wachtwoord = txtWachtwoord1.Text.Aggregate("", (c, a) => c + (char)(a + 2));
            else
                s += "Wachtwoord ? ";
            us.Role =(RoleUser) cmbRoles.SelectedItem;
            if (s == "")
            {
                using (var ctx = new ProjectContext())
                {
                    if(newAd)
                        us.adress = ad;
                    else
                        us.adress =ctx.Adressen.FirstOrDefault(a=>a.AdressId==((Adress)cmbAdress.SelectedItem).AdressId);
                    ctx.Users.Add(us);
                    ctx.SaveChanges();
                    Databeheer.Users = ctx.Users.Include("Adress").ToList();
                }
                Databeheer.loaddgvusers();
                txtVnaam.Text = "";
                txtAnaam.Text = "";
                dtpGD.Value = DateTime.Now;
                txtTel.Text = "";
                txtEmail.Text = "";
                txtStraat.Text = "";
                txtHuisNr.Text = "";
                txttGem.Text = "";
                txtPC.Text = "";
                txtLand.Text = "";
                txtUsername.Text = "";
                txtWachtwoord1.Text = "";
                txtWachtwoord2.Text = "";
                cmbRoles.SelectedIndex = 0;
                cmbAdress.SelectedIndex = 0;
                pnlAdress.Visible = false;
                cmbAdress.Enabled = true;
                newAd = false;
            }
            else
            { 
                MessageBox.Show(s);
                s = "";
                this.DialogResult = DialogResult.OK;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
