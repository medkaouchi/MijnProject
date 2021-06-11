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
        List<Bezorger> Bezorgers = new List<Bezorger>();
        bool newAd = false;
        public static int aantal;
        public static int rowindex;
        public static List<Klant> Klanten = new List<Klant>();
        public static List<Product> Producten = new List<Product>();
        public  List<ProductOrdered> ProductsOrdered = new List<ProductOrdered>();
        public static ComboBox cmb_Klanten;
        public static int deleteindex;
        public static int editindex;
        public static DataGridView dgv_OrderProducten;
        public AddOrder()
        {
            InitializeComponent();
            using (var ctx=new ProjectContext())
            {
                Klanten = ctx.Klanten.Include("adress").ToList();
                Producten = ctx.Products.Include("levrancier").Where(p=>p.UnitsOnStock>0).ToList();
                Bezorgers = ctx.Bezorgers.ToList();
            }
            dgv_OrderProducten = dgvOrderProducten;
            cmbKlanten.DataSource = Klanten;
            cmbBezorgers.DataSource = Bezorgers;
            cmbBezorgers.SelectedIndex = -1;
            cmb_Klanten = cmbKlanten;
            cmbProducten.SelectedIndexChanged -= new System.EventHandler(cmbProducten_SelectedIndexChanged);
            cmbProducten.DataSource = Producten;
            cmbProducten.SelectedIndexChanged += new System.EventHandler(cmbProducten_SelectedIndexChanged);
            cmbStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            Global.ModifyForm(this);
            if(dgvOrderProducten.Height<250)
            dgvOrderProducten.Height = dgvOrderProducten.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgvOrderProducten.ColumnHeadersHeight + 2;
        }

        private void llblNewKlant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddKlant addklant = new AddKlant();
            addklant.ShowDialog();
        }

        private void cmbKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKlanten.Items.Count > 0)
                if(cmbKlanten.SelectedItem!=null)
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

        private void cmbProducten_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            Product p = cmb.SelectedItem as Product;
            ProductOrdered po = new ProductOrdered();
            if (p != null)
            {
                po.ProductId = p.ProductId;
                po.ProductNaam = p.ProductNaam;
                po.levrancier = p.levrancier;
                po.UnitPrice = p.UnitPrice;
                po.Omschrijving = p.Omschrijving;
                po.aantal = 1;
                NewProductOrdered(po);
            }
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
            bool overstock = false;
            Adress ad = new Adress();
            string s = "";
            
                Order ord = new Order();
                OrderDetail orddt = new OrderDetail();
                ord.OrderDatum = DateTime.UtcNow;
                ord.status = (OrderStatus)cmbStatus.SelectedItem;
                if (ord.status > OrderStatus.Geanuleerd && ord.BezorgdDoor == null)
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
            using (var ctx = new ProjectContext())
            {
                foreach (ProductOrdered item in ProductsOrdered)
                {
                    if (ctx.Products.FirstOrDefault(p => p.ProductId == item.ProductId).UnitsOnStock < item.aantal)
                    {
                        overstock = true;
                        s+=$"Slechts {ctx.Products.FirstOrDefault(p => p.ProductId == item.ProductId).UnitsOnStock} stuks zijn beschikbaar voor artikel: {ctx.Products.FirstOrDefault(p => p.ProductId == item.ProductId)} ";
                    }
                }
            }

                if (s == "")
                using (var ctx = new ProjectContext())
                {
                    this.DialogResult = DialogResult.OK;
                    if (newAd && (ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land) == null))
                        ord.BezorgdAdress = ad;
                    else if (newAd && ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land) != null)
                        ord.BezorgdAdress = ctx.Adressen.FirstOrDefault(a => a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land == ad.Straat + " " + ad.Huisnummer + " " + ad.Gemeente + " " + ad.Postcode + " " + ad.Land);
                    else if (!newAd)
                        ord.BezorgdAdress = ctx.Adressen.FirstOrDefault(a => a.AdressId == ((Klant)cmbKlanten.SelectedItem).adress.AdressId);
                    ord.klant = ctx.Klanten.FirstOrDefault(k => k.KlantId == ((Klant)cmbKlanten.SelectedItem).KlantId);
                    ord.user = ctx.Users.FirstOrDefault(a => a.UserId == ((User)Login.user).UserId);
                    if(cmbBezorgers.SelectedIndex>-1)
                    ord.BezorgdDoor =ctx.Bezorgers.FirstOrDefault(b=>b.BezorgerId== ((Bezorger)cmbBezorgers.SelectedItem).BezorgerId);
                    ctx.Orders.Add(ord);
                    ctx.SaveChanges();
                    foreach (ProductOrdered item in ProductsOrdered)
                    {
                            orddt.order = ctx.Orders.FirstOrDefault(o => o.OrderId == ord.OrderId);
                            orddt.product = ctx.Products.FirstOrDefault(p => p.ProductId == item.ProductId);
                            orddt.Aantal = item.aantal;
                            ctx.Products.FirstOrDefault(p => p.ProductId == item.ProductId).UnitsOnStock -= item.aantal;
                            ctx.OrderDetails.Add(orddt);
                            ctx.SaveChanges();
                    }
                    Bestellingen.OrderLines = ctx.Orders.Join(ctx.OrderDetails, o => o.OrderId, od => od.order.OrderId, (o, od) => new OrderLine() { orderid = o.OrderId, klant = o.klant, user = o.user, orderdate = o.OrderDatum, status = o.status, bezorgddoor = o.BezorgdDoor, adress = o.BezorgdAdress, orderdetailid = od.ID, product = od.product, aantal = od.Aantal }).OrderByDescending(o => o.orderdate).ToList();
                    Bestellingen.loaddgvOrders();
                    DialogResult dr = MessageBox.Show("FActuur afdrukken?", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                            printDocument1.Print();
                    }
                }
            else
            {
                MessageBox.Show(s);
                s = "";
            }
        }

        private void dgvOrderProducten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == editindex)
                {
                    rowindex = e.RowIndex;
                    aantal = Convert.ToInt32(dgvOrderProducten.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value);
                    EditAantal.parent = "Add";
                    EditAantal editaantal = new EditAantal();
                    editaantal.ShowDialog();
                }
                if (e.ColumnIndex == deleteindex)
                {
                    ProductsOrdered.Remove((ProductOrdered)dgvOrderProducten.Rows[e.RowIndex].DataBoundItem);

                    dgvOrderProducten.DataSource = null;
                    dgvOrderProducten.DataSource = ProductsOrdered;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (dgvOrderProducten.Height < 250)
                dgvOrderProducten.Height = dgvOrderProducten.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgvOrderProducten.ColumnHeadersHeight + 2;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.HasMorePages = false;
            float x = 10;
            float y = 10;
            int imgWidth = 200;
            int imgHeight = 200;
            string ordID = "Order id : " + Bestellingen.orderline.orderid.ToString();
            string klant = "Klant : " + cmbKlanten.SelectedItem.ToString();
            string date = "Datum : " + DateTime.UtcNow.ToString();
            Pen p = new Pen(Color.Black, 1);
            Font f = new Font("Arial", 16, FontStyle.Bold);
            Font f1 = new Font("Arial", 14, FontStyle.Bold);
            Font f2 = new Font("Arial", 12, FontStyle.Bold);
            SizeF strSizeInvNum = e.Graphics.MeasureString(ordID, f);
            SizeF strSizeDate = e.Graphics.MeasureString(date, f);
            SizeF strSizeName = e.Graphics.MeasureString(klant, f);
            e.Graphics.DrawImage(Image.FromFile(Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 9) + "Resources\\download.jpg"), x, y, imgWidth, imgHeight);
            e.Graphics.DrawString(ordID, f, Brushes.DarkBlue, imgWidth + x, y);
            e.Graphics.DrawString(date, f, Brushes.DarkBlue, imgWidth + x, y + imgHeight / 2);
            e.Graphics.DrawString(klant, f, Brushes.DarkBlue, imgWidth + x, y + strSizeInvNum.Height + strSizeDate.Height * 4);
            float preHeight = strSizeInvNum.Height + strSizeDate.Height + strSizeName.Height + imgHeight + y;
            e.Graphics.DrawRectangle(p, x, imgHeight + y * 2, e.PageBounds.Width - x * 2, e.PageBounds.Height - preHeight);
            float colHeight = 60;
            float col1Width = 180;
            float col2Width = 200 + col1Width;
            float col3Width = 75 + col2Width;
            float col4Width = 80 + col3Width;
            float col5Width = 60 + col4Width;
            float col6Width = 80 + col5Width;
            e.Graphics.DrawLine(p, x, preHeight, e.PageBounds.Width - x, preHeight);

            e.Graphics.DrawString("Product", f, Brushes.DarkBlue, x * 2, preHeight - colHeight);
            e.Graphics.DrawLine(p, x * 2 + col1Width, imgHeight + y * 2, x * 2 + col1Width, e.PageBounds.Height - colHeight - y * 4);
            e.Graphics.DrawString("Omschrijving", f, Brushes.DarkBlue, x * 2 + col1Width, preHeight - colHeight);
            e.Graphics.DrawLine(p, x * 2 + col2Width, imgHeight + y * 2, x * 2 + col2Width, e.PageBounds.Height - colHeight - y * 4);
            e.Graphics.DrawString("Prijs", f, Brushes.DarkBlue, x * 2 + col2Width, preHeight - colHeight);
            e.Graphics.DrawLine(p, x * 2 + col3Width, imgHeight + y * 2, x * 2 + col3Width, e.PageBounds.Height - colHeight - y * 4);
            e.Graphics.DrawString("Prijs (btw)", f2, Brushes.DarkBlue, x * 2 + col3Width, preHeight - colHeight + 3);
            e.Graphics.DrawLine(p, x * 2 + col4Width, imgHeight + y * 2, x * 2 + col4Width, e.PageBounds.Height - colHeight - y * 4);
            e.Graphics.DrawString("Qtt", f, Brushes.DarkBlue, x * 2 + col4Width, preHeight - colHeight);
            e.Graphics.DrawLine(p, x * 2 + col5Width, imgHeight + y * 2, x * 2 + col5Width, e.PageBounds.Height - colHeight - y * 4);
            e.Graphics.DrawString("Totaal", f, Brushes.DarkBlue, x * 2 + col5Width, preHeight - colHeight);
            e.Graphics.DrawLine(p, x * 2 + col6Width, imgHeight + y * 2, x * 2 + col6Width, e.PageBounds.Height - colHeight - y * 4);
            e.Graphics.DrawString("Totaal (btw)", f2, Brushes.DarkBlue, x * 2 + col6Width, preHeight - colHeight + 3);
            e.Graphics.DrawLine(p, x * 2 + col6Width, imgHeight + y * 2, x * 2 + col6Width, e.PageBounds.Height - colHeight - y * 4);
            //Invoice Content
            float rowHeight = 60;
            double totaal = 0;
            for (int i = 0; i < dgvOrderProducten.Rows.Count; i++)
            {
                totaal += (Convert.ToDouble(dgvOrderProducten.Rows[i].Cells[3].Value) * Convert.ToDouble(dgvOrderProducten.Rows[i].Cells[5].Value));
            }
            for (int i = 0; i < dgvOrderProducten.Rows.Count; i++)
            {
                if (rowHeight >= e.PageBounds.Height - preHeight - colHeight)
                {
                    e.HasMorePages = true;
                    break;
                }

                e.Graphics.DrawString(dgvOrderProducten.Rows[i].Cells[3].Value.ToString(), f2, Brushes.DarkBlue, x * 2, preHeight + rowHeight - colHeight);
                e.Graphics.DrawString(dgvOrderProducten.Rows[i].Cells[6].Value.ToString(), f2, Brushes.DarkBlue, x * 2 + col1Width, preHeight + rowHeight - colHeight);
                e.Graphics.DrawString(Convert.ToDouble(dgvOrderProducten.Rows[i].Cells[5].Value).ToString("0.##"), f2, Brushes.DarkBlue, x * 2 + col2Width, preHeight + rowHeight - colHeight);
                e.Graphics.DrawString((Convert.ToDouble(dgvOrderProducten.Rows[i].Cells[5].Value) * 1.21).ToString("0.##"), f2, Brushes.DarkBlue, x * 2 + col3Width, preHeight + rowHeight - colHeight);
                e.Graphics.DrawString(dgvOrderProducten.Rows[i].Cells[7].Value.ToString(), f2, Brushes.DarkBlue, x * 2 + col4Width, preHeight + rowHeight - colHeight);
                e.Graphics.DrawString((Convert.ToDouble(dgvOrderProducten.Rows[i].Cells[7].Value) * Convert.ToDouble(dgvOrderProducten.Rows[i].Cells[5].Value)).ToString("0.##"), f2, Brushes.DarkBlue, x * 2 + col5Width, preHeight + rowHeight - colHeight);
                e.Graphics.DrawString((Convert.ToDouble(dgvOrderProducten.Rows[i].Cells[7].Value) * Convert.ToDouble(dgvOrderProducten.Rows[i].Cells[5].Value) * 1.21).ToString("0.##"), f2, Brushes.DarkBlue, x * 2 + col6Width, preHeight + rowHeight - colHeight);
                e.Graphics.DrawLine(p, x, preHeight + rowHeight, e.PageBounds.Width - x,
                    preHeight + rowHeight);

                rowHeight += 60;
            }
            if (rowHeight < e.PageBounds.Height - preHeight - colHeight)
            {
                e.Graphics.DrawString("Totaal zonder btw    :    " + totaal.ToString("0.##"), f, Brushes.Red, e.PageBounds.Width / 2, preHeight + rowHeight - colHeight);
                e.Graphics.DrawLine(p, x, preHeight + rowHeight, e.PageBounds.Width - x, preHeight + rowHeight + 40);
                e.Graphics.DrawString("Totaal inclusief btw :    " + (totaal * 1.21).ToString("0.##"), f, Brushes.Red, e.PageBounds.Width / 2, preHeight + rowHeight + 40 - colHeight);
            }


        }
    }
}
