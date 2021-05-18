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
        public static ComboBox cmb_Categorie = new ComboBox();
        public static ComboBox cmb_Leveranciere = new ComboBox();
        public static List<Levrancier> Leveranciers = new List<Levrancier>();
        Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

        public EditProduct()
        {
            InitializeComponent();
            using (var ctx=new ProjectContext())
            {
                Leveranciers = ctx.Levranciers.ToList();
            }
            cmbLeverancier.DataSource = Leveranciers;
            txtNaam.Text = Databeheer.product.ProductNaam;
            txtUnitprice.Text = Databeheer.product.UnitPrice.ToString();
            txtUnitsOnStock.Text = Databeheer.product.UnitsOnStock.ToString();
            txtProductNummer.Text = Databeheer.product.ProductNummer.ToString();
            txtBarcode.Text = Databeheer.product.BarCode;
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
            if (txtUnitprice.Text != "" && txtUnitprice.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.UnitPrice =Convert.ToDouble( txtUnitprice.Text);
            else
                s += "Unit prijs? ";
            if (txtUnitsOnStock.Text != "" && txtUnitsOnStock.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.UnitsOnStock = Convert.ToInt32(txtUnitsOnStock.Text);
            else
                s += "Units on stock? ";
            if (txtProductNummer.Text != "" && txtProductNummer.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.ProductNummer = txtProductNummer.Text;
            else
                s += "Product nummer? ";
            if (txtBarcode.Text != "" && txtBarcode.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.BarCode = txtBarcode.Text;
            else
                s += "BarCode? ";
            if (txtGewicht.Text != "" && txtGewicht.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.Gewicht = Convert.ToDouble(txtGewicht.Text);
            else
                s += "Gewicht? ";
            if (txtBreedte.Text != "" && txtBreedte.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.Breedte = Convert.ToDouble(txtBreedte.Text);
            else
                s += "Breedte? ";
            if (txtLengte.Text != "" && txtLengte.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.Lengte = Convert.ToDouble(txtLengte.Text);
            else
                s += "Lengte? ";
            if (txtHoogte.Text != "" && txtHoogte.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.Hoogte = Convert.ToDouble(txtHoogte.Text);
            else
                s += "Hoogte? ";
            if (rtbOmschrijving.Text != "")
                pr.Omschrijving = rtbOmschrijving.Text;
            pr.levrancier = (Levrancier)cmbLeverancier.SelectedItem;
            if(s=="")
            {
                using (var ctx=new ProjectContext())
                {
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
            }
            else
                {
                    MessageBox.Show(s);
                    s = "";
                }
        }
    }
}
