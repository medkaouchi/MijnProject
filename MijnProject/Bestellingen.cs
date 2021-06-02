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
    public partial class Bestellingen : Form
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
        public static List<OrderLine> OrderLines = new List<OrderLine>();
        public static DataGridView dgv_Orders;
        public static int deleteindex;
        public static int editindex;
        public static OrderLine orderline = new OrderLine();
        public Bestellingen()
        {
            InitializeComponent();
            Global.ModifyForm(this);
            Main.ActiveForm.Close();
            dgv_Orders = dgvOrders;
            using (var ctx=new ProjectContext())
            {
                OrderLines = ctx.Orders.Join(ctx.OrderDetails, o => o.OrderId, od => od.order.OrderId, (o, od) => new OrderLine() {orderid=o.OrderId, klant = o.klant,user=o.user,orderdate=o.OrderDatum,status=o.status,bezorgddoor=o.BezorgdDoor,adress=o.BezorgdAdress,orderdetailid=od.ID,product=od.product,aantal=od.Aantal }).ToList();
            }
            loaddgvOrders();
        }
        public static void loaddgvOrders()
        {
            dgv_Orders.DataSource = null;
            dgv_Orders.Columns.Clear();
            dgv_Orders.DataSource = OrderLines;
            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.Name = "Bewerken";
            EditButtonColumn.Text = "Bewerk";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Verwijderen";
            DeleteButtonColumn.Text = "Verwijder";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            dgv_Orders.Columns.Insert(dgv_Orders.Columns.Count, EditButtonColumn);
            dgv_Orders.Columns.Insert(dgv_Orders.Columns.Count, DeleteButtonColumn);
            dgv_Orders.Columns["Verwijderen"].DisplayIndex = 11;
            dgv_Orders.Columns["Bewerken"].DisplayIndex = 10;
            deleteindex = dgv_Orders.Columns["Verwijderen"].Index;
            editindex = dgv_Orders.Columns["Bewerken"].Index;
            dgv_Orders.Height = dgv_Orders.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgv_Orders.ColumnHeadersHeight + 2;
        }

        private void llblAddOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddOrder addorder = new AddOrder();
            addorder.ShowDialog();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                if (e.ColumnIndex == deleteindex)
                {
                    using (var ctx = new ProjectContext())
                    {
                        OrderLine ordln = (OrderLine)dgvOrders.Rows[e.RowIndex].DataBoundItem;
                        //OrderDetail ods = ctx.OrderDetails.FirstOrDefault(g => g.order.OrderId == ordln.orderid && g.product.ProductId == ordln.product.ProductId);
                        ctx.Products.FirstOrDefault(p => p.ProductId == ordln.product.ProductId).UnitsOnStock += ordln.aantal;
                        ctx.OrderDetails.RemoveRange(ctx.OrderDetails.Where(g => g.order.OrderId == ordln.orderid && g.product.ProductId== ordln.product.ProductId));
                        ctx.SaveChanges();
                        OrderLines = ctx.Orders.Join(ctx.OrderDetails, o => o.OrderId, od => od.order.OrderId, (o, od) => new OrderLine() { orderid = o.OrderId, klant = o.klant, user = o.user, orderdate = o.OrderDatum, status = o.status, bezorgddoor = o.BezorgdDoor, adress = o.BezorgdAdress, orderdetailid = od.ID, product = od.product, aantal = od.Aantal }).ToList();
                        
                    }
                }
                else if (e.ColumnIndex == editindex)
                {
                    orderline = dgvOrders.Rows[e.RowIndex].DataBoundItem as OrderLine;
                        EditOrder editorder = new EditOrder();
                    editorder.ShowDialog();
                }
            loaddgvOrders();
        }

        private void Bestellingen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
