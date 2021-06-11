using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijnProject
{
    public static class Global
    {
        public static List<Adress> Adresses = new List<Adress>();
        public static void ModifyForm(Form form)
        {
            form.BackColor = System.Drawing.Color.White;
            form.ForeColor = System.Drawing.Color.DarkBlue;
            form.Font = Login.DefaultFont;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = new Point(0, 0);
            form.Size = Screen.PrimaryScreen.WorkingArea.Size;
            form.WindowState = FormWindowState.Maximized;
            foreach (var item in form.Controls)
            {
                ((Control)item).BackColor = Color.White;
                if (((Control)item).Name.StartsWith("p"))
                    foreach (var it in ((Control)item).Controls)
                    {
                        ((Control)it).BackColor = Color.White;
                    }
                if (((Control)item).Name.StartsWith("button"))
                    ((Button)item).Text = "Terug";
                if (form.Name.StartsWith("Add")&&((Control)item).Name.StartsWith("cm"))
                    ((ComboBox)item).SelectedIndex = -1;
            }

        }
        public static void cmbAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Form form = ((ComboBox)sender).FindForm();
            if (e.KeyChar != '\r') return;

            if (form.ActiveControl != null)
            {
                form.SelectNextControl(form.ActiveControl, true, true, true, true);
            }
            e.Handled = true;
        }

        public static void cmbAdress_TextUpdate(object sender, EventArgs e)
        {
            ComboBox cmbAdress = (ComboBox)sender;
            string c = cmbAdress.Text;
            using (var ctx = new ProjectContext())
                Adresses = ctx.Adressen.Where(a => (a.Straat + " " + a.Huisnummer + " " + a.Gemeente + " " + a.Postcode + " " + a.Land).StartsWith(c)).ToList();
            cmbAdress.DataSource = null;
            cmbAdress.DataSource = Adresses;
            cmbAdress.DroppedDown = true;
            Cursor.Current = Cursors.Default;
            cmbAdress.SelectedIndex = -1;
            cmbAdress.Text = c;
            cmbAdress.Select(cmbAdress.Text.Length, 0);

        }
    }
}
