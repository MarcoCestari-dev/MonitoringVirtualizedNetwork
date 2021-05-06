﻿namespace ViewStatsDocker
{
    partial class frmCpu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCpu));
            this.btnStopMonitoring = new System.Windows.Forms.Button();
            this.btnStartMonitoring = new System.Windows.Forms.Button();
            this.chartCpuUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.asyncWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPrevious = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.lblCpuUsageAvg = new System.Windows.Forms.Label();
            this.lblCpuUsage = new System.Windows.Forms.Label();
            this.lblCpuUsageMin = new System.Windows.Forms.Label();
            this.lblCpuUsageMax = new System.Windows.Forms.Label();
            this.gpCpu = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpuUsage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.gpCpu.SuspendLayout();
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
            // chartCpuUsage
            // 
            this.chartCpuUsage.BackColor = System.Drawing.Color.Transparent;
            this.chartCpuUsage.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartCpuUsage.ChartAreas.Add(chartArea1);
            this.chartCpuUsage.Location = new System.Drawing.Point(15, 315);
            this.chartCpuUsage.Name = "chartCpuUsage";
            this.chartCpuUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Name = "Cpu Usage";
            this.chartCpuUsage.Series.Add(series1);
            this.chartCpuUsage.Size = new System.Drawing.Size(1180, 373);
            this.chartCpuUsage.TabIndex = 11;
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
            // lblCpuUsageAvg
            // 
            this.lblCpuUsageAvg.AutoSize = true;
            this.lblCpuUsageAvg.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuUsageAvg.Location = new System.Drawing.Point(879, 45);
            this.lblCpuUsageAvg.Name = "lblCpuUsageAvg";
            this.lblCpuUsageAvg.Size = new System.Drawing.Size(71, 42);
            this.lblCpuUsageAvg.TabIndex = 15;
            this.lblCpuUsageAvg.Text = "- %";
            // 
            // lblCpuUsage
            // 
            this.lblCpuUsage.AutoSize = true;
            this.lblCpuUsage.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuUsage.Location = new System.Drawing.Point(265, 45);
            this.lblCpuUsage.Name = "lblCpuUsage";
            this.lblCpuUsage.Size = new System.Drawing.Size(71, 42);
            this.lblCpuUsage.TabIndex = 16;
            this.lblCpuUsage.Text = "- %";
            // 
            // lblCpuUsageMin
            // 
            this.lblCpuUsageMin.AutoSize = true;
            this.lblCpuUsageMin.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuUsageMin.Location = new System.Drawing.Point(883, 165);
            this.lblCpuUsageMin.Name = "lblCpuUsageMin";
            this.lblCpuUsageMin.Size = new System.Drawing.Size(71, 42);
            this.lblCpuUsageMin.TabIndex = 17;
            this.lblCpuUsageMin.Text = "- %";
            // 
            // lblCpuUsageMax
            // 
            this.lblCpuUsageMax.AutoSize = true;
            this.lblCpuUsageMax.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuUsageMax.Location = new System.Drawing.Point(265, 165);
            this.lblCpuUsageMax.Name = "lblCpuUsageMax";
            this.lblCpuUsageMax.Size = new System.Drawing.Size(71, 42);
            this.lblCpuUsageMax.TabIndex = 18;
            this.lblCpuUsageMax.Text = "- %";
            // 
            // gpCpu
            // 
            this.gpCpu.Controls.Add(this.panel3);
            this.gpCpu.Controls.Add(this.panel2);
            this.gpCpu.Controls.Add(this.label4);
            this.gpCpu.Controls.Add(this.label3);
            this.gpCpu.Controls.Add(this.label2);
            this.gpCpu.Controls.Add(this.label1);
            this.gpCpu.Controls.Add(this.lblCpuUsageMax);
            this.gpCpu.Controls.Add(this.lblCpuUsageMin);
            this.gpCpu.Controls.Add(this.lblCpuUsage);
            this.gpCpu.Controls.Add(this.lblCpuUsageAvg);
            this.gpCpu.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCpu.Location = new System.Drawing.Point(15, 56);
            this.gpCpu.Name = "gpCpu";
            this.gpCpu.Size = new System.Drawing.Size(1208, 260);
            this.gpCpu.TabIndex = 19;
            this.gpCpu.TabStop = false;
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
            this.label4.Location = new System.Drawing.Point(847, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "CPU Minimum Usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(848, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "CPU Average Usage";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "CPU Maximum Usage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "CPU Current Usage";
            // 
            // frmCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 695);
            this.Controls.Add(this.gpCpu);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrevious);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartCpuUsage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCpu";
            this.Text = "frmCpu";
            this.Load += new System.EventHandler(this.frmCpu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCpuUsage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.gpCpu.ResumeLayout(false);
            this.gpCpu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCpuUsageAvg;
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.Label lblCpuUsageMin;
        private System.Windows.Forms.Label lblCpuUsageMax;
        private System.Windows.Forms.GroupBox gpCpu;
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
        public System.Windows.Forms.DataVisualization.Charting.Chart chartCpuUsage;
    }
}