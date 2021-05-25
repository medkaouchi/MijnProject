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
    public partial class EditAantal : Form
    {
        public static string parent;
        public EditAantal()
        {
            InitializeComponent();
            nudAantal.Maximum = Decimal.MaxValue;
            nudAantal.Value = AddOrder.aantal;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if(parent == "Add")
            {
                ((ProductOrdered)AddOrder.dgv_OrderProducten.Rows[AddOrder.rowindex].DataBoundItem).aantal =Convert.ToInt32( nudAantal.Value);
                AddOrder.dgv_OrderProducten.Refresh();
                AddOrder.dgv_OrderProducten = null;
            }
            if (parent == "Edit")
            {
                ((ProductOrdered)EditOrder.dgv_OrderProducten.Rows[EditOrder.rowindex].DataBoundItem).aantal = Convert.ToInt32(nudAantal.Value);
                EditOrder.dgv_OrderProducten.Refresh();
                EditOrder.dgv_OrderProducten = null;
            }
        }
    }
}
