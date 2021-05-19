﻿using System;
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
        public static List<OrderLine> OrderLines = new List<OrderLine>();
        public static DataGridView dgv_Orders;
        public static int deleteindex;
        public static int editindex;
        public Bestellingen()
        {
            InitializeComponent();
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
        }

        private void llblAddOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddOrder addorder = new AddOrder();
            addorder.ShowDialog();
        }
    }
}
