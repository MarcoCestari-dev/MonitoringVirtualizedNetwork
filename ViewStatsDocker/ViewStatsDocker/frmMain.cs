using ViewStatsDocker.Functions;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ViewStatsDocker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        protected bool maximize = false;

        #region Chiudere/Abbassare/Massimizzare Form
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Bordi Smussati
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion

        #region Spostare Form
        bool TogMove;
        int MValX;
        int MValY;

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - (MValX + 365), MousePosition.Y - MValY);
            }
        }
        #endregion


        private void frmMain_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20)); //Crea i bordi

            forms.Frm_Cpu.chartCpuUsage.ChartAreas[0].AxisY.Maximum = 100;
            forms.Frm_Cpu.chartCpuUsage.ChartAreas[0].AxisY.Minimum = 0;
            forms.Frm_Cpu.chartCpuUsage.ChartAreas[0].AxisX.Maximum = frmHome.chartLenght;
            forms.Frm_Cpu.chartCpuUsage.ChartAreas[0].AxisX.Minimum = 1;
            forms.Frm_Cpu.chartCpuUsage.Series["Cpu Usage"].Points.AddXY(1, 1);

            forms.Frm_Memory.chartMemUsage.ChartAreas[0].AxisY.Maximum = 50;
            forms.Frm_Memory.chartMemUsage.ChartAreas[0].AxisY.Minimum = 0;
            forms.Frm_Memory.chartMemUsage.ChartAreas[0].AxisX.Maximum = frmHome.chartLenght;
            forms.Frm_Memory.chartMemUsage.ChartAreas[0].AxisX.Minimum = 1;
            forms.Frm_Memory.chartMemUsage.Series["Memory Usage"].Points.AddXY(1, 1);

            forms.Frm_Link.chartLinkUsage.ChartAreas[0].AxisY.Maximum = 20;
            forms.Frm_Link.chartLinkUsage.ChartAreas[0].AxisY.Minimum = 0;
            forms.Frm_Link.chartLinkUsage.ChartAreas[0].AxisX.Maximum = frmHome.chartLenght;
            forms.Frm_Link.chartLinkUsage.ChartAreas[0].AxisX.Minimum = 1;
            forms.Frm_Link.chartLinkUsage.Series["Link Usage"].Points.AddXY(1, 1);

            forms.Frm_Disk.chartDiskUsage.ChartAreas[0].AxisY.Maximum = 5;
            forms.Frm_Disk.chartDiskUsage.ChartAreas[0].AxisY.Minimum = 0;
            forms.Frm_Disk.chartDiskUsage.ChartAreas[0].AxisX.Maximum = frmHome.chartLenght;
            forms.Frm_Disk.chartDiskUsage.ChartAreas[0].AxisX.Minimum = 1;
            forms.Frm_Disk.chartDiskUsage.Series["Disk Usage"].Points.AddXY(1, 1);

            changeTab.changeControlPanel("Home", forms.Frm_Home);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            changeTab.changeControlPanel("Home", forms.Frm_Home);
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            changeTab.changeControlPanel("Cpu | Stats", forms.Frm_Cpu);
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            changeTab.changeControlPanel("Memory | Stats", forms.Frm_Memory);
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            changeTab.changeControlPanel("Link | Stats", forms.Frm_Link);
        }

        private void btnDisk_Click(object sender, EventArgs e)
        {
            changeTab.changeControlPanel("Disk | Stats", forms.Frm_Disk);
        }

        private void pcCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Programma ideato e creato da:\n - Giada Figliolini (202121)\n - Marco Cestari (205306)\n - Alissya Valer (200593)",
                                   "Crediti Sviluppatori", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information,
                                   MessageBoxDefaultButton.Button1, 0);
        }
    }
}
