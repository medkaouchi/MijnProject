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
            Global.ModifyForm(this);
            lblUser.Text = Program.user.Voornaam + " " + Program.user.Achternaam;
            if (Login.user.Role != RoleUser.Admin)
            {
                if(Login.user.Role != RoleUser.Verkoper)
                { 
                    btnBestelling.Enabled = false;
                    btnOverzicht.Enabled = false;
                }
                else
                    btnOverzicht.Enabled = false;

            }
        }

        private void llblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.user = null;
            this.Hide();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnDatabeheer_Click(object sender, EventArgs e)
        {
            Databeheer databeheer = new Databeheer();
            databeheer.Show();
            this.Close();
        }

        private void btnBestelling_Click(object sender, EventArgs e)
        {
            Bestellingen bestellingen = new Bestellingen();
            bestellingen.Show();
            this.Close();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            Overzicht overzicht = new Overzicht();
            overzicht.Show();
            this.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
