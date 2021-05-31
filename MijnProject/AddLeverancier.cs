﻿using System;
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
            Adress ad = new Adress();
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
                if (newAd)
                    lev.adress = ad;
                else
                    lev.adress = (Adress)cmbAdress.SelectedItem;
                using (var ctx = new ProjectContext())
                {
                    ctx.Levranciers.Add(lev);
                    ctx.SaveChanges();
                    EditProduct.Leveranciers = ctx.Levranciers.ToList();
                    AddProduct.Leveranciers= ctx.Levranciers.ToList();
                }
                EditProduct.cmb_Leveranciere.DataSource = null;
                EditProduct.cmb_Leveranciere.DataSource = EditProduct.Leveranciers;
                EditProduct.cmb_Leveranciere.SelectedItem = lev;
                AddProduct.cmb_Leveranciere.DataSource = null;
                AddProduct.cmb_Leveranciere.DataSource = AddProduct.Leveranciers;
                AddProduct.cmb_Leveranciere.SelectedItem = lev;
                btnToevoegen.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(s);
        }
    }
}
