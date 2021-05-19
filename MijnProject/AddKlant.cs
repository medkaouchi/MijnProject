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
        public AddKlant()
        {
            InitializeComponent();
            using (var ctx = new ProjectContext())
                Adresses = ctx.Adressen.ToList();
            cmbAdress.DataSource = Adresses;
        }
        bool newAd = false;

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
                        if (newAd)
                            ctx.Adressen.Add(ad);
                        ctx.SaveChanges();
                        Adresses = ctx.Adressen.ToList();
                        cmbAdress.DataSource = Adresses;
                    if (newAd)
                            klt.adress = ad;
                        else
                            klt.adress = (Adress)cmbAdress.SelectedItem;

                    klt.IngevoegdDoor =ctx.Users.FirstOrDefault(u=>u.UserId==Login.user.UserId) ;
                    ctx.Klanten.Add(klt);
                        ctx.SaveChanges();
                        Databeheer.Klanten = ctx.Klanten.Include("Adress").Include("IngevoegdDoor").ToList();
                    }
                    Databeheer.loaddgvklants();
                    txtVnaam.Text = "";
                    txtAnaam.Text = "";
                    dtpGD.Value = DateTime.Now;
                    txtTel1.Text = "";
                    txtTel2.Text = "";
                    txtEmail.Text = "";
                    txtStraat.Text = "";
                    txtHuisNr.Text = "";
                    txttGem.Text = "";
                    txtPC.Text = "";
                    txtLand.Text = "";
                    cbBedrijf.Checked = false;
                    txtBTW.Text = "";
                    rtbComentaar.Text = "";
                    cmbAdress.SelectedIndex = 0;
                    pnlAdress.Visible = false;
                    cmbAdress.Enabled = true;
                    newAd = false;
                }
                else
                {
                    MessageBox.Show(s);
                    s = "";

                }
            }
        
    }
}
