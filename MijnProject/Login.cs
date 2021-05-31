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
        public static User user=new User();
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (var ctx=new ProjectContext())
            {
                string t = null;
                if (ctx.Users.FirstOrDefault(u => u.Username == txtUsername.Text)!=null)
                t = ctx.Users.FirstOrDefault(u => u.Username == txtUsername.Text).Wachtwoord.Aggregate("", (c, a) => c + (char)(a - 2));
                else
                {
                    MessageBox.Show("Username of Wachtwoord bestaat niet!");
                    txtUsername.Text = "";
                    txtWachtwoord.Text = "";
                }
                user = ctx.Users.FirstOrDefault(u => u.Username == txtUsername.Text && t == txtWachtwoord.Text);
            }
            if(user!=null)
            {
                txtUsername.Text = "";
                txtWachtwoord.Text = "";
                Program.user = user;
                Main main = new Main();
                main.Show();
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
