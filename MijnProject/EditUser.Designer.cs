
namespace MijnProject
{
    partial class EditUser
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
            this.cmbAdress = new System.Windows.Forms.ComboBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpGD = new System.Windows.Forms.DateTimePicker();
            this.txtAnaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVnaam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAdress
            // 
            this.cmbAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAdress.FormattingEnabled = true;
            this.cmbAdress.Location = new System.Drawing.Point(542, 250);
            this.cmbAdress.Name = "cmbAdress";
            this.cmbAdress.Size = new System.Drawing.Size(271, 24);
            this.cmbAdress.TabIndex = 5;
            this.cmbAdress.TextUpdate += new System.EventHandler(this.cmbAdress_TextUpdate);
            this.cmbAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAdress_KeyPress);
            // 
            // llblAddAdress
            // 
            this.llblAddAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblAddAdress.AutoSize = true;
            this.llblAddAdress.Location = new System.Drawing.Point(544, 276);
            this.llblAddAdress.Name = "llblAddAdress";
            this.llblAddAdress.Size = new System.Drawing.Size(93, 17);
            this.llblAddAdress.TabIndex = 6;
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
            this.pnlAdress.Location = new System.Drawing.Point(534, 299);
            this.pnlAdress.Name = "pnlAdress";
            this.pnlAdress.Size = new System.Drawing.Size(289, 122);
            this.pnlAdress.TabIndex = 58;
            this.pnlAdress.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(46, 88);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(132, 22);
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
            this.txtPC.Location = new System.Drawing.Point(218, 51);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(60, 22);
            this.txtPC.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "PC:";
            // 
            // txttGem
            // 
            this.txttGem.Location = new System.Drawing.Point(46, 51);
            this.txttGem.Name = "txttGem";
            this.txttGem.Size = new System.Drawing.Size(132, 22);
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
            this.txtHuisNr.Location = new System.Drawing.Point(218, 13);
            this.txtHuisNr.Name = "txtHuisNr";
            this.txtHuisNr.Size = new System.Drawing.Size(60, 22);
            this.txtHuisNr.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "hnr:";
            // 
            // txtStraat
            // 
            this.txtStraat.Location = new System.Drawing.Point(46, 13);
            this.txtStraat.Name = "txtStraat";
            this.txtStraat.Size = new System.Drawing.Size(132, 22);
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
            this.label17.Location = new System.Drawing.Point(390, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 57;
            this.label17.Text = "Adress:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 712);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(456, 34);
            this.label11.TabIndex = 55;
            this.label11.Text = "(*) Uppercase,  lowercase, number, special character and length:min 8.\r\n\r\n";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Role:";
            // 
            // cmbRoles
            // 
            this.cmbRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(543, 461);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(270, 24);
            this.cmbRoles.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(542, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Email:";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTel.Location = new System.Drawing.Point(542, 174);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(270, 22);
            this.txtTel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Telefoon:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Geboortdatum:";
            // 
            // dtpGD
            // 
            this.dtpGD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGD.Location = new System.Drawing.Point(542, 135);
            this.dtpGD.Name = "dtpGD";
            this.dtpGD.Size = new System.Drawing.Size(271, 22);
            this.dtpGD.TabIndex = 2;
            // 
            // txtAnaam
            // 
            this.txtAnaam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnaam.Location = new System.Drawing.Point(542, 96);
            this.txtAnaam.Name = "txtAnaam";
            this.txtAnaam.Size = new System.Drawing.Size(270, 22);
            this.txtAnaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Achternaam:";
            // 
            // txtVnaam
            // 
            this.txtVnaam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVnaam.Location = new System.Drawing.Point(542, 57);
            this.txtVnaam.Name = "txtVnaam";
            this.txtVnaam.Size = new System.Drawing.Size(270, 22);
            this.txtVnaam.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(534, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Opslaan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Voornaam:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1056, 709);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 770);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbAdress);
            this.Controls.Add(this.llblAddAdress);
            this.Controls.Add(this.pnlAdress);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpGD);
            this.Controls.Add(this.txtAnaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVnaam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.pnlAdress.ResumeLayout(false);
            this.pnlAdress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAdress;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpGD;
        private System.Windows.Forms.TextBox txtAnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVnaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}