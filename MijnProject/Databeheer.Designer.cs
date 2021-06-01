
namespace MijnProject
{
    partial class Databeheer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezorgersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.llblNewUser = new System.Windows.Forms.LinkLabel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlBezorgers = new System.Windows.Forms.Panel();
            this.llblNewDeliverer = new System.Windows.Forms.LinkLabel();
            this.dgvDeliverer = new System.Windows.Forms.DataGridView();
            this.pnlProducten = new System.Windows.Forms.Panel();
            this.llblNewProduct = new System.Windows.Forms.LinkLabel();
            this.btnupload = new System.Windows.Forms.Button();
            this.dgvProducten = new System.Windows.Forms.DataGridView();
            this.pnlKlanten = new System.Windows.Forms.Panel();
            this.llblNewKlant = new System.Windows.Forms.LinkLabel();
            this.dgvKlanten = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlBezorgers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverer)).BeginInit();
            this.pnlProducten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducten)).BeginInit();
            this.pnlKlanten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlanten)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.klantToolStripMenuItem,
            this.productToolStripMenuItem,
            this.bezorgersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Enabled = false;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.userToolStripMenuItem.Text = "Users";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // klantToolStripMenuItem
            // 
            this.klantToolStripMenuItem.Enabled = false;
            this.klantToolStripMenuItem.Name = "klantToolStripMenuItem";
            this.klantToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.klantToolStripMenuItem.Text = "Klanten";
            this.klantToolStripMenuItem.Click += new System.EventHandler(this.klantToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Enabled = false;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.productToolStripMenuItem.Text = "Producten";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // bezorgersToolStripMenuItem
            // 
            this.bezorgersToolStripMenuItem.Name = "bezorgersToolStripMenuItem";
            this.bezorgersToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.bezorgersToolStripMenuItem.Text = "Bezorgers";
            this.bezorgersToolStripMenuItem.Click += new System.EventHandler(this.bezorgersToolStripMenuItem_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.llblNewUser);
            this.pnlUsers.Controls.Add(this.dgvUsers);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsers.Location = new System.Drawing.Point(0, 30);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(1289, 632);
            this.pnlUsers.TabIndex = 1;
            this.pnlUsers.Visible = false;
            // 
            // llblNewUser
            // 
            this.llblNewUser.AutoSize = true;
            this.llblNewUser.Location = new System.Drawing.Point(3, 7);
            this.llblNewUser.Name = "llblNewUser";
            this.llblNewUser.Size = new System.Drawing.Size(151, 17);
            this.llblNewUser.TabIndex = 1;
            this.llblNewUser.TabStop = true;
            this.llblNewUser.Text = "Nieuw User toevoegen";
            this.llblNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNewUser_LinkClicked);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUsers.Location = new System.Drawing.Point(3, 27);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1283, 493);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1147, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 115;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlBezorgers
            // 
            this.pnlBezorgers.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBezorgers.Controls.Add(this.llblNewDeliverer);
            this.pnlBezorgers.Controls.Add(this.dgvDeliverer);
            this.pnlBezorgers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBezorgers.Location = new System.Drawing.Point(0, 30);
            this.pnlBezorgers.Name = "pnlBezorgers";
            this.pnlBezorgers.Size = new System.Drawing.Size(1289, 632);
            this.pnlBezorgers.TabIndex = 118;
            this.pnlBezorgers.Visible = false;
            // 
            // llblNewDeliverer
            // 
            this.llblNewDeliverer.AutoSize = true;
            this.llblNewDeliverer.Location = new System.Drawing.Point(0, 5);
            this.llblNewDeliverer.Name = "llblNewDeliverer";
            this.llblNewDeliverer.Size = new System.Drawing.Size(178, 17);
            this.llblNewDeliverer.TabIndex = 7;
            this.llblNewDeliverer.TabStop = true;
            this.llblNewDeliverer.Text = "Nieuw bezorger toevoegen";
            // 
            // dgvDeliverer
            // 
            this.dgvDeliverer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliverer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDeliverer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliverer.Location = new System.Drawing.Point(3, 25);
            this.dgvDeliverer.Name = "dgvDeliverer";
            this.dgvDeliverer.RowHeadersWidth = 51;
            this.dgvDeliverer.RowTemplate.Height = 24;
            this.dgvDeliverer.Size = new System.Drawing.Size(929, 532);
            this.dgvDeliverer.TabIndex = 6;
            // 
            // pnlProducten
            // 
            this.pnlProducten.Controls.Add(this.llblNewProduct);
            this.pnlProducten.Controls.Add(this.btnupload);
            this.pnlProducten.Controls.Add(this.dgvProducten);
            this.pnlProducten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducten.Location = new System.Drawing.Point(0, 30);
            this.pnlProducten.Name = "pnlProducten";
            this.pnlProducten.Size = new System.Drawing.Size(1289, 632);
            this.pnlProducten.TabIndex = 119;
            this.pnlProducten.Visible = false;
            // 
            // llblNewProduct
            // 
            this.llblNewProduct.AutoSize = true;
            this.llblNewProduct.Location = new System.Drawing.Point(12, 9);
            this.llblNewProduct.Name = "llblNewProduct";
            this.llblNewProduct.Size = new System.Drawing.Size(170, 17);
            this.llblNewProduct.TabIndex = 117;
            this.llblNewProduct.TabStop = true;
            this.llblNewProduct.Text = "Nieuw Product toevoegen";
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(1017, 4);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(260, 23);
            this.btnupload.TabIndex = 4;
            this.btnupload.Text = "Leverancier bestand toevoegen ";
            this.btnupload.UseVisualStyleBackColor = true;
            // 
            // dgvProducten
            // 
            this.dgvProducten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducten.Location = new System.Drawing.Point(0, 32);
            this.dgvProducten.Name = "dgvProducten";
            this.dgvProducten.RowHeadersWidth = 51;
            this.dgvProducten.RowTemplate.Height = 24;
            this.dgvProducten.Size = new System.Drawing.Size(1289, 530);
            this.dgvProducten.TabIndex = 0;
            // 
            // pnlKlanten
            // 
            this.pnlKlanten.Controls.Add(this.llblNewKlant);
            this.pnlKlanten.Controls.Add(this.dgvKlanten);
            this.pnlKlanten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKlanten.Location = new System.Drawing.Point(0, 30);
            this.pnlKlanten.Name = "pnlKlanten";
            this.pnlKlanten.Size = new System.Drawing.Size(1289, 632);
            this.pnlKlanten.TabIndex = 120;
            this.pnlKlanten.Visible = false;
            // 
            // llblNewKlant
            // 
            this.llblNewKlant.AutoSize = true;
            this.llblNewKlant.Location = new System.Drawing.Point(4, 17);
            this.llblNewKlant.Name = "llblNewKlant";
            this.llblNewKlant.Size = new System.Drawing.Size(151, 17);
            this.llblNewKlant.TabIndex = 1;
            this.llblNewKlant.TabStop = true;
            this.llblNewKlant.Text = "Nieuw klant toevoegen";
            // 
            // dgvKlanten
            // 
            this.dgvKlanten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKlanten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKlanten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlanten.Location = new System.Drawing.Point(0, 37);
            this.dgvKlanten.Name = "dgvKlanten";
            this.dgvKlanten.RowHeadersWidth = 51;
            this.dgvKlanten.RowTemplate.Height = 24;
            this.dgvKlanten.Size = new System.Drawing.Size(1289, 531);
            this.dgvKlanten.TabIndex = 0;
            // 
            // Databeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 662);
            this.Controls.Add(this.pnlBezorgers);
            this.Controls.Add(this.pnlKlanten);
            this.Controls.Add(this.pnlProducten);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Databeheer";
            this.Text = "Databeheer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Databeheer_FormClosed);
            this.Load += new System.EventHandler(this.Databeheer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlBezorgers.ResumeLayout(false);
            this.pnlBezorgers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverer)).EndInit();
            this.pnlProducten.ResumeLayout(false);
            this.pnlProducten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducten)).EndInit();
            this.pnlKlanten.ResumeLayout(false);
            this.pnlKlanten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlanten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.LinkLabel llblNewUser;
        private System.Windows.Forms.ToolStripMenuItem bezorgersToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlKlanten;
        private System.Windows.Forms.LinkLabel llblNewKlant;
        private System.Windows.Forms.DataGridView dgvKlanten;
        private System.Windows.Forms.Panel pnlBezorgers;
        private System.Windows.Forms.LinkLabel llblNewDeliverer;
        private System.Windows.Forms.DataGridView dgvDeliverer;
        private System.Windows.Forms.Panel pnlProducten;
        private System.Windows.Forms.LinkLabel llblNewProduct;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.DataGridView dgvProducten;
    }
}