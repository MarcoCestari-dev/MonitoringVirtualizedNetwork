using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewStatsDocker
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        public static int chartLenght = 20;

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            btnStartMonitoring.Enabled = false;
            forms.Frm_Cpu.btnStartMonitoring.Enabled = false;
            forms.Frm_Memory.btnStartMonitoring.Enabled = false;
            forms.Frm_Link.btnStartMonitoring.Enabled = false;
            forms.Frm_Disk.btnStartMonitoring.Enabled = false;


            #region CPU
            frmCpu.stopMonitoring = false;
            frmCpu.counter = 0;

            forms.Frm_Cpu.asyncWorker.WorkerReportsProgress = true;
            forms.Frm_Cpu.asyncWorker.RunWorkerAsync();

            chartCpuUsage.Series["Cpu Usage"].Points.Clear();
            chartCpuUsage.Series["Cpu Usage"].Points.AddXY(1, 1);
            #endregion

            #region Memory
            frmMemory.stopMonitoring = false;
            frmMemory.counter = 0;

            forms.Frm_Memory.asyncWorker.WorkerReportsProgress = true;
            forms.Frm_Memory.asyncWorker.RunWorkerAsync();

            chartMemoryUsage.Series["Memory Usage"].Points.Clear();
            chartMemoryUsage.Series["Memory Usage"].Points.AddXY(1, 1);
            #endregion

            #region Link
            frmLink.stopMonitoring = false;
            frmLink.counter = 0;

            forms.Frm_Link.asyncWorker.WorkerReportsProgress = true;
            forms.Frm_Link.asyncWorker.RunWorkerAsync();

            chartLinkUsage.Series["Link Usage"].Points.Clear();
            chartLinkUsage.Series["Link Usage"].Points.AddXY(1, 1);
            #endregion

            #region Disk
            frmDisk.stopMonitoring = false;
            frmDisk.counter = 0;

            forms.Frm_Disk.asyncWorker.WorkerReportsProgress = true;
            forms.Frm_Disk.asyncWorker.RunWorkerAsync();

            chartDiskUsage.Series["Disk Usage"].Points.Clear();
            chartDiskUsage.Series["Disk Usage"].Points.AddXY(1, 1);
            #endregion

            btnStopMonitoring.Enabled = true;
            forms.Frm_Cpu.btnStopMonitoring.Enabled = true;
            forms.Frm_Memory.btnStopMonitoring.Enabled = true;
            forms.Frm_Link.btnStopMonitoring.Enabled = true;
            forms.Frm_Disk.btnStopMonitoring.Enabled = true;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            #region CPU
            chartCpuUsage.ChartAreas[0].AxisY.Maximum = 100;
            chartCpuUsage.ChartAreas[0].AxisY.Minimum = 0;

            chartCpuUsage.ChartAreas[0].AxisX.Maximum = chartLenght;
            chartCpuUsage.ChartAreas[0].AxisX.Minimum = 1;

            chartCpuUsage.Series["Cpu Usage"].Points.AddXY(1, 1);
            #endregion

            #region Memory
            chartMemoryUsage.ChartAreas[0].AxisY.Maximum = 40;
            chartMemoryUsage.ChartAreas[0].AxisY.Minimum = 0;

            chartMemoryUsage.ChartAreas[0].AxisX.Maximum = chartLenght;
            chartMemoryUsage.ChartAreas[0].AxisX.Minimum = 1;

            chartMemoryUsage.Series["Memory Usage"].Points.AddXY(1, 1);
            #endregion

            #region Link
            chartLinkUsage.ChartAreas[0].AxisY.Maximum = 20;
            chartLinkUsage.ChartAreas[0].AxisY.Minimum = 0;

            chartLinkUsage.ChartAreas[0].AxisX.Maximum = chartLenght;
            chartLinkUsage.ChartAreas[0].AxisX.Minimum = 1;

            chartLinkUsage.Series["Link Usage"].Points.AddXY(1, 1);
            #endregion

            #region Disk
            chartDiskUsage.ChartAreas[0].AxisY.Maximum = 5;
            chartDiskUsage.ChartAreas[0].AxisY.Minimum = 0;

            chartDiskUsage.ChartAreas[0].AxisX.Maximum = chartLenght;
            chartDiskUsage.ChartAreas[0].AxisX.Minimum = 1;

            chartDiskUsage.Series["Disk Usage"].Points.AddXY(1, 1);
            #endregion

        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            btnStopMonitoring.Enabled = false;
            forms.Frm_Cpu.btnStopMonitoring.Enabled = false;
            forms.Frm_Memory.btnStopMonitoring.Enabled = false;
            forms.Frm_Link.btnStopMonitoring.Enabled = false;
            forms.Frm_Disk.btnStopMonitoring.Enabled = false;


            frmCpu.stopMonitoring = true;
            frmMemory.stopMonitoring = true;
            frmLink.stopMonitoring = true;
            frmDisk.stopMonitoring = true;

            forms.Frm_Cpu.pbPrevious.Enabled = true;
            forms.Frm_Memory.pbPrevious.Enabled = true;
            forms.Frm_Link.pbPrevious.Enabled = true;
            forms.Frm_Disk.pbPrevious.Enabled = true;

            btnStartMonitoring.Enabled = true;
            forms.Frm_Cpu.btnStartMonitoring.Enabled = true;
            forms.Frm_Memory.btnStartMonitoring.Enabled = true;
            forms.Frm_Link.btnStartMonitoring.Enabled = true;
            forms.Frm_Disk.btnStartMonitoring.Enabled = true;
        }
    }
}
