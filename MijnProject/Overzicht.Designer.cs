
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEind = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOverzicht = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.crtTopverkocht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnToon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nudTop = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.crtTopverkocht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin datum:";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBegin.Location = new System.Drawing.Point(477, 93);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(232, 22);
            this.dtpBegin.TabIndex = 1;
            // 
            // dtpEind
            // 
            this.dtpEind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEind.Location = new System.Drawing.Point(477, 130);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(232, 22);
            this.dtpEind.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 135);
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
            "Beste verkochte producten",
            "Beste besteld producten",
            "Slechte verkochte producten",
            "Slechte besteld producten",
            "Best kopers (bedrag)",
            "Best kopers (bestellingen)",
            "Best verkopers (bedrag)",
            "Best verkopers (bestellingen)",
            "Bestellingen per bezorgers",
            "Incomes",
            "Bestellingen",
            "Nieuwe klanten"});
            this.cmbOverzicht.Location = new System.Drawing.Point(477, 53);
            this.cmbOverzicht.Name = "cmbOverzicht";
            this.cmbOverzicht.Size = new System.Drawing.Size(232, 24);
            this.cmbOverzicht.TabIndex = 4;
            this.cmbOverzicht.SelectedIndexChanged += new System.EventHandler(this.cmbOverzicht_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 56);
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
            this.crtTopverkocht.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.crtTopverkocht.BackSecondaryColor = System.Drawing.Color.White;
            this.crtTopverkocht.BorderlineWidth = 0;
            this.crtTopverkocht.BorderSkin.BackColor = System.Drawing.Color.White;
            this.crtTopverkocht.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea5.Area3DStyle.Enable3D = true;
            chartArea5.Area3DStyle.Inclination = 10;
            chartArea5.Area3DStyle.PointDepth = 80;
            chartArea5.Area3DStyle.PointGapDepth = 50;
            chartArea5.Area3DStyle.Rotation = 10;
            chartArea5.Area3DStyle.WallWidth = 1;
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkBlue;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.DarkBlue;
            chartArea5.AxisX.ScaleBreakStyle.Spacing = 0.5D;
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.DarkBlue;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkBlue;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.BackColor = System.Drawing.Color.White;
            chartArea5.BackSecondaryColor = System.Drawing.Color.White;
            chartArea5.BorderColor = System.Drawing.Color.Transparent;
            chartArea5.BorderWidth = 0;
            chartArea5.Name = "ChartArea1";
            chartArea5.ShadowColor = System.Drawing.Color.Transparent;
            this.crtTopverkocht.ChartAreas.Add(chartArea5);
            legend5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend5.BorderWidth = 0;
            legend5.DockedToChartArea = "ChartArea1";
            legend5.ForeColor = System.Drawing.Color.DarkBlue;
            legend5.Name = "Legend1";
            legend5.ShadowColor = System.Drawing.Color.Transparent;
            legend5.TitleFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.TitleForeColor = System.Drawing.Color.DarkBlue;
            this.crtTopverkocht.Legends.Add(legend5);
            this.crtTopverkocht.Location = new System.Drawing.Point(15, 213);
            this.crtTopverkocht.Name = "crtTopverkocht";
            this.crtTopverkocht.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "product";
            this.crtTopverkocht.Series.Add(series5);
            this.crtTopverkocht.Size = new System.Drawing.Size(1227, 497);
            this.crtTopverkocht.TabIndex = 6;
            this.crtTopverkocht.Text = "chart1";
            // 
            // btnToon
            // 
            this.btnToon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToon.Location = new System.Drawing.Point(477, 168);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(232, 39);
            this.btnToon.TabIndex = 7;
            this.btnToon.Text = "Toon";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1124, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 115;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudTop
            // 
            this.nudTop.Location = new System.Drawing.Point(61, 17);
            this.nudTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTop.Name = "nudTop";
            this.nudTop.Size = new System.Drawing.Size(92, 22);
            this.nudTop.TabIndex = 116;
            this.nudTop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "Top: ";
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTop.Controls.Add(this.nudTop);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Location = new System.Drawing.Point(715, 37);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(153, 54);
            this.pnlTop.TabIndex = 118;
            this.pnlTop.Visible = false;
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 765);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTop;
    }
}