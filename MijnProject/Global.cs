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
        public static void ModifyForm(Form form)
        {
            form.BackColor = System.Drawing.Color.White;
            form.ForeColor = System.Drawing.Color.DarkBlue;
            form.Font =Login.DefaultFont;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = new Point(0, 0);
            form.Size = Screen.PrimaryScreen.WorkingArea.Size;
            form.WindowState = FormWindowState.Maximized;
        }
        
    }
}
