
namespace MijnProject
{
    partial class Main
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
            this.btnDatabeheer = new System.Windows.Forms.Button();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.btnBestelling = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.llblLogOut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnDatabeheer
            // 
            this.btnDatabeheer.Location = new System.Drawing.Point(43, 76);
            this.btnDatabeheer.Name = "btnDatabeheer";
            this.btnDatabeheer.Size = new System.Drawing.Size(126, 50);
            this.btnDatabeheer.TabIndex = 0;
            this.btnDatabeheer.Text = "Databeheer";
            this.btnDatabeheer.UseVisualStyleBackColor = true;
            this.btnDatabeheer.Click += new System.EventHandler(this.btnDatabeheer_Click);
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(197, 76);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(126, 50);
            this.btnOverzicht.TabIndex = 1;
            this.btnOverzicht.Text = "Overzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // btnBestelling
            // 
            this.btnBestelling.Location = new System.Drawing.Point(351, 76);
            this.btnBestelling.Name = "btnBestelling";
            this.btnBestelling.Size = new System.Drawing.Size(126, 50);
            this.btnBestelling.TabIndex = 2;
            this.btnBestelling.Text = "Bestellingen ";
            this.btnBestelling.UseVisualStyleBackColor = true;
            this.btnBestelling.Click += new System.EventHandler(this.btnBestelling_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(302, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // llblLogOut
            // 
            this.llblLogOut.AutoSize = true;
            this.llblLogOut.Location = new System.Drawing.Point(417, 28);
            this.llblLogOut.Name = "llblLogOut";
            this.llblLogOut.Size = new System.Drawing.Size(56, 17);
            this.llblLogOut.TabIndex = 4;
            this.llblLogOut.TabStop = true;
            this.llblLogOut.Text = "Log out";
            this.llblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLogOut_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 160);
            this.Controls.Add(this.llblLogOut);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnBestelling);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.btnDatabeheer);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDatabeheer;
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.Button btnBestelling;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.LinkLabel llblLogOut;
    }
}