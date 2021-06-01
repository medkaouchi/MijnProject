
namespace MijnProject
{
    partial class EditAantal
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudAantal = new System.Windows.Forms.NumericUpDown();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nieuw aantal :";
            // 
            // nudAantal
            // 
            this.nudAantal.Location = new System.Drawing.Point(137, 38);
            this.nudAantal.Name = "nudAantal";
            this.nudAantal.Size = new System.Drawing.Size(120, 22);
            this.nudAantal.TabIndex = 1;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpslaan.Location = new System.Drawing.Point(53, 80);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(131, 35);
            this.btnOpslaan.TabIndex = 2;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 115;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditAantal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 127);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.nudAantal);
            this.Controls.Add(this.label1);
            this.Name = "EditAantal";
            this.Text = "EditAantal";
            ((System.ComponentModel.ISupportInitialize)(this.nudAantal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAantal;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button button1;
    }
}