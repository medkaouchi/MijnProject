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
    public partial class EditOrder : Form

    {
        List<Bezorger> Bezorgers = new List<Bezorger>();
        bool newAd = false;
        public static int aantal;
        public static int rowindex;
        public static List<Klant> Klanten = new List<Klant>();
        public static List<Product> Producten = new List<Product>();
        public List<ProductOrdered> ProductsOrdered = new List<ProductOrdered>();
        public static ComboBox cmb_Klanten;
        public static int deleteindex;
        public static int editindex;
        public static DataGridView dgv_OrderProducten = new DataGridView();
        public EditOrder()
        {
            InitializeComponent();
            using (var ctx = new ProjectContext())
            {
                Klanten = ctx.Klanten.Include("adress").ToList();
                Producten = ctx.Products.ToList();
                Bezorgers = ctx.Bezorgers.ToList();
                ProductsOrdered = ctx.OrderDetails.Where(o => o.order.OrderId == Bestellingen.orderline.orderid).Join(ctx.Products, od => od.product.ProductId, p => p.ProductId, (od, p) => new ProductOrdered() { ProductId = p.ProductId, ProductNaam = p.ProductNaam, levrancier = p.levrancier, UnitPrice = p.UnitPrice, Omschrijving = p.Omschrijving, aantal = od.Aantal }).ToList();
            }
            dgv_OrderProducten = dgvOrderProducten;
            dgvOrderProducten.DataSource=ProductsOrdered;
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
            cmbKlanten.SelectedIndexChanged -= new System.EventHandler(cmbKlanten_SelectedIndexChanged);
            cmbKlanten.DataSource = Klanten;
            cmbKlanten.SelectedItem = Bestellingen.orderline.klant;
            cmbKlanten.SelectedIndexChanged += new System.EventHandler(cmbKlanten_SelectedIndexChanged);
            cmb_Klanten = cmbKlanten;
            cmbBezorgers.DataSource = Bezorgers;
            cmbProducten.SelectedIndexChanged -= new System.EventHandler(cmbProducten_SelectedIndexChanged);
            cmbProducten.DataSource = Producten;
            cmbProducten.SelectedIndexChanged += new System.EventHandler(cmbProducten_SelectedIndexChanged);
            cmbStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            cmbStatus.SelectedItem = Bestellingen.orderline.status;
            cmbBezorgers.SelectedItem = Bestellingen.orderline.bezorgddoor;
            lblKlantAdress.Text = Bestellingen.orderline.adress.ToString();
        }

        private void cmbKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKlanten.Items.Count > 0)
                lblKlantAdress.Text = ((Klant)(cmbKlanten.SelectedItem)).adress.ToString();
        }

        private void llblNewKlant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddKlant addklant = new AddKlant();
            addklant.ShowDialog();
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

        private void txtPrNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Product p = new Product();
                using (var ctx = new ProjectContext())
                    p = ctx.Products.FirstOrDefault(P => P.ProductNummer == txtPrNummer.Text);
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

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Adress ad = new Adress();
            string s = "";
            
                Order ord = new Order();
                OrderDetail orddt = new OrderDetail();
                ord.OrderDatum = Bestellingen.orderline.orderdate;
                ord.status = (OrderStatus)cmbStatus.SelectedItem; 
                ord.BezorgdDoor = (Bezorger)cmbBezorgers.SelectedItem;
                if(ord.status > OrderStatus.Geanuleerd && ord.BezorgdDoor==null)
                    s += "Bestellingen met staus 'Klaar' of 'Verzondzn' moet ueen bezorger hebben ? ";
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
                using (var ctx = new ProjectContext())
            {
                if (newAd)
                    ord.BezorgdAdress = ad;
                else
                    ord.BezorgdAdress = ctx.Adressen.FirstOrDefault(a => a.AdressId == ((Klant)cmbKlanten.SelectedItem).adress.AdressId);
                ord.klant = ctx.Klanten.FirstOrDefault(k => k.KlantId == ((Klant)cmbKlanten.SelectedItem).KlantId);
                ord.user = Bestellingen.orderline.user;
                if (ord != ctx.Orders.FirstOrDefault(o => o.OrderId == Bestellingen.orderline.orderid))
                {
                     ctx.Orders.FirstOrDefault(o => o.OrderId == Bestellingen.orderline.orderid).klant= ord.klant ;
                     ctx.Orders.FirstOrDefault(o => o.OrderId == Bestellingen.orderline.orderid).OrderDatum= ord.OrderDatum ;
                     ctx.Orders.FirstOrDefault(o => o.OrderId == Bestellingen.orderline.orderid).status= ord.status ;
                     ctx.Orders.FirstOrDefault(o => o.OrderId == Bestellingen.orderline.orderid).BezorgdAdress= ord.BezorgdAdress;
                     ctx.Orders.FirstOrDefault(o => o.OrderId == Bestellingen.orderline.orderid).BezorgdDoor = ord.BezorgdDoor;
                }
                ctx.SaveChanges();
                ctx.OrderDetails.RemoveRange(ctx.OrderDetails.Where(od => od.order.OrderId == Bestellingen.orderline.orderid));
                foreach (ProductOrdered item in ProductsOrdered)
                {
                    orddt.order = ctx.Orders.FirstOrDefault(O => O.OrderId == ctx.Orders.FirstOrDefault(o => o.OrderId == Bestellingen.orderline.orderid).OrderId);
                    orddt.product = ctx.Products.FirstOrDefault(p => p.ProductId == item.ProductId);
                    orddt.Aantal = item.aantal;
                    ctx.OrderDetails.Add(orddt);
                }
                ctx.SaveChanges();
                Bestellingen.OrderLines = ctx.Orders.Join(ctx.OrderDetails, o => o.OrderId, od => od.order.OrderId, (o, od) => new OrderLine() { orderid = o.OrderId, klant = o.klant, user = o.user, orderdate = o.OrderDatum, status = o.status, bezorgddoor = o.BezorgdDoor, adress = o.BezorgdAdress, orderdetailid = od.ID, product = od.product, aantal = od.Aantal }).ToList();
                Bestellingen.loaddgvOrders();
            }
            else
                MessageBox.Show(s);
        }

        private void dgvOrderProducten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            { 
                if (e.ColumnIndex == editindex)
                {
                    rowindex = e.RowIndex;
                    aantal = Convert.ToInt32(dgvOrderProducten.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value);
                    EditAantal editaantal = new EditAantal();
                    editaantal.ShowDialog();
                }
                if(e.ColumnIndex==deleteindex)
                {
                    ProductsOrdered.Remove((ProductOrdered)dgvOrderProducten.Rows[e.RowIndex].DataBoundItem);
                    dgvOrderProducten.DataSource = null;
                    dgvOrderProducten.DataSource = ProductsOrdered;
                }
            }
        }
    }
}
