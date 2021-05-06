namespace ViewStatsDocker
{
    partial class frmDisk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisk));
            this.btnStopMonitoring = new System.Windows.Forms.Button();
            this.btnStartMonitoring = new System.Windows.Forms.Button();
            this.chartDiskUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.asyncWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPrevious = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.lblDiskUsageTotal = new System.Windows.Forms.Label();
            this.lblDiskUsage = new System.Windows.Forms.Label();
            this.lblDiskUsageMin = new System.Windows.Forms.Label();
            this.lblDiskUsageMax = new System.Windows.Forms.Label();
            this.gpDisk = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUsage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.gpDisk.SuspendLayout();
            this.SuspendLayout();
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
            this.btnStopMonitoring.TabIndex = 10;
            this.btnStopMonitoring.Text = "STOP MONITORING";
            this.btnStopMonitoring.UseVisualStyleBackColor = false;
            this.btnStopMonitoring.Click += new System.EventHandler(this.btnStopMonitoring_Click);
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
            this.btnStartMonitoring.TabIndex = 9;
            this.btnStartMonitoring.Text = "START MONITORING";
            this.btnStartMonitoring.UseVisualStyleBackColor = false;
            this.btnStartMonitoring.Click += new System.EventHandler(this.btnStartMonitoring_Click);
            // 
            // chartDiskUsage
            // 
            this.chartDiskUsage.BackColor = System.Drawing.Color.Transparent;
            this.chartDiskUsage.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartDiskUsage.ChartAreas.Add(chartArea1);
            this.chartDiskUsage.Location = new System.Drawing.Point(15, 315);
            this.chartDiskUsage.Name = "chartDiskUsage";
            this.chartDiskUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Name = "Disk Usage";
            this.chartDiskUsage.Series.Add(series1);
            this.chartDiskUsage.Size = new System.Drawing.Size(1180, 373);
            this.chartDiskUsage.TabIndex = 11;
            // 
            // asyncWorker
            // 
            this.asyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.asyncWorker_DoWork);
            this.asyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.asyncWorker_ProgressChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStartMonitoring);
            this.panel1.Controls.Add(this.btnStopMonitoring);
            this.panel1.Font = new System.Drawing.Font("Gadugi", 20F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 50);
            this.panel1.TabIndex = 12;
            // 
            // pbPrevious
            // 
            this.pbPrevious.BackColor = System.Drawing.Color.Transparent;
            this.pbPrevious.Enabled = false;
            this.pbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("pbPrevious.Image")));
            this.pbPrevious.Location = new System.Drawing.Point(15, 465);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(50, 50);
            this.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrevious.TabIndex = 13;
            this.pbPrevious.TabStop = false;
            this.pbPrevious.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Enabled = false;
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(1170, 465);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(50, 50);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 14;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // lblDiskUsageTotal
            // 
            this.lblDiskUsageTotal.AutoSize = true;
            this.lblDiskUsageTotal.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskUsageTotal.Location = new System.Drawing.Point(892, 45);
            this.lblDiskUsageTotal.Name = "lblDiskUsageTotal";
            this.lblDiskUsageTotal.Size = new System.Drawing.Size(32, 42);
            this.lblDiskUsageTotal.TabIndex = 15;
            this.lblDiskUsageTotal.Text = "-";
            // 
            // lblDiskUsage
            // 
            this.lblDiskUsage.AutoSize = true;
            this.lblDiskUsage.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskUsage.Location = new System.Drawing.Point(278, 45);
            this.lblDiskUsage.Name = "lblDiskUsage";
            this.lblDiskUsage.Size = new System.Drawing.Size(32, 42);
            this.lblDiskUsage.TabIndex = 16;
            this.lblDiskUsage.Text = "-";
            // 
            // lblDiskUsageMin
            // 
            this.lblDiskUsageMin.AutoSize = true;
            this.lblDiskUsageMin.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskUsageMin.Location = new System.Drawing.Point(892, 165);
            this.lblDiskUsageMin.Name = "lblDiskUsageMin";
            this.lblDiskUsageMin.Size = new System.Drawing.Size(32, 42);
            this.lblDiskUsageMin.TabIndex = 17;
            this.lblDiskUsageMin.Text = "-";
            // 
            // lblDiskUsageMax
            // 
            this.lblDiskUsageMax.AutoSize = true;
            this.lblDiskUsageMax.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskUsageMax.Location = new System.Drawing.Point(278, 165);
            this.lblDiskUsageMax.Name = "lblDiskUsageMax";
            this.lblDiskUsageMax.Size = new System.Drawing.Size(32, 42);
            this.lblDiskUsageMax.TabIndex = 18;
            this.lblDiskUsageMax.Text = "-";
            // 
            // gpDisk
            // 
            this.gpDisk.Controls.Add(this.panel3);
            this.gpDisk.Controls.Add(this.panel2);
            this.gpDisk.Controls.Add(this.label4);
            this.gpDisk.Controls.Add(this.label3);
            this.gpDisk.Controls.Add(this.label2);
            this.gpDisk.Controls.Add(this.label1);
            this.gpDisk.Controls.Add(this.lblDiskUsageMax);
            this.gpDisk.Controls.Add(this.lblDiskUsageMin);
            this.gpDisk.Controls.Add(this.lblDiskUsage);
            this.gpDisk.Controls.Add(this.lblDiskUsageTotal);
            this.gpDisk.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDisk.Location = new System.Drawing.Point(15, 56);
            this.gpDisk.Name = "gpDisk";
            this.gpDisk.Size = new System.Drawing.Size(1208, 260);
            this.gpDisk.TabIndex = 19;
            this.gpDisk.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(13, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1180, 1);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(603, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 220);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(834, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Disk Minimum Usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(835, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Disk Total Usage";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Disk Maximum Usage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Disk Current Usage";
            // 
            // frmDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 695);
            this.Controls.Add(this.gpDisk);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrevious);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartDiskUsage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDisk";
            this.Text = "frmCpu";
            this.Load += new System.EventHandler(this.frmDisk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiskUsage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.gpDisk.ResumeLayout(false);
            this.gpDisk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDiskUsageTotal;
        private System.Windows.Forms.Label lblDiskUsage;
        private System.Windows.Forms.Label lblDiskUsageMin;
        private System.Windows.Forms.Label lblDiskUsageMax;
        private System.Windows.Forms.GroupBox gpDisk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.ComponentModel.BackgroundWorker asyncWorker;
        public System.Windows.Forms.Button btnStopMonitoring;
        public System.Windows.Forms.Button btnStartMonitoring;
        public System.Windows.Forms.PictureBox pbPrevious;
        public System.Windows.Forms.PictureBox pbNext;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartDiskUsage;
    }
}