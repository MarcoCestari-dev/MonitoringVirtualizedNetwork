
namespace ViewStatsDocker
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.logoPanel = new System.Windows.Forms.Panel();
            this.lblCredits = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnDisk = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnCpu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelCredits = new System.Windows.Forms.Panel();
            this.pcCredits = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblNamePanel = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.panelCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCredits)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(67)))), ((int)(((byte)(89)))));
            this.logoPanel.Controls.Add(this.lblCredits);
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Controls.Add(this.lblLogo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(365, 55);
            this.logoPanel.TabIndex = 0;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblCredits.Location = new System.Drawing.Point(84, 36);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(60, 16);
            this.lblCredits.TabIndex = 2;
            this.lblCredits.Text = "By G.M.A.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblLogo.Location = new System.Drawing.Point(78, 7);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(239, 30);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "View Stats : Docker";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.sidePanel.Controls.Add(this.btnDisk);
            this.sidePanel.Controls.Add(this.btnLink);
            this.sidePanel.Controls.Add(this.btnMemory);
            this.sidePanel.Controls.Add(this.btnCpu);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.panelCredits);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(365, 750);
            this.sidePanel.TabIndex = 6;
            // 
            // btnDisk
            // 
            this.btnDisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(97)))), ((int)(((byte)(119)))));
            this.btnDisk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisk.FlatAppearance.BorderSize = 0;
            this.btnDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisk.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDisk.Location = new System.Drawing.Point(0, 255);
            this.btnDisk.Name = "btnDisk";
            this.btnDisk.Size = new System.Drawing.Size(365, 50);
            this.btnDisk.TabIndex = 15;
            this.btnDisk.Text = "        Disk Usage | Stats";
            this.btnDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisk.UseVisualStyleBackColor = false;
            this.btnDisk.Click += new System.EventHandler(this.btnDisk_Click);
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(97)))), ((int)(((byte)(119)))));
            this.btnLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnLink.Location = new System.Drawing.Point(0, 205);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(365, 50);
            this.btnLink.TabIndex = 14;
            this.btnLink.Text = "        Link Usage | Stats";
            this.btnLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLink.UseVisualStyleBackColor = false;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(97)))), ((int)(((byte)(119)))));
            this.btnMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemory.FlatAppearance.BorderSize = 0;
            this.btnMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMemory.Location = new System.Drawing.Point(0, 155);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(365, 50);
            this.btnMemory.TabIndex = 13;
            this.btnMemory.Text = "        Memory RAM | Stats";
            this.btnMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // btnCpu
            // 
            this.btnCpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(97)))), ((int)(((byte)(119)))));
            this.btnCpu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCpu.FlatAppearance.BorderSize = 0;
            this.btnCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCpu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCpu.Location = new System.Drawing.Point(0, 105);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(365, 50);
            this.btnCpu.TabIndex = 12;
            this.btnCpu.Text = "        Cpu | Stats";
            this.btnCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpu.UseVisualStyleBackColor = false;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(97)))), ((int)(((byte)(119)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnHome.Location = new System.Drawing.Point(0, 55);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(365, 50);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "        Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelCredits
            // 
            this.panelCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(97)))), ((int)(((byte)(119)))));
            this.panelCredits.Controls.Add(this.pcCredits);
            this.panelCredits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCredits.Location = new System.Drawing.Point(0, 700);
            this.panelCredits.Name = "panelCredits";
            this.panelCredits.Size = new System.Drawing.Size(365, 50);
            this.panelCredits.TabIndex = 6;
            // 
            // pcCredits
            // 
            this.pcCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcCredits.Image = ((System.Drawing.Image)(resources.GetObject("pcCredits.Image")));
            this.pcCredits.Location = new System.Drawing.Point(12, 8);
            this.pcCredits.Name = "pcCredits";
            this.pcCredits.Size = new System.Drawing.Size(37, 37);
            this.pcCredits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCredits.TabIndex = 4;
            this.pcCredits.TabStop = false;
            this.pcCredits.Click += new System.EventHandler(this.pcCredits_Click);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.topPanel.Controls.Add(this.lblNamePanel);
            this.topPanel.Controls.Add(this.pbExit);
            this.topPanel.Controls.Add(this.pbMinimize);
            this.topPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.topPanel.Location = new System.Drawing.Point(365, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1235, 55);
            this.topPanel.TabIndex = 7;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // lblNamePanel
            // 
            this.lblNamePanel.AutoSize = true;
            this.lblNamePanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblNamePanel.Location = new System.Drawing.Point(23, 17);
            this.lblNamePanel.Name = "lblNamePanel";
            this.lblNamePanel.Size = new System.Drawing.Size(64, 22);
            this.lblNamePanel.TabIndex = 2;
            this.lblNamePanel.Text = "Home";
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1190, 10);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(35, 35);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 1;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(1154, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(32, 32);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 0;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.contentPanel.Location = new System.Drawing.Point(365, 55);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1235, 695);
            this.contentPanel.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 750);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.contentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Comparison";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.panelCredits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCredits)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pcCredits;
        public System.Windows.Forms.Panel contentPanel;
        public System.Windows.Forms.Label lblNamePanel;
        public System.Windows.Forms.Panel logoPanel;
        public System.Windows.Forms.Panel sidePanel;
        public System.Windows.Forms.Panel panelCredits;
        public System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbMinimize;
        public System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Button btnDisk;
        public System.Windows.Forms.Button btnLink;
        public System.Windows.Forms.Button btnMemory;
        public System.Windows.Forms.Button btnCpu;
    }
}

