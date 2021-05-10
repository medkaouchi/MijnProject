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
    public partial class Databeheer : Form
    {
        public Databeheer()
        {
            InitializeComponent();
            
        }
        public static List<User> Users = new List<User>();
        public static DataGridView dgv_users = dgv_users;
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUsers.Visible = true;
            using (var ctx=new ProjectContext())
            {
                Users = ctx.Users.ToList();
            }
            dgvUsers.DataSource = Users;


            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.Name = "Bewerken";
            EditButtonColumn.Text = "Bewerk";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Verwijderen";
            DeleteButtonColumn.Text = "Verwijder";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvUsers.Columns.Insert(dgvUsers.Columns.Count,EditButtonColumn);
            dgvUsers.Columns.Insert(dgvUsers.Columns.Count, DeleteButtonColumn);
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > 9)
                if (e.ColumnIndex == 10)
                {
                    
                }
                else
                {

                }
        }

        private void llblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
        }
    }
}
