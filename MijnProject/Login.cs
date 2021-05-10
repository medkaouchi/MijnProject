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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            User user=new User();
            if(txtUsername.Text!="" && txtWachtwoord.Text!="")
            using (var ctx=new ProjectContext())
            {
                    user = ctx.Users.FirstOrDefault(u => u.Username == txtUsername.Text && u.Wachtwoord == txtWachtwoord.Text);
            }
            if(user!=null)
            {
                Program.user = user;
                Main main = new Main();
                main.Show();
                this.Close();
            }

        }
    }
}
