
namespace MijnProject
{
    partial class EditOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrder));
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.llblNewKlant = new System.Windows.Forms.LinkLabel();
            this.cmbProducten = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrNummer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlanten = new System.Windows.Forms.ComboBox();
            this.dgvOrderProducten = new System.Windows.Forms.DataGridView();
            this.lblKlantAdress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBezorgers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pnlAdress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpslaan.Location = new System.Drawing.Point(696, 853);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(151, 51);
            this.btnOpslaan.TabIndex = 8;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // llblNewKlant
            // 
            this.llblNewKlant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblNewKlant.AutoSize = true;
            this.llblNewKlant.Location = new System.Drawing.Point(657, 167);
            this.llblNewKlant.Name = "llblNewKlant";
            this.llblNewKlant.Size = new System.Drawing.Size(82, 17);
            this.llblNewKlant.TabIndex = 1;
            this.llblNewKlant.TabStop = true;
            this.llblNewKlant.Text = "Nieuw Klant";
            this.llblNewKlant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNewKlant_LinkClicked_1);
            // 
            // cmbProducten
            // 
            this.cmbProducten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProducten.FormattingEnabled = true;
            this.cmbProducten.Location = new System.Drawing.Point(1090, 343);
            this.cmbProducten.Name = "cmbProducten";
            this.cmbProducten.Size = new System.Drawing.Size(167, 24);
            this.cmbProducten.TabIndex = 5;
            this.cmbProducten.SelectedIndexChanged += new System.EventHandler(this.cmbProducten_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1017, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 113;
            this.label7.Text = "Producten:";
            // 
            // txtPrNummer
            // 
            this.txtPrNummer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrNummer.Location = new System.Drawing.Point(824, 347);
            this.txtPrNummer.Name = "txtPrNummer";
            this.txtPrNummer.Size = new System.Drawing.Size(132, 22);
            this.txtPrNummer.TabIndex = 4;
            this.txtPrNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrNummer_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "product nummer:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.Location = new System.Drawing.Point(457, 348);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(195, 22);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 108;
            this.label5.Text = "product barcode:";
            // 
            // llblAddAdress
            // 
            this.llblAddAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblAddAdress.AutoSize = true;
            this.llblAddAdress.Location = new System.Drawing.Point(655, 224);
            this.llblAddAdress.Name = "llblAddAdress";
            this.llblAddAdress.Size = new System.Drawing.Size(93, 17);
            this.llblAddAdress.TabIndex = 2;
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
            this.pnlAdress.Location = new System.Drawing.Point(658, 197);
            this.pnlAdress.Name = "pnlAdress";
            this.pnlAdress.Size = new System.Drawing.Size(270, 122);
            this.pnlAdress.TabIndex = 105;
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
            this.label17.Location = new System.Drawing.Point(522, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 104;
            this.label17.Text = "Adress:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 752);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(686, 749);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(270, 24);
            this.cmbStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Klant:";
            // 
            // cmbKlanten
            // 
            this.cmbKlanten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKlanten.FormattingEnabled = true;
            this.cmbKlanten.Location = new System.Drawing.Point(658, 140);
            this.cmbKlanten.Name = "cmbKlanten";
            this.cmbKlanten.Size = new System.Drawing.Size(270, 24);
            this.cmbKlanten.TabIndex = 0;
            // 
            // dgvOrderProducten
            // 
            this.dgvOrderProducten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderProducten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderProducten.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProducten.Location = new System.Drawing.Point(70, 388);
            this.dgvOrderProducten.Name = "dgvOrderProducten";
            this.dgvOrderProducten.RowHeadersVisible = false;
            this.dgvOrderProducten.RowHeadersWidth = 51;
            this.dgvOrderProducten.RowTemplate.Height = 24;
            this.dgvOrderProducten.Size = new System.Drawing.Size(1447, 295);
            this.dgvOrderProducten.TabIndex = 110;
            this.dgvOrderProducten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderProducten_CellClick);
            // 
            // lblKlantAdress
            // 
            this.lblKlantAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKlantAdress.AutoSize = true;
            this.lblKlantAdress.Location = new System.Drawing.Point(655, 197);
            this.lblKlantAdress.Name = "lblKlantAdress";
            this.lblKlantAdress.Size = new System.Drawing.Size(84, 17);
            this.lblKlantAdress.TabIndex = 107;
            this.lblKlantAdress.Text = "KlantAdress";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 796);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "Bezorger:";
            // 
            // cmbBezorgers
            // 
            this.cmbBezorgers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBezorgers.FormattingEnabled = true;
            this.cmbBezorgers.Location = new System.Drawing.Point(686, 793);
            this.cmbBezorgers.Name = "cmbBezorgers";
            this.cmbBezorgers.Size = new System.Drawing.Size(270, 24);
            this.cmbBezorgers.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1464, 939);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 9;
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
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 988);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBezorgers);
            this.Controls.Add(this.btnOpslaan);
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
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.pnlAdress.ResumeLayout(false);
            this.pnlAdress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.LinkLabel llblNewKlant;
        private System.Windows.Forms.ComboBox cmbProducten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrNummer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKlanten;
        private System.Windows.Forms.DataGridView dgvOrderProducten;
        private System.Windows.Forms.Label lblKlantAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBezorgers;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}