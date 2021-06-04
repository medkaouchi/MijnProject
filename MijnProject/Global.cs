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
            foreach (var item in form.Controls)
            {
                ((Control)item).BackColor = Color.White;
                if(((Control)item).Name.StartsWith("p"))
                    foreach (var it in ((Control)item).Controls)
                    {
                        ((Control)it).BackColor = Color.White;
                    }
            }
            //if(form.Name!="Overzicht")
            //{ 
            //    form.BackgroundImage = Properties.Resources.ebd258_seo_optimized_ecommerce;
            //    form.BackgroundImageLayout = ImageLayout.Stretch;
            //}
        }
        
    }
}
