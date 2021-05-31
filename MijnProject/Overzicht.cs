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
    public partial class Overzicht : Form
    {
        public Overzicht()
        {
            InitializeComponent();
            Main.ActiveForm.Close();
        }

        private void cmbOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnToon_Click(object sender, EventArgs e)
        {
            DateTime date1 = dtpBegin.Value;
            DateTime date2 = dtpEind.Value;
            using (var ctx = new ProjectContext())
            {
                switch (cmbOverzicht.SelectedIndex)
                {
                    case 0:
                        var products = ctx.OrderDetails.Where(od=>od.order.OrderDatum>=date1&& od.order.OrderDatum <= date2).GroupBy(od => od.product).OrderByDescending(od => od.Sum(ods => ods.Aantal)).Select(od => new { product = od.Key.ProductNaam + " [" + od.Key.ProductNummer + "]", totaal = od.Sum(ods => ods.Aantal) }).ToList();
                        crtTopverkocht.DataSource = products.Take(10);
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("product");
                        crtTopverkocht.Series["product"].XValueMember = "product";
                        crtTopverkocht.Series["product"].YValueMembers = "totaal";
                        crtTopverkocht.ChartAreas[0].BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None;
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("10 best verkochte producten");
                        break;
                    case 1:
                        var productsor = ctx.OrderDetails.Where(od => od.order.OrderDatum >= date1 && od.order.OrderDatum <= date2).GroupBy(od => od.product).Select(od => new { product = od.Key.ProductNaam + " [" + od.Key.ProductNummer + "]", totaal = od.Count() }).OrderByDescending(od => od.totaal).ToList();
                        crtTopverkocht.DataSource = productsor.Take(10);
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("product");
                        crtTopverkocht.Series["product"].XValueMember = "product";
                        crtTopverkocht.Series["product"].YValueMembers = "totaal";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("10 best bestelde producten");
                        break;
                    case 2:
                        var products1 = ctx.OrderDetails.Where(od => od.order.OrderDatum >= date1 && od.order.OrderDatum <= date2).GroupBy(od => od.product).OrderBy(od => od.Sum(ods => ods.Aantal)).Select(od => new { product = od.Key.ProductNaam + " [" + od.Key.ProductNummer + "]", totaal = od.Sum(ods => ods.Aantal) }).ToList();
                        crtTopverkocht.DataSource = products1.Take(10);
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("product");
                        crtTopverkocht.Series["product"].XValueMember = "product";
                        crtTopverkocht.Series["product"].YValueMembers = "totaal";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("10 minder verkochte producten");
                        break;
                    case 3:
                        var products1or = ctx.OrderDetails.Where(od => od.order.OrderDatum >= date1 && od.order.OrderDatum <= date2).GroupBy(od => od.product).Select(od => new { product = od.Key.ProductNaam + " [" + od.Key.ProductNummer + "]", totaal = od.Count() }).OrderBy(od => od.totaal).ToList();
                        crtTopverkocht.DataSource = products1or.Take(10);
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("product");
                        crtTopverkocht.Series["product"].XValueMember = "product";
                        crtTopverkocht.Series["product"].YValueMembers = "totaal";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("10 minder bestelde producten");
                        break;
                    case 4:
                        var klants = ctx.Klanten.Join(ctx.Orders.Where(od => od.OrderDatum >= date1 && od.OrderDatum <= date2).Join(ctx.OrderDetails, o => o.OrderId, od => od.order.OrderId, (o, od) => new { o.OrderId, o.klant.KlantId, totaal = od.Aantal * od.product.UnitPrice }), k => k.KlantId, ood => ood.KlantId, (k, ood) => new { klant = k.Voornaam + " " + k.achternaam, totaal = ood.totaal }).OrderByDescending(kood => kood.totaal).GroupBy(kood => kood.klant).Select(kood => new { klant = kood.Key, totaal = kood.Sum(koods => koods.totaal) }).ToList();
                        crtTopverkocht.DataSource = klants.Take(10);
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("klant");
                        crtTopverkocht.Series["klant"].XValueMember = "klant";
                        crtTopverkocht.Series["klant"].YValueMembers = "totaal";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("10 best kopers (bedrag)");
                        break;
                    case 5:
                        var klantsor = ctx.Orders.Where(od => od.OrderDatum >= date1 && od.OrderDatum <= date2).GroupBy(o => o.klant).Select(o => new { klantor = o.Key.Voornaam + " " + o.Key.achternaam, totaal = o.Count() }).OrderByDescending(o => o.totaal).ToList();
                        crtTopverkocht.DataSource = klantsor.Take(10);
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("klantor");
                        crtTopverkocht.Series["klantor"].XValueMember = "klantor";
                        crtTopverkocht.Series["klantor"].YValueMembers = "totaal";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("10 best kopers (bestellingen))");
                        break;
                    case 6:
                        var klants1 = ctx.Users.Join(ctx.Orders.Where(od => od.OrderDatum >= date1 && od.OrderDatum <= date2).Join(ctx.OrderDetails, o => o.OrderId, od => od.order.OrderId, (o, od) => new { o.OrderId, o.user.UserId, totaal = od.Aantal * od.product.UnitPrice }), k => k.UserId, ood => ood.UserId, (k, ood) => new { verkoper = k.Voornaam + " " + k.Achternaam, totaal = ood.totaal }).OrderByDescending(kood => kood.totaal).GroupBy(kood => kood.verkoper).Select(kood => new { verkoper = kood.Key, totaal = kood.Sum(koods => koods.totaal) }).ToList();
                        crtTopverkocht.DataSource = klants1.Take(10);
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("Verkoper");
                        crtTopverkocht.Series["Verkoper"].XValueMember = "Verkoper";
                        crtTopverkocht.Series["Verkoper"].YValueMembers = "totaal";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("10 best verkopers (bedrag)");
                        break;
                    case 7:
                        var klants1or = ctx.Orders.Where(od => od.OrderDatum >= date1 && od.OrderDatum <= date2).GroupBy(o => o.user).Select(o => new { Verkoper = o.Key.Voornaam + " " + o.Key.Achternaam, totaal = o.Count() }).OrderByDescending(o => o.totaal).ToList();
                        crtTopverkocht.DataSource = klants1or.Take(10);
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("Verkoper");
                        crtTopverkocht.Series["Verkoper"].XValueMember = "Verkoper";
                        crtTopverkocht.Series["Verkoper"].YValueMembers = "totaal";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("10 best verkopers (bestellingen)");
                        break;
                    case 8:
                        var bezorgers = ctx.Bezorgers.Join(ctx.Orders.Where(od => od.OrderDatum >= date1 && od.OrderDatum <= date2), b => b.BezorgerId, o => o.BezorgdDoor.BezorgerId, (b, o) => new { b, o }).Where(bo => bo.o.status == OrderStatus.Verzonden).GroupBy(bo => bo.b).Select(bo => new { bezorger = bo.Key.Naam, totaal = bo.Count() }).ToList();
                        crtTopverkocht.DataSource = bezorgers;
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("bezorger");
                        crtTopverkocht.Series["bezorger"].XValueMember = "bezorger";
                        crtTopverkocht.Series["bezorger"].YValueMembers = "totaal";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("bezoged bestellingen ");
                        break;
                    case 9:
                        var incomes = ctx.OrderDetails.Where(od => od.order.OrderDatum >= date1 && od.order.OrderDatum <= date2).GroupBy(bo => bo.order.OrderDatum.Day).Select(bo => new { date = bo.Key, incomes = bo.Select(b => b.Aantal * b.product.UnitPrice).Sum() }).ToList();
                        crtTopverkocht.DataSource = incomes;
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("incomes");
                        crtTopverkocht.Series["incomes"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        crtTopverkocht.Series["incomes"].XValueMember = "date";
                        crtTopverkocht.Series["incomes"].YValueMembers = "incomes";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("incomes ");
                        break;
                    case 10:
                        var orders = ctx.Orders.Where(od => od.OrderDatum >= date1 && od.OrderDatum <= date2).GroupBy(bo => bo.OrderDatum.Day).Select(bo => new { date = bo.Key, orders = bo.Count() }).ToList();
                        crtTopverkocht.DataSource = orders;
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("orders");
                        crtTopverkocht.Series["orders"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        crtTopverkocht.Series["orders"].XValueMember = "date";
                        crtTopverkocht.Series["orders"].YValueMembers = "orders";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("orders ");
                        break;
                    case 11:
                        var klanten = ctx.Klanten.Where(od => od.IngevoegdDatum >= date1 && od.IngevoegdDatum <= date2).GroupBy(bo => bo.IngevoegdDatum.Day).Select(bo => new { date = bo.Key, klanten = bo.Count() }).ToList();
                        crtTopverkocht.DataSource = klanten;
                        crtTopverkocht.Series.Clear();
                        crtTopverkocht.Series.Add("klanten");
                        crtTopverkocht.Series["klanten"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        crtTopverkocht.Series["klanten"].XValueMember = "date";
                        crtTopverkocht.Series["klanten"].YValueMembers = "klanten";
                        crtTopverkocht.Titles.Clear();
                        crtTopverkocht.Titles.Add("klanten ");
                        break;
                }

            }
        }

        private void Overzicht_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
