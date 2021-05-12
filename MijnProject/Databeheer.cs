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
            if(Login.user.Role==RoleUser.Admin)
            {
                userToolStripMenuItem.Enabled = true;
                productToolStripMenuItem.Enabled = true;
                klantToolStripMenuItem.Enabled = true;
                orderToolStripMenuItem.Enabled = true;
            }
            if (Login.user.Role == RoleUser.Magazijnier)
            {
                userToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.Enabled = true;
                klantToolStripMenuItem.Enabled = false;
                orderToolStripMenuItem.Enabled = false;
            }
            if (Login.user.Role == RoleUser.Verkoper)
            {
                userToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.Enabled = false;
                klantToolStripMenuItem.Enabled = true;
                orderToolStripMenuItem.Enabled = true;
            }
        }
        public static List<User> Users = new List<User>();
        public static DataGridView dgv_users ;
        public static User user = new User();
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUsers.Visible = true;
            using (var ctx=new ProjectContext())
                Users = ctx.Users.Include("Adress").ToList();
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
                        Users = ctx.Users.Include("Adress").ToList();
                    }
                }
                else
                {
                    user = dgvUsers.Rows[e.RowIndex].DataBoundItem as User;
                    EditUser edituser = new EditUser();
                    edituser.ShowDialog();
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
            for (int i = 0; i < dgv_users.Rows.Count; i++)
            {
                dgv_users.Rows[i].Cells["Wachtwoord"].Value = dgv_users.Rows[i].Cells["Wachtwoord"].Value.ToString().Aggregate("", (c, a) => c + (char)(a - 2));
            }
        }
    }
}
