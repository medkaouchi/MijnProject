using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijnProject
{
    public partial class AddOrder : Form
    {
        bool newAd = false;
        public static List<Klant> Klanten = new List<Klant>();
        public static List<Product> Producten = new List<Product>();
        public List<ProductOrdered> ProductsOrdered = new List<ProductOrdered>();
        public static ComboBox cmb_Klanten;
        public static int deleteindex;
        public static int editindex;
        public AddOrder()
        {
            InitializeComponent();
            using (var ctx=new ProjectContext())
            {
                Klanten = ctx.Klanten.Include("adress").ToList();
                Producten = ctx.Products.ToList();
            }
            cmbKlanten.DataSource = Klanten;
            cmb_Klanten = cmbKlanten;
            cmbProducten.SelectedIndexChanged -= new System.EventHandler(cmbProducten_SelectedIndexChanged);
            cmbProducten.DataSource = Producten;
            cmbProducten.SelectedIndexChanged += new System.EventHandler(cmbProducten_SelectedIndexChanged);
            cmbStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        private void llblNewKlant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddKlant addklant = new AddKlant();
            addklant.ShowDialog();
        }

        private void cmbKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKlanten.Items.Count>0)
            lblKlantAdress.Text = ((Klant)(cmbKlanten.SelectedItem)).adress.ToString();
        }

        private void llblAddAdress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAdress.Visible = true;
            lblKlantAdress.Visible = false;
            newAd = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdress.Visible = false;
            lblKlantAdress.Visible = true;
            newAd = false;
        }
        public void NewProductOrdered(ProductOrdered pror)
        {
            if (ProductsOrdered.FirstOrDefault(p => p.ProductId == pror.ProductId) == null)
                ProductsOrdered.Add(pror);
            else
                ProductsOrdered.FirstOrDefault(p => p.ProductId == pror.ProductId).aantal += 1;
            dgvOrderProducten.DataSource = null;
            dgvOrderProducten.Columns.Clear();
            dgvOrderProducten.DataSource = ProductsOrdered;
            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.Name = "Aantal Bewerken";
            EditButtonColumn.Text = "Bewerk Aantal";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Verwijderen";
            DeleteButtonColumn.Text = "Verwijder";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvOrderProducten.Columns.Insert(dgvOrderProducten.Columns.Count, EditButtonColumn);
            dgvOrderProducten.Columns.Insert(dgvOrderProducten.Columns.Count, DeleteButtonColumn);
            dgvOrderProducten.Columns["Verwijderen"].DisplayIndex = 7;
            dgvOrderProducten.Columns["Aantal Bewerken"].DisplayIndex = 6;
            deleteindex = dgvOrderProducten.Columns["Verwijderen"].Index;
            editindex = dgvOrderProducten.Columns["Aantal Bewerken"].Index;
        }

        private void cmbProducten_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            Product p = cmb.SelectedItem as Product;
            ProductOrdered po = new ProductOrdered();
            po.ProductId = p.ProductId;
            po.ProductNaam = p.ProductNaam;
            po.levrancier = p.levrancier;
            po.UnitPrice = p.UnitPrice;
            po.Omschrijving = p.Omschrijving;
            po.aantal = 1;
            NewProductOrdered(po);
        }

        private void txtPrNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Product p = new Product();
                using (var ctx=new ProjectContext())
                    p = ctx.Products.FirstOrDefault(P=>P.ProductNummer==txtPrNummer.Text);
                if (p != null)
                {
                    ProductOrdered po = new ProductOrdered();
                    po.ProductId = p.ProductId;
                    po.ProductNaam = p.ProductNaam;
                    po.levrancier = p.levrancier;
                    po.UnitPrice = p.UnitPrice;
                    po.Omschrijving = p.Omschrijving;
                    po.aantal = 1;
                    NewProductOrdered(po);
                }
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Product p = new Product();
                using (var ctx = new ProjectContext())
                    p = ctx.Products.FirstOrDefault(P => P.BarCode == txtBarcode.Text);
                if (p != null)
                {
                    ProductOrdered po = new ProductOrdered();
                    po.ProductId = p.ProductId;
                    po.ProductNaam = p.ProductNaam;
                    po.levrancier = p.levrancier;
                    po.UnitPrice = p.UnitPrice;
                    po.Omschrijving = p.Omschrijving;
                    po.aantal = 1;
                    NewProductOrdered(po);
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Adress ad = new Adress();
            string s = "";
            using (var ctx=new ProjectContext())
                foreach (ProductOrdered item in ProductsOrdered)
                {
                    Order ord = new Order();
                    OrderDetail orddt = new OrderDetail();
                    ord.OrderDatum = DateTime.UtcNow;
                    ord.status =(OrderStatus) cmbStatus.SelectedItem;
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
                    if (newAd)
                        ord.BezorgdAdress = ad;
                    else
                        ord.BezorgdAdress = ctx.Adressen.FirstOrDefault(a=>a.AdressId==((Klant)cmbKlanten.SelectedItem).adress.AdressId);
                    ord.klant = ctx.Klanten.FirstOrDefault(k=>k.KlantId== ((Klant)cmbKlanten.SelectedItem).KlantId);
                    ord.user= ctx.Users.FirstOrDefault(a => a.UserId == ((User)Login.user).UserId);
                    ctx.Orders.Add(ord);
                    ctx.SaveChanges();
                    orddt.order = ctx.Orders.FirstOrDefault(o => o.OrderId == ord.OrderId);
                    orddt.product = ctx.Products.FirstOrDefault(p=>p.ProductId==item.ProductId);
                    orddt.Aantal = item.aantal;
                    ctx.OrderDetails.Add(orddt);
                    ctx.SaveChanges();
                    Bestellingen.OrderLines = ctx.Orders.Join(ctx.OrderDetails, o => o.OrderId, od => od.order.OrderId, (o, od) => new OrderLine() { orderid = o.OrderId, klant = o.klant, user = o.user, orderdate = o.OrderDatum, status = o.status, bezorgddoor = o.BezorgdDoor, adress = o.BezorgdAdress, orderdetailid = od.ID, product = od.product, aantal = od.Aantal }).ToList();
                    Bestellingen.loaddgvOrders();
                }
        }
    }
}
