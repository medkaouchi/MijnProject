﻿
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
            this.pnlAdress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpslaan.Location = new System.Drawing.Point(435, 650);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(151, 51);
            this.btnOpslaan.TabIndex = 116;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // llblNewKlant
            // 
            this.llblNewKlant.AutoSize = true;
            this.llblNewKlant.Location = new System.Drawing.Point(253, 60);
            this.llblNewKlant.Name = "llblNewKlant";
            this.llblNewKlant.Size = new System.Drawing.Size(82, 17);
            this.llblNewKlant.TabIndex = 115;
            this.llblNewKlant.TabStop = true;
            this.llblNewKlant.Text = "Nieuw Klant";
            // 
            // cmbProducten
            // 
            this.cmbProducten.FormattingEnabled = true;
            this.cmbProducten.Location = new System.Drawing.Point(785, 236);
            this.cmbProducten.Name = "cmbProducten";
            this.cmbProducten.Size = new System.Drawing.Size(167, 24);
            this.cmbProducten.TabIndex = 114;
            this.cmbProducten.SelectedIndexChanged += new System.EventHandler(this.cmbProducten_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 113;
            this.label7.Text = "Producten:";
            // 
            // txtPrNummer
            // 
            this.txtPrNummer.Location = new System.Drawing.Point(558, 236);
            this.txtPrNummer.Name = "txtPrNummer";
            this.txtPrNummer.Size = new System.Drawing.Size(132, 22);
            this.txtPrNummer.TabIndex = 112;
            this.txtPrNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrNummer_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "product nummer:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(229, 236);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(195, 22);
            this.txtBarcode.TabIndex = 109;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 108;
            this.label5.Text = "product barcode:";
            // 
            // llblAddAdress
            // 
            this.llblAddAdress.AutoSize = true;
            this.llblAddAdress.Location = new System.Drawing.Point(251, 117);
            this.llblAddAdress.Name = "llblAddAdress";
            this.llblAddAdress.Size = new System.Drawing.Size(93, 17);
            this.llblAddAdress.TabIndex = 106;
            this.llblAddAdress.TabStop = true;
            this.llblAddAdress.Text = "Nieuw adress";
            this.llblAddAdress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAddAdress_LinkClicked);
            // 
            // pnlAdress
            // 
            this.pnlAdress.AllowDrop = true;
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
            this.pnlAdress.Location = new System.Drawing.Point(254, 90);
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
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 104;
            this.label17.Text = "Adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(254, 576);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(270, 24);
            this.cmbStatus.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Klant:";
            // 
            // cmbKlanten
            // 
            this.cmbKlanten.FormattingEnabled = true;
            this.cmbKlanten.Location = new System.Drawing.Point(254, 33);
            this.cmbKlanten.Name = "cmbKlanten";
            this.cmbKlanten.Size = new System.Drawing.Size(270, 24);
            this.cmbKlanten.TabIndex = 100;
            // 
            // dgvOrderProducten
            // 
            this.dgvOrderProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProducten.Location = new System.Drawing.Point(121, 286);
            this.dgvOrderProducten.Name = "dgvOrderProducten";
            this.dgvOrderProducten.RowHeadersWidth = 51;
            this.dgvOrderProducten.RowTemplate.Height = 24;
            this.dgvOrderProducten.Size = new System.Drawing.Size(832, 266);
            this.dgvOrderProducten.TabIndex = 110;
            // 
            // lblKlantAdress
            // 
            this.lblKlantAdress.AutoSize = true;
            this.lblKlantAdress.Location = new System.Drawing.Point(251, 90);
            this.lblKlantAdress.Name = "lblKlantAdress";
            this.lblKlantAdress.Size = new System.Drawing.Size(84, 17);
            this.lblKlantAdress.TabIndex = 107;
            this.lblKlantAdress.Text = "KlantAdress";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 756);
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
    }
}