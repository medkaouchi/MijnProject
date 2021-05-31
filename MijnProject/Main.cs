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
            if (Login.user.Role != RoleUser.Admin)
            {
                btnBestelling.Enabled = false;
                btnOverzicht.Enabled = false;
            }

            Login.ActiveForm.Hide();
        }

        private void llblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.user = null;
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnDatabeheer_Click(object sender, EventArgs e)
        {
            Databeheer databeheer = new Databeheer();
            databeheer.ShowDialog();
        }

        private void btnBestelling_Click(object sender, EventArgs e)
        {
            Bestellingen bestellingen = new Bestellingen();
            bestellingen.ShowDialog();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            Overzicht overzicht = new Overzicht();
            overzicht.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        
    }
}
