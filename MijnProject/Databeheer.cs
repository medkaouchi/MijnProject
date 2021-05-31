using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            Main.ActiveForm.Close();
            if(Login.user.Role==RoleUser.Admin)
            {
                userToolStripMenuItem.Enabled = true;
                productToolStripMenuItem.Enabled = true;
                klantToolStripMenuItem.Enabled = true;
                bezorgersToolStripMenuItem.Enabled = true;
            }
            if (Login.user.Role == RoleUser.Magazijnier)
            {
                userToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.Enabled = true;
                klantToolStripMenuItem.Enabled = false;
                bezorgersToolStripMenuItem.Enabled = false;
            }
            if (Login.user.Role == RoleUser.Verkoper)
            {
                userToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.Enabled = false;
                klantToolStripMenuItem.Enabled = true;
                bezorgersToolStripMenuItem.Enabled = false;
            }
        }
        public static List<User> Users = new List<User>();
        public static List<Klant> Klanten = new List<Klant>();
        public static List<Product> Producten = new List<Product>();
        public static DataGridView dgv_users ;
        public static DataGridView dgv_klanten;
        public static DataGridView dgv_producten;
        public static User user = new User();
        public static Klant klant = new Klant();
        public static Product product = new Product();
        public static int deleteindex;
        public static int editindex;
        public static int deleteindexproduct;
        public static int editindexproduct;
        public static List<Bezorger> Deliverers = new List<Bezorger>();
        public static DataGridView dgv_Deliverer = new DataGridView();
        public static int deleteindexBez;
        public static int editindexBez;
        public static Bezorger bezorger;

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > 9)
                if (e.ColumnIndex == 11)
                {
                    using(var ctx=new ProjectContext())
                    {
                        User usr = (User)dgvUsers.Rows[e.RowIndex].DataBoundItem;
                        ctx.Users.RemoveRange(ctx.Users.Where(g => g.UserId == usr.UserId));
                        try
                        {
                            ctx.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException)
                        {
                            MessageBox.Show("User kan niet worden verwijderd !");
                        }
                        
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
            dgv_klanten = dgvKlanten;
            dgv_users = dgvUsers;
            dgv_producten = dgvProducten;
            dgv_Deliverer = dgvDeliverer;
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
        public static void loaddgvklants()
        {
            dgv_klanten.DataSource = null;
            dgv_klanten.Columns.Clear();
            dgv_klanten.DataSource = Klanten;
            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.Name = "Bewerken";
            EditButtonColumn.Text = "Bewerk";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Verwijderen";
            DeleteButtonColumn.Text = "Verwijder";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            dgv_klanten.Columns.Insert(dgv_klanten.Columns.Count, EditButtonColumn);
            dgv_klanten.Columns.Insert(dgv_klanten.Columns.Count, DeleteButtonColumn);
            dgv_klanten.Columns["Verwijderen"].DisplayIndex = 14;
            dgv_klanten.Columns["Bewerken"].DisplayIndex = 13;
            deleteindex = dgv_klanten.Columns["Verwijderen"].Index;
            editindex = dgv_klanten.Columns["Bewerken"].Index;
        }
        public static void loaddgvprodut()
        {
            dgv_producten.DataSource = null;
            dgv_producten.Columns.Clear();
            dgv_producten.DataSource = Producten;
            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.Name = "Bewerken";
            EditButtonColumn.Text = "Bewerk";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Verwijderen";
            DeleteButtonColumn.Text = "Verwijder";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            dgv_producten.Columns.Insert(dgv_producten.Columns.Count, EditButtonColumn);
            dgv_producten.Columns.Insert(dgv_producten.Columns.Count, DeleteButtonColumn);
            dgv_producten.Columns["Verwijderen"].DisplayIndex = 13;
            dgv_producten.Columns["Bewerken"].DisplayIndex = 12;
            deleteindexproduct = dgv_producten.Columns["Verwijderen"].Index;
            editindexproduct = dgv_producten.Columns["Bewerken"].Index;
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlKlanten.Visible = false;
            pnlKlanten.Visible = false;
            pnlUsers.Visible = true;
            pnlBezorgers.Visible = false;
            using (var ctx = new ProjectContext())
                Users = ctx.Users.Include("Adress").ToList();
            loaddgvusers();
        }

        private void klantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlKlanten.Visible = false;
            pnlUsers.Visible = false;
            pnlKlanten.Visible = true;
            pnlBezorgers.Visible = false;
            using (var ctx = new ProjectContext())
                Klanten = ctx.Klanten.Include("Adress").Include("IngevoegdDoor").ToList();
            loaddgvklants();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUsers.Visible = false;
            pnlKlanten.Visible = false;
            pnlProducten.Visible = true;
            pnlBezorgers.Visible = false;
            using (var ctx = new ProjectContext())
                Producten = ctx.Products.Include("levrancier").ToList();
            loaddgvprodut();
        }

        private void dgvKlanten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 )
                if (e.ColumnIndex == deleteindex)
                {
                    using (var ctx = new ProjectContext())
                    {
                        Klant klnt = (Klant)dgvKlanten.Rows[e.RowIndex].DataBoundItem;
                        ctx.Klanten.RemoveRange(ctx.Klanten.Where(g => g.KlantId == klnt.KlantId));
                        try
                        {
                            ctx.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException)
                        {
                            MessageBox.Show("Klant kan niet worden verwijderd !");
                        }
                        Klanten = ctx.Klanten.Include("Adress").Include("IngevoegdDoor").ToList();
                    }
                }
                else if(e.ColumnIndex == editindex)
                {
                    klant = dgvKlanten.Rows[e.RowIndex].DataBoundItem as Klant;
                    EditKlant editklant = new EditKlant();
                    editklant.ShowDialog();
                }
            loaddgvklants();
        }

        private void llblNewKlant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddKlant addklant = new AddKlant();
            addklant.ShowDialog();
        }

        private void dgvProducten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                if (e.ColumnIndex == deleteindexproduct)
                {
                    using (var ctx = new ProjectContext())
                    {
                        Product prd = (Product)dgvProducten.Rows[e.RowIndex].DataBoundItem;
                        ctx.Products.RemoveRange(ctx.Products.Where(g => g.ProductId == prd.ProductId));
                        try
                        {
                            ctx.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException)
                        {
                            MessageBox.Show("Product kan niet worden verwijderd !");
                        }
                        Producten = ctx.Products.Include("levrancier").ToList();
                    }
                }
                else if(e.ColumnIndex==editindexproduct)
                {
                    product = dgvProducten.Rows[e.RowIndex].DataBoundItem as Product;
                    EditProduct editproduct = new EditProduct();
                    editproduct.ShowDialog();
                }
            loaddgvprodut();
        }
       
        private void btnupload_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Text files | *.txt"; 
            dialog.Multiselect = false; 
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
               string FileLocation = dialog.FileName; 
                Microsoft.Office.Interop.Word.Application App = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document Doc = App.Documents.Open( FileLocation);
                Microsoft.Office.Interop.Word.Table tab1 = Doc.Content.Tables[1];
                Microsoft.Office.Interop.Word.Table tab2 = Doc.Content.Tables[2];
                Microsoft.Office.Interop.Word.Table tab3 = Doc.Content.Tables[3];
                Levrancier lev = new Levrancier();
                Adress ad = new Adress();
                lev.Naam=tab1.Cell(2,1).Range.Text.Substring(0, tab1.Cell(2, 1).Range.Text.Length - 2);
                lev.Omschrijving = tab1.Cell(2, 2).Range.Text.Substring(0, tab1.Cell(2, 2).Range.Text.Length - 2);
                lev.Telefoon1 = tab1.Cell(2, 3).Range.Text.Substring(0, tab1.Cell(2, 3).Range.Text.Length - 2);
                lev.Telefoon2 = tab1.Cell(2, 4).Range.Text.Substring(0, tab1.Cell(2, 4).Range.Text.Length - 2);
                lev.Email = tab1.Cell(2, 5).Range.Text.Substring(0, tab1.Cell(2, 5).Range.Text.Length - 2);
                ad.Straat =tab2.Cell(2, 1).Range.Text.Substring(0, tab2.Cell(2, 1).Range.Text.Length - 2);
                ad.Huisnummer =Convert.ToInt32( tab2.Cell(2, 2).Range.Text.Substring(0, tab2.Cell(2, 2).Range.Text.Length - 2));
                ad.Gemeente = tab2.Cell(2, 3).Range.Text.Substring(0, tab2.Cell(2, 3).Range.Text.Length - 2);
                ad.Postcode = tab2.Cell(2, 4).Range.Text.Substring(0, tab2.Cell(2, 4).Range.Text.Length - 2);
                ad.Land = tab2.Cell(2, 5).Range.Text.Substring(0, tab2.Cell(2, 5).Range.Text.Length - 2);
                lev.adress = ad;
                using (var ctx=new ProjectContext())
                {
                    
                }
                for(int i=2;i<=tab3.Rows.Count;i++)
                {
                    pr.ProductNaam=tab3.Cell(i,1).Range.Text.Substring(0, tab3.Cell(i, 1).Range.Text.Length - 2);
                    pr.UnitPrice =Convert.ToDouble( tab3.Cell(i, 3).Range.Text.Substring(0, tab3.Cell(i, 3).Range.Text.Length - 2));
                    pr.UnitsOnStock =Convert.ToInt32( tab3.Cell(i, 2).Range.Text.Substring(0, tab3.Cell(i, 2).Range.Text.Length - 2));
                    pr.ProductNummer = tab3.Cell(i, 4).Range.Text.Substring(0, tab3.Cell(i, 4).Range.Text.Length - 2);
                    pr.BarCode = tab3.Cell(i, 5).Range.Text.Substring(0, tab3.Cell(i, 5).Range.Text.Length - 2);
                    pr.Gewicht = Convert.ToDouble(tab3.Cell(i, 6).Range.Text.Substring(0, tab3.Cell(i, 6).Range.Text.Length - 2));
                    pr.Breedte = Convert.ToDouble(tab3.Cell(i, 7).Range.Text.Substring(0, tab3.Cell(i, 7).Range.Text.Length - 2));
                    pr.Lengte = Convert.ToDouble(tab3.Cell(i, 8).Range.Text.Substring(0, tab3.Cell(i, 8).Range.Text.Length - 2));
                    pr.Hoogte = Convert.ToDouble(tab3.Cell(i, 9).Range.Text.Substring(0, tab3.Cell(i, 9).Range.Text.Length - 2));
                    pr.Omschrijving = tab3.Cell(i, 10).Range.Text.Substring(0, tab3.Cell(i, 10).Range.Text.Length - 2);
                    using (var ctx = new ProjectContext())
                    {
                        Product P = ctx.Products.FirstOrDefault(p => p.ProductNummer == pr.ProductNummer);
                        if (P== null)
                        {
                            ctx.Products.Add(pr);
                            ctx.SaveChanges();
                            if (ctx.Levranciers.FirstOrDefault(l => l.Naam == lev.Naam) == null)
                                ctx.Products.FirstOrDefault(p=>p.ProductNummer==pr.ProductNummer).levrancier=lev;
                            else
                                pr.levrancier = ctx.Levranciers.FirstOrDefault(l => l.Naam == lev.Naam);
                            ctx.SaveChanges();
                        }
                        else
                            ctx.Products.FirstOrDefault(p => p.ProductNummer == pr.ProductNummer).UnitsOnStock =P.UnitsOnStock+ pr.UnitsOnStock;
                        ctx.SaveChanges();
                        Producten = ctx.Products.Include("levrancier").ToList();
                    }
                    loaddgvprodut();
                }
            }
        }

        private void llblNewProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddProduct addproduct = new AddProduct();
            addproduct.ShowDialog();
        }

        private void Databeheer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void bezorgersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlBezorgers.Visible =true;
            pnlUsers.Visible = false;
            pnlKlanten.Visible = false;
            pnlProducten.Visible = false;
            using (var ctx = new ProjectContext())
            {
                Deliverers = ctx.Bezorgers.Include("adress").ToList();
            }
            loaddgvDeliverer();
        }
        public static void loaddgvDeliverer()
        {
            dgv_Deliverer.DataSource = null;
            dgv_Deliverer.Columns.Clear();
            dgv_Deliverer.DataSource = Deliverers;
            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Verwijderen";
            DeleteButtonColumn.Text = "Verwijder";
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            dgv_Deliverer.Columns.Insert(dgv_Deliverer.Columns.Count, DeleteButtonColumn);
            dgv_Deliverer.Columns["Verwijderen"].DisplayIndex = 7;
            deleteindexBez = dgv_Deliverer.Columns["Verwijderen"].Index;
        }

        private void dgvDeliverer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.ColumnIndex == deleteindex && e.RowIndex > -1)
                {
                    using (var ctx = new ProjectContext())
                    {
                        Bezorger prd = (Bezorger)dgvDeliverer.Rows[e.RowIndex].DataBoundItem;
                        ctx.Bezorgers.RemoveRange(ctx.Bezorgers.Where(g => g.BezorgerId == prd.BezorgerId));
                        try
                        {
                            ctx.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException)
                        {
                            MessageBox.Show("Bezorger kan niet worden verwijderd !");
                        }
                        Deliverers = ctx.Bezorgers.Include("adress").ToList();
                    }
                }
                
            loaddgvDeliverer();
        }

        private void llblNewDeliverer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddBezorger addbezorgzer = new AddBezorger();
            addbezorgzer.Show();
        }
    }
}
