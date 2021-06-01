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
    public partial class AddProduct : Form
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
        public static ComboBox cmb_Leveranciere = new ComboBox();
        public static List<Levrancier> Leveranciers = new List<Levrancier>();
        Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

        public AddProduct()
        {
            InitializeComponent();
            Global.ModifyForm(this);
            using (var ctx = new ProjectContext())
            {
                Leveranciers = ctx.Levranciers.ToList();
            }
            cmbLeverancier.DataSource = Leveranciers;
            cmb_Leveranciere = cmbLeverancier;
            cmbLeverancier.SelectedIndex = -1;
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
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            string s = "";
            Product pr = new Product();
            if (txtNaam.Text != "" && txtNaam.Text.ToCharArray().All(c => char.IsLetter(c)))
                 pr.ProductNaam = txtNaam.Text;
            else
                s += "Naam? ";
            if (IsDouble(txtUnitprice.Text))
                pr.UnitPrice = Convert.ToDouble(txtUnitprice.Text);
            else
                s += "Unit prijs? ";
            if (txtUnitsOnStock.Text != "" && txtUnitsOnStock.Text.ToCharArray().All(c => char.IsDigit(c)))
                pr.UnitsOnStock = Convert.ToInt32(txtUnitsOnStock.Text);
            else
                s += "Units on stock? ";
            if (txtProductNummer.Text != "" && txtProductNummer.Text.ToCharArray().All(c => char.IsDigit(c)))
                using (var ctx=new ProjectContext())
                {
                    if(ctx.Products.FirstOrDefault(p=>p.ProductNummer==txtProductNummer.Text)==null)
                    pr.ProductNummer = txtProductNummer.Text;
                    else
                        s += "Product nummer Exists? ";
                }
            else
                s += "Product nummer? ";
            if (txtBarcode.Text != "" && txtBarcode.Text.ToCharArray().All(c => char.IsDigit(c)))
                using (var ctx = new ProjectContext())
                {
                    if (ctx.Products.FirstOrDefault(p => p.BarCode == txtBarcode.Text) == null)
                        pr.BarCode = txtBarcode.Text;
                    else
                        s += "BarCode Exists? ";
                }
            else
                s += "BarCode? ";
            if (IsDouble(txtGewicht.Text))
                pr.Gewicht = Convert.ToDouble(txtGewicht.Text);
            else
                s += "Gewicht? ";
            if (IsDouble(txtBreedte.Text))
                pr.Breedte = Convert.ToDouble(txtBreedte.Text);
            else
                s += "Breedte? ";
            if (IsDouble(txtLengte.Text))
                pr.Lengte = Convert.ToDouble(txtLengte.Text);
            else
                s += "Lengte? ";
            if (IsDouble(txtHoogte.Text))
                pr.Hoogte = Convert.ToDouble(txtHoogte.Text);
            else
                s += "Hoogte? ";
            if (rtbOmschrijving.Text != "")
                pr.Omschrijving = rtbOmschrijving.Text;
            if (s == "")
            {
                using (var ctx = new ProjectContext())
                {
                    pr.levrancier =ctx.Levranciers.FirstOrDefault(l=>l.LevrancierID==((Levrancier)cmbLeverancier.SelectedItem).LevrancierID) ;
                    ctx.Products.Add(pr);
                    ctx.SaveChanges();
                    Databeheer.Producten = ctx.Products.ToList();
                }
                Databeheer.loaddgvprodut();
                txtNaam.Text = "";
                txtUnitprice.Text = "";
                txtUnitsOnStock.Text = "";
                txtProductNummer.Text = "";
                txtLengte.Text = "";
                txtHoogte.Text = "";
                txtGewicht.Text = "";
                txtBreedte.Text = "";
                txtBarcode.Text = "";
                rtbOmschrijving.Text = "";
                cmbLeverancier.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(s);
                s = "";
            }
        }

        private void llblNewLeverancier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddLeverancier addlev = new AddLeverancier();
            addlev.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
