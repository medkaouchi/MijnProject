﻿using System;
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
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        public Login()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
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
                this.Hide();
                Main main = new Main();
                main.Show();
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(user==null)
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
