
namespace MijnProject
{
    partial class Bestellingen
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.llblAddOrder = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(0, 29);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(802, 389);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            this.dgvOrders.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvOrders_CellPainting);
            // 
            // llblAddOrder
            // 
            this.llblAddOrder.AutoSize = true;
            this.llblAddOrder.Location = new System.Drawing.Point(46, 9);
            this.llblAddOrder.Name = "llblAddOrder";
            this.llblAddOrder.Size = new System.Drawing.Size(182, 17);
            this.llblAddOrder.TabIndex = 1;
            this.llblAddOrder.TabStop = true;
            this.llblAddOrder.Text = "Nieuw Bestelling toevoegen";
            this.llblAddOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAddOrder_LinkClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(670, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 115;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bestellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.llblAddOrder);
            this.Controls.Add(this.dgvOrders);
            this.Name = "Bestellingen";
            this.Text = "Bestellingen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bestellingen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.LinkLabel llblAddOrder;
        private System.Windows.Forms.Button button1;
    }
}