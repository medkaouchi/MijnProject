
namespace MijnProject
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.cmbKlanten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.llblAddAdress = new System.Windows.Forms.LinkLabel();
            this.pnlAdress = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttGem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHuisNr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStraat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblKlantAdress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.dgvOrderProducten = new System.Windows.Forms.DataGridView();
            this.txtPrNummer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProducten = new System.Windows.Forms.ComboBox();
            this.llblNewKlant = new System.Windows.Forms.LinkLabel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBezorgers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlAdress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKlanten
            // 
            this.cmbKlanten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKlanten.FormattingEnabled = true;
            this.cmbKlanten.Location = new System.Drawing.Point(219, 25);
            this.cmbKlanten.Name = "cmbKlanten";
            this.cmbKlanten.Size = new System.Drawing.Size(270, 24);
            this.cmbKlanten.TabIndex = 0;
            this.cmbKlanten.SelectedIndexChanged += new System.EventHandler(this.cmbKlanten_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klant:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(351, 620);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(270, 24);
            this.cmbStatus.TabIndex = 4;
            // 
            // llblAddAdress
            // 
            this.llblAddAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblAddAdress.AutoSize = true;
            this.llblAddAdress.Location = new System.Drawing.Point(216, 109);
            this.llblAddAdress.Name = "llblAddAdress";
            this.llblAddAdress.Size = new System.Drawing.Size(93, 17);
            this.llblAddAdress.TabIndex = 89;
            this.llblAddAdress.TabStop = true;
            this.llblAddAdress.Text = "Nieuw adress";
            this.llblAddAdress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAddAdress_LinkClicked);
            // 
            // pnlAdress
            // 
            this.pnlAdress.AllowDrop = true;
            this.pnlAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAdress.Controls.Add(this.btnCancel);
            this.pnlAdress.Controls.Add(this.txtLand);
            this.pnlAdress.Controls.Add(this.label16);
            this.pnlAdress.Controls.Add(this.txtPC);
            this.pnlAdress.Controls.Add(this.label14);
            this.pnlAdress.Controls.Add(this.txttGem);
            this.pnlAdress.Controls.Add(this.label15);
            this.pnlAdress.Controls.Add(this.txtHuisNr);
            this.pnlAdress.Controls.Add(this.label13);
            this.pnlAdress.Controls.Add(this.txtStraat);
            this.pnlAdress.Controls.Add(this.label9);
            this.pnlAdress.Location = new System.Drawing.Point(219, 82);
            this.pnlAdress.Name = "pnlAdress";
            this.pnlAdress.Size = new System.Drawing.Size(270, 122);
            this.pnlAdress.TabIndex = 88;
            this.pnlAdress.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(46, 88);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(115, 22);
            this.txtLand.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "Land:";
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(198, 54);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(53, 22);
            this.txtPC.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "PC:";
            // 
            // txttGem
            // 
            this.txttGem.Location = new System.Drawing.Point(46, 51);
            this.txttGem.Name = "txttGem";
            this.txttGem.Size = new System.Drawing.Size(112, 22);
            this.txttGem.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Gem:";
            // 
            // txtHuisNr
            // 
            this.txtHuisNr.Location = new System.Drawing.Point(204, 13);
            this.txtHuisNr.Name = "txtHuisNr";
            this.txtHuisNr.Size = new System.Drawing.Size(43, 22);
            this.txtHuisNr.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(164, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "hnr:";
            // 
            // txtStraat
            // 
            this.txtStraat.Location = new System.Drawing.Point(37, 13);
            this.txtStraat.Name = "txtStraat";
            this.txtStraat.Size = new System.Drawing.Size(121, 22);
            this.txtStraat.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "str:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(83, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 87;
            this.label17.Text = "Adress:";
            // 
            // lblKlantAdress
            // 
            this.lblKlantAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKlantAdress.AutoSize = true;
            this.lblKlantAdress.Location = new System.Drawing.Point(216, 82);
            this.lblKlantAdress.Name = "lblKlantAdress";
            this.lblKlantAdress.Size = new System.Drawing.Size(84, 17);
            this.lblKlantAdress.TabIndex = 90;
            this.lblKlantAdress.Text = "KlantAdress";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "product barcode:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.Location = new System.Drawing.Point(194, 228);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(195, 22);
            this.txtBarcode.TabIndex = 92;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // dgvOrderProducten
            // 
            this.dgvOrderProducten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderProducten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderProducten.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProducten.Location = new System.Drawing.Point(50, 268);
            this.dgvOrderProducten.Name = "dgvOrderProducten";
            this.dgvOrderProducten.RowHeadersVisible = false;
            this.dgvOrderProducten.RowHeadersWidth = 51;
            this.dgvOrderProducten.RowTemplate.Height = 24;
            this.dgvOrderProducten.Size = new System.Drawing.Size(908, 298);
            this.dgvOrderProducten.TabIndex = 93;
            this.dgvOrderProducten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderProducten_CellClick);
            // 
            // txtPrNummer
            // 
            this.txtPrNummer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrNummer.Location = new System.Drawing.Point(523, 228);
            this.txtPrNummer.Name = "txtPrNummer";
            this.txtPrNummer.Size = new System.Drawing.Size(132, 22);
            this.txtPrNummer.TabIndex = 95;
            this.txtPrNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrNummer_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "product nummer:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Producten:";
            // 
            // cmbProducten
            // 
            this.cmbProducten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProducten.FormattingEnabled = true;
            this.cmbProducten.Location = new System.Drawing.Point(750, 228);
            this.cmbProducten.Name = "cmbProducten";
            this.cmbProducten.Size = new System.Drawing.Size(167, 24);
            this.cmbProducten.TabIndex = 97;
            this.cmbProducten.SelectedIndexChanged += new System.EventHandler(this.cmbProducten_SelectedIndexChanged);
            // 
            // llblNewKlant
            // 
            this.llblNewKlant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblNewKlant.AutoSize = true;
            this.llblNewKlant.Location = new System.Drawing.Point(218, 52);
            this.llblNewKlant.Name = "llblNewKlant";
            this.llblNewKlant.Size = new System.Drawing.Size(82, 17);
            this.llblNewKlant.TabIndex = 98;
            this.llblNewKlant.TabStop = true;
            this.llblNewKlant.Text = "Nieuw Klant";
            this.llblNewKlant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNewKlant_LinkClicked);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOrder.Location = new System.Drawing.Point(547, 717);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(151, 51);
            this.btnAddOrder.TabIndex = 99;
            this.btnAddOrder.Text = "Toevoegen";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "Bezorger:";
            // 
            // cmbBezorgers
            // 
            this.cmbBezorgers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBezorgers.FormattingEnabled = true;
            this.cmbBezorgers.Location = new System.Drawing.Point(351, 663);
            this.cmbBezorgers.Name = "cmbBezorgers";
            this.cmbBezorgers.Size = new System.Drawing.Size(270, 24);
            this.cmbBezorgers.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(862, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 115;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 789);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBezorgers);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.llblNewKlant);
            this.Controls.Add(this.cmbProducten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrNummer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvOrderProducten);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKlantAdress);
            this.Controls.Add(this.llblAddAdress);
            this.Controls.Add(this.pnlAdress);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKlanten);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.pnlAdress.ResumeLayout(false);
            this.pnlAdress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKlanten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.LinkLabel llblAddAdress;
        private System.Windows.Forms.Panel pnlAdress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttGem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHuisNr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStraat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblKlantAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridView dgvOrderProducten;
        private System.Windows.Forms.TextBox txtPrNummer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProducten;
        private System.Windows.Forms.LinkLabel llblNewKlant;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBezorgers;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}