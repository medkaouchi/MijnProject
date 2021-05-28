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
        }

        private void cmbOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOverzicht.SelectedIndex<2)
            {
                using (var ctx=new ProjectContext())
                {
                    var products = ctx.OrderDetails.GroupBy(od => od.product).OrderByDescending(od => od.Sum(ods => ods.Aantal)).Select(od => new { product = od.Key.ProductNaam+" ["+od.Key.ProductNummer+"]", totaal = od.Sum(ods => ods.Aantal) }).ToList();
                    crtTopverkocht.DataSource = products;
                    crtTopverkocht.Series["product"].XValueMember = "product";
                    crtTopverkocht.Series["product"].YValueMembers = "totaal";
                    crtTopverkocht.Titles.Add("10 best verkochte producten");
                }
            }
        }
    }
}
