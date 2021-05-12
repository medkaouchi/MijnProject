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
        public static DataGridView dgv_users ;
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUsers.Visible = true;
            using (var ctx=new ProjectContext())
            {
                Users = ctx.Users.ToList();
            }
            loaddgvusers();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > 9)
                if (e.ColumnIndex == 11)
                {
                    using(var ctx=new ProjectContext())
                    {
                        User usr = (User)dgvUsers.Rows[e.RowIndex].DataBoundItem;
                        ctx.Users.RemoveRange(ctx.Users.Where(g => g.UserId == usr.UserId));
                        ctx.SaveChanges();
                        Users = ctx.Users.ToList();
                    }
                }
                else
                {
                    if (dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "Bewerk")
                    {
                        ((DataGridViewButtonColumn)dgvUsers.Columns["Bewerken"]).UseColumnTextForButtonValue = false;
                        dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Opslaan";

                    }
                    else
                    {
                        using (var ctx = new ProjectContext())
                        {
                            User usr = (User)dgvUsers.Rows[e.RowIndex].DataBoundItem;
                            ctx.Users.RemoveRange(ctx.Users.Where(g => g.UserId == usr.UserId));
                            ctx.SaveChanges();
                            Users = ctx.Users.ToList();
                        }
                        dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Bewerk";
                    }
                    
                }
            loaddgvusers();
            
        }

        private void llblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
        }

        private void Databeheer_Load(object sender, EventArgs e)
        {

            dgv_users = dgvUsers;
        }
        public static void loaddgvusers()
        {
            dgv_users.DataSource = null;
            dgv_users.Columns.Clear();
            dgv_users.DataSource = Users;
            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.Name = "Bewerken";
            EditButtonColumn.Text = "Bewerk";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Verwijderen";
            DeleteButtonColumn.Text = "Verwijder";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            dgv_users.Columns.Insert(dgv_users.Columns.Count, EditButtonColumn);
            dgv_users.Columns.Insert(dgv_users.Columns.Count, DeleteButtonColumn);
        }
    }
}
