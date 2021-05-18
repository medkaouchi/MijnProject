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
    public partial class AddLeverancier : Form
    {
        public AddLeverancier()
        {
            InitializeComponent();
            List<Adress> Adresses = new List<Adress>();
            using (var ctx = new ProjectContext())
                Adresses = ctx.Adressen.ToList();
            cmbAdress.DataSource = Adresses;
        }
        bool newAd = false;
        Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

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
            Levrancier lev = new Levrancier();
            if (txtNaam.Text != "")
                lev.Naam = txtNaam.Text;
            else
                s += "Naam? ";
            lev.Omschrijving = rtbOmschrijving.Text;
            if(txtTel1.Text!="" && txtTel1.Text.ToCharArray().All(c => char.IsDigit(c)))
                lev.Telefoon1 = txtTel1.Text;
            else
                s += "Telefoon1? ";
            if (txtTel2.Text != "" && txtTel2.Text.ToCharArray().All(c => char.IsDigit(c)))
                lev.Telefoon2 = txtTel2.Text;
            if (re.IsMatch(txtEmail.Text))
                lev.Email = txtEmail.Text;
            else
                s += "Email? ";
            lev.adress = (Adress)cmbAdress.SelectedItem;
            if (s == "")
            {
                using (var ctx = new ProjectContext())
                {
                    ctx.Levranciers.Add(lev);
                    ctx.SaveChanges();
                    EditProduct.Leveranciers = ctx.Levranciers.ToList();
                }
                EditProduct.cmb_Leveranciere.DataSource = null;
                EditProduct.cmb_Leveranciere.DataSource = EditProduct.Leveranciers;
                EditProduct.cmb_Leveranciere.SelectedItem = lev;
            }
            else
                MessageBox.Show(s);
        }
    }
}
