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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            lblUser.Text = Program.user.Voornaam + " " + Program.user.Achternaam;
        }

        private void llblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.user = null;
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
