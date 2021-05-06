namespace ViewStatsDocker
{
    partial class frmHome
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartMonitoring = new System.Windows.Forms.Button();
            this.btnStopMonitoring = new System.Windows.Forms.Button();
            this.chartCpuUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMemoryUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLinkUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDiskUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpuUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemoryUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLinkUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStartMonitoring);
            this.panel1.Controls.Add(this.btnStopMonitoring);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnStartMonitoring
            // 
            this.btnStartMonitoring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartMonitoring.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStartMonitoring.FlatAppearance.BorderSize = 0;
            this.btnStartMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMonitoring.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMonitoring.Location = new System.Drawing.Point(0, 0);
            this.btnStartMonitoring.Name = "btnStartMonitoring";
            this.btnStartMonitoring.Size = new System.Drawing.Size(618, 50);
            this.btnStartMonitoring.TabIndex = 12;
            this.btnStartMonitoring.Text = "START MONITORING";
            this.btnStartMonitoring.UseVisualStyleBackColor = false;
            this.btnStartMonitoring.Click += new System.EventHandler(this.btnStartMonitoring_Click);
            // 
            // btnStopMonitoring
            // 
            this.btnStopMonitoring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStopMonitoring.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStopMonitoring.Enabled = false;
            this.btnStopMonitoring.FlatAppearance.BorderSize = 0;
            this.btnStopMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMonitoring.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMonitoring.Location = new System.Drawing.Point(617, 0);
            this.btnStopMonitoring.Name = "btnStopMonitoring";
            this.btnStopMonitoring.Size = new System.Drawing.Size(618, 50);
            this.btnStopMonitoring.TabIndex = 13;
            this.btnStopMonitoring.Text = "STOP MONITORING";
            this.btnStopMonitoring.UseVisualStyleBackColor = false;
            this.btnStopMonitoring.Click += new System.EventHandler(this.btnStopMonitoring_Click);
            // 
            // chartCpuUsage
            // 
            this.chartCpuUsage.BackColor = System.Drawing.Color.Transparent;
            this.chartCpuUsage.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartCpuUsage.ChartAreas.Add(chartArea1);
            this.chartCpuUsage.Location = new System.Drawing.Point(12, 56);
            this.chartCpuUsage.Name = "chartCpuUsage";
            this.chartCpuUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Name = "Cpu Usage";
            this.chartCpuUsage.Series.Add(series1);
            this.chartCpuUsage.Size = new System.Drawing.Size(600, 300);
            this.chartCpuUsage.TabIndex = 14;
            title1.Font = new System.Drawing.Font("Gadugi", 14.25F);
            title1.Name = "Title1";
            title1.Text = "CPU Usage";
            this.chartCpuUsage.Titles.Add(title1);
            // 
            // chartMemoryUsage
            // 
            this.chartMemoryUsage.BackColor = System.Drawing.Color.Transparent;
            this.chartMemoryUsage.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartMemoryUsage.ChartAreas.Add(chartArea2);
            this.chartMemoryUsage.Location = new System.Drawing.Point(617, 56);
            this.chartMemoryUsage.Name = "chartMemoryUsage";
            this.chartMemoryUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Memory Usage";
            this.chartMemoryUsage.Series.Add(series2);
            this.chartMemoryUsage.Size = new System.Drawing.Size(600, 300);
            this.chartMemoryUsage.TabIndex = 15;
            title2.Font = new System.Drawing.Font("Gadugi", 14.25F);
            title2.Name = "Title1";
            title2.Text = "Memory Usage";
            this.chartMemoryUsage.Titles.Add(title2);
            // 
            // chartLinkUsage
            // 
            this.chartLinkUsage.BackColor = System.Drawing.Color.Transparent;
            this.chartLinkUsage.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartLinkUsage.ChartAreas.Add(chartArea3);
            this.chartLinkUsage.Location = new System.Drawing.Point(12, 362);
            this.chartLinkUsage.Name = "chartLinkUsage";
            this.chartLinkUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Name = "Link Usage";
            this.chartLinkUsage.Series.Add(series3);
            this.chartLinkUsage.Size = new System.Drawing.Size(600, 300);
            this.chartLinkUsage.TabIndex = 16;
            title3.Font = new System.Drawing.Font("Gadugi", 14.25F);
            title3.Name = "Title1";
            title3.Text = "Link Usage";
            this.chartLinkUsage.Titles.Add(title3);
            // 
            // chartDiskUsage
            // 
            this.chartDiskUsage.BackColor = System.Drawing.Color.Transparent;
            this.chartDiskUsage.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartDiskUsage.ChartAreas.Add(chartArea4);
            this.chartDiskUsage.Location = new System.Drawing.Point(618, 362);
            this.chartDiskUsage.Name = "chartDiskUsage";
            this.chartDiskUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Name = "Disk Usage";
            this.chartDiskUsage.Series.Add(series4);
            this.chartDiskUsage.Size = new System.Drawing.Size(600, 300);
            this.chartDiskUsage.TabIndex = 17;
            title4.Font = new System.Drawing.Font("Gadugi", 14.25F);
            title4.Name = "Title1";
            title4.Text = "Disk Usage";
            this.chartDiskUsage.Titles.Add(title4);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 695);
            this.Controls.Add(this.chartDiskUsage);
            this.Controls.Add(this.chartLinkUsage);
            this.Controls.Add(this.chartMemoryUsage);
            this.Controls.Add(this.chartCpuUsage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCpuUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemoryUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLinkUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUsage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStartMonitoring;
        private System.Windows.Forms.Button btnStopMonitoring;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartCpuUsage;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartMemoryUsage;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartLinkUsage;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartDiskUsage;
    }
}