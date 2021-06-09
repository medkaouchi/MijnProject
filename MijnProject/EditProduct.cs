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
    public partial class EditProduct : Form
    {
        public static ComboBox cmb_Leveranciere = new ComboBox();
        public static List<Levrancier> Leveranciers = new List<Levrancier>();
        Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        string prNaam;
        string prNummer;
        string prBarcode;
        public EditProduct()
        {
            InitializeComponent();
            Global.ModifyForm(this);
            using (var ctx=new ProjectContext())
            {
                Leveranciers = ctx.Levranciers.ToList();
            }
            cmbLeverancier.DataSource = Leveranciers;
            txtNaam.Text = Databeheer.product.ProductNaam;
            prNaam= Databeheer.product.ProductNaam;
            txtUnitprice.Text = Databeheer.product.UnitPrice.ToString();
            txtUnitsOnStock.Text = Databeheer.product.UnitsOnStock.ToString();
            txtProductNummer.Text = Databeheer.product.ProductNummer.ToString();
            prNummer= Databeheer.product.ProductNummer.ToString();
            txtBarcode.Text = Databeheer.product.BarCode;
            prBarcode= Databeheer.product.BarCode;
            txtGewicht.Text = Databeheer.product.Gewicht.ToString();
            txtBreedte.Text = Databeheer.product.Breedte.ToString();
            txtLengte.Text = Databeheer.product.Lengte.ToString();
            txtHoogte.Text = Databeheer.product.Hoogte.ToString();
            cmbLeverancier.SelectedItem = Databeheer.product.levrancier;
            rtbOmschrijving.Text = Databeheer.product.Omschrijving;
            cmb_Leveranciere = cmbLeverancier;
        }


        private void llblNewLeverancier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddLeverancier addlev = new AddLeverancier();
            addlev.ShowDialog();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            string s= "";
            Product pr = new Product();
            if (txtNaam.Text != "" && txtNaam.Text.ToCharArray().All(c => char.IsLetter(c)))
                 pr.ProductNaam = txtNaam.Text;
                else
                s += "Naam? ";
            if (IsDouble(txtUnitprice.Text ))
                pr.UnitPrice =Convert.ToDouble( txtUnitprice.Text);
            else
                s += "Unit prijs? ";
            if (txtUnitsOnStock.Text != "" && txtUnitsOnStock.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.UnitsOnStock = Convert.ToInt32(txtUnitsOnStock.Text);
            else
                s += "Units on stock? ";
            if (txtProductNummer.Text != "" && txtProductNummer.Text.ToCharArray().All(c => char.IsDigit(c)))
                if (txtProductNummer.Text != prNummer)
                using (var ctx = new ProjectContext())
                {
                    if (ctx.Products.FirstOrDefault(p => p.ProductNummer == txtProductNummer.Text && p.ProductNummer != prNummer) == null)
                        pr.ProductNummer = txtProductNummer.Text;
                    else
                        s += "Product nummer? ";
                }
            else
                s += "Product nummer? ";
            if (txtBarcode.Text != "" && txtBarcode.Text.ToCharArray().All(c => char.IsDigit(c)))
                if(txtBarcode.Text!=prBarcode)
                using (var ctx = new ProjectContext())
                {
                    if (ctx.Products.FirstOrDefault(p => p.BarCode == txtBarcode.Text && p.BarCode!=prBarcode) == null)
                        pr.BarCode = txtBarcode.Text;
                    else
                        s += "BarCode Exists? ";
                }

            else
                s += "BarCode? ";
            if (IsDouble(txtGewicht.Text ))
                pr.Gewicht = Convert.ToDouble(txtGewicht.Text);
            else
                s += "Gewicht? ";
            if (IsDouble( txtBreedte.Text) )
                pr.Breedte = Convert.ToDouble(txtBreedte.Text);
            else
                s += "Breedte? ";
            if (IsDouble(txtLengte.Text ))
                pr.Lengte = Convert.ToDouble(txtLengte.Text);
            else
                s += "Lengte? ";
            if (IsDouble(txtHoogte.Text ))
                pr.Hoogte = Convert.ToDouble(txtHoogte.Text);
            else
                s += "Hoogte? ";
            if (rtbOmschrijving.Text != "")
                pr.Omschrijving = rtbOmschrijving.Text;
            if(s=="")
            {
                using (var ctx=new ProjectContext())
                {
                    pr.levrancier = ctx.Levranciers.FirstOrDefault(l => l.LevrancierID == ((Levrancier)cmbLeverancier.SelectedItem).LevrancierID);
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).ProductNaam = pr.ProductNaam;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).UnitPrice = pr.UnitPrice;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).UnitsOnStock = pr.UnitsOnStock;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).ProductNummer = pr.ProductNummer;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).BarCode = pr.BarCode;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).Gewicht = pr.Gewicht;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).Breedte = pr.Breedte;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).Lengte = pr.Lengte;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).Hoogte = pr.Hoogte;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).Omschrijving = pr.Omschrijving;
                    ctx.Products.FirstOrDefault(p => p.ProductId == Databeheer.product.ProductId).levrancier = pr.levrancier;
                    ctx.SaveChanges();
                    Databeheer.Producten = ctx.Products.ToList();
                }
                Databeheer.loaddgvprodut();
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
        public bool IsDouble(string text)
        {
            double num = 0;
            bool isDouble = false;
            if (string.IsNullOrEmpty(text))
                return false;
            isDouble = double.TryParse(text, out num);
            return isDouble;
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
