
namespace MijnProject
{
    partial class Overzicht
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEind = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOverzicht = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.crtTopverkocht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnToon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crtTopverkocht)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin datum:";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBegin.Location = new System.Drawing.Point(317, 65);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 22);
            this.dtpBegin.TabIndex = 1;
            // 
            // dtpEind
            // 
            this.dtpEind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEind.Location = new System.Drawing.Point(317, 102);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(200, 22);
            this.dtpEind.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eind datum:";
            // 
            // cmbOverzicht
            // 
            this.cmbOverzicht.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbOverzicht.FormattingEnabled = true;
            this.cmbOverzicht.Items.AddRange(new object[] {
            "10 best verkochte producten",
            "10 best besteld producten",
            "10 minder verkochte producten",
            "10 minder besteld producten",
            "10 best kopers (bedrag)",
            "10 best kopers (bestellingen)",
            "10 best verkopers (bedrag)",
            "10 best verkopers (bestellingen)",
            "bestellingen per bezorgers",
            "Incomes",
            "Bestellingen",
            "Nieuwe klanten"});
            this.cmbOverzicht.Location = new System.Drawing.Point(317, 25);
            this.cmbOverzicht.Name = "cmbOverzicht";
            this.cmbOverzicht.Size = new System.Drawing.Size(232, 24);
            this.cmbOverzicht.TabIndex = 4;
            this.cmbOverzicht.SelectedIndexChanged += new System.EventHandler(this.cmbOverzicht_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Overzicht:";
            // 
            // crtTopverkocht
            // 
            this.crtTopverkocht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crtTopverkocht.BackColor = System.Drawing.Color.LightYellow;
            this.crtTopverkocht.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.crtTopverkocht.BackSecondaryColor = System.Drawing.Color.White;
            this.crtTopverkocht.BorderlineWidth = 0;
            this.crtTopverkocht.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.PointDepth = 80;
            chartArea1.Area3DStyle.PointGapDepth = 50;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 1;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.LightYellow;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.crtTopverkocht.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtTopverkocht.Legends.Add(legend1);
            this.crtTopverkocht.Location = new System.Drawing.Point(15, 202);
            this.crtTopverkocht.Name = "crtTopverkocht";
            this.crtTopverkocht.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "product";
            this.crtTopverkocht.Series.Add(series1);
            this.crtTopverkocht.Size = new System.Drawing.Size(773, 394);
            this.crtTopverkocht.TabIndex = 6;
            this.crtTopverkocht.Text = "chart1";
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(317, 146);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(114, 39);
            this.btnToon.TabIndex = 7;
            this.btnToon.Text = "Toon";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.crtTopverkocht);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOverzicht);
            this.Controls.Add(this.dtpEind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.label1);
            this.Name = "Overzicht";
            this.Text = "Overzicht";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Overzicht_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.crtTopverkocht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOverzicht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtTopverkocht;
        private System.Windows.Forms.Button btnToon;
    }
}