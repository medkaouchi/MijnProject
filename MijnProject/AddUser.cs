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
        public AddUser()
        {
            InitializeComponent();
            cmbRoles.DataSource = Enum.GetValues(typeof(RoleUser));
        }

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
            if (txtTel.Text != "" && txtVnaam.Text.ToCharArray().All(c => char.IsDigit(c)))
                us.Voornaam = txtVnaam.Text;
            else
                s += "Telefoon ? ";
            if (re.IsMatch(txtEmail.Text))
                us.Email = txtEmail.Text;
            else
                s += "Email ? ";
            if (txtStraat.Text != "" && txtStraat.Text.ToCharArray().All(c => char.IsLetter(c)))
                ad.Straat = txtStraat.Text;
            else
                s += "Adress: Straat ? ";
            if (txtHuisNr.Text != "" && txtHuisNr.Text.ToCharArray().All(c => char.IsLetterOrDigit(c)))
                ad.Huisnummer =Convert.ToInt32( txtHuisNr.Text);
            else
                s += "Adress: Huisnummer ? ";
            if (txttGem.Text != "" && txttGem.Text.ToCharArray().All(c => char.IsLetter(c)))
                ad.Gemeente = txttGem.Text;
            else
                s += "Adress: Gemeente ? ";
            if (txtPC.Text != "" && txtHuisNr.Text.ToCharArray().All(c => char.IsDigit(c)))
                ad.Postcode = txtHuisNr.Text;
            else
                s += "Adress: Postcode ? ";
            if (txtLand.Text != "" && txtLand.Text.ToCharArray().All(c => char.IsLetterOrDigit(c)))
                ad.Land = txtLand.Text;
            else
                s += "Adress: Land ? ";
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
                us.Wachtwoord = txtWachtwoord1.Text;
            else
                s += "Wachtwoord ? ";
            us.Role =(RoleUser) cmbRoles.SelectedItem;
            if(s!="")
            {
                using (var ctx=new ProjectContext())
                {
                    ctx.Adressen.Add(ad);
                    ctx.SaveChanges();
                    us.adress = ad;
                    ctx.Users.Add(us);
                    ctx.SaveChanges();
                    Databeheer.Users = ctx.Users.ToList();
                }
                Databeheer.dgv_users.DataSource = null;
                Databeheer.dgv_users.DataSource = Databeheer.Users;
            }    
        }
    }
}
