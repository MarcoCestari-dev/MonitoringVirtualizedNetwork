using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewStatsDocker
{
    public partial class frmCpu : Form
    {
        public frmCpu()
        {
            InitializeComponent();
        }

        public static bool stopMonitoring = false;
        public static int counter = 0;

        double cpuUsage;
        int firstCurrent = 0;
        int lastCurrent = 0;
        int numberOfValueObtained = 0;

        

        int cpuUsageCurrent = 0;
        int cpuUsageAvgSum = 0;
        int cpuUsageMax = 0;
        int cpuUsageMin = 0;

        List<double> cpuValues = new List<double>();

        private void asyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (stopMonitoring == false)
            {
                cpuUsage = Functions.cmdRequestAndReader.dockerConnecterCpu();
                counter += 1;

                (sender as BackgroundWorker).ReportProgress(0);
            }

        }

        private void asyncWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (cpuUsage <= 1) { cpuUsage = 1; }
            if (cpuUsage > 100) { cpuUsage = 100; }

            if (counter == frmHome.chartLenght+1)
            {
                counter = 1;
                chartCpuUsage.Series["Cpu Usage"].Points.AddXY(counter, cpuUsage);
                chartCpuUsage.Series["Cpu Usage"].Points.Clear();

                forms.Frm_Home.chartCpuUsage.Series["Cpu Usage"].Points.AddXY(counter, cpuUsage);
                forms.Frm_Home.chartCpuUsage.Series["Cpu Usage"].Points.Clear();
            }
            chartCpuUsage.Series["Cpu Usage"].Points.AddXY(counter, cpuUsage);
            forms.Frm_Home.chartCpuUsage.Series["Cpu Usage"].Points.AddXY(counter, cpuUsage);
            

            cpuValues.Add(cpuUsage);
            numberOfValueObtained++;
            lastCurrent = numberOfValueObtained;

            cpuUsageCurrent = Convert.ToInt32(cpuUsage);

            lblCpuUsage.Text = cpuUsageCurrent + "%";
            cpuUsageAvgSum = cpuUsageAvgSum + cpuUsageCurrent;
            lblCpuUsageAvg.Text = cpuUsageAvgSum/numberOfValueObtained + "%";

            if (cpuUsageCurrent < cpuUsageMin) { cpuUsageMin = cpuUsageCurrent; }
            lblCpuUsageMin.Text = cpuUsageMin + "%";

            if (cpuUsageCurrent > cpuUsageMax) { cpuUsageMax = cpuUsageCurrent; }
            lblCpuUsageMax.Text = cpuUsageMax + "%";

        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            btnStartMonitoring.Enabled = false;

            stopMonitoring = false;
            asyncWorker.WorkerReportsProgress = true;
            counter = 0;
            asyncWorker.RunWorkerAsync();

            chartCpuUsage.Series["Cpu Usage"].Points.Clear();
            chartCpuUsage.Series["Cpu Usage"].Points.AddXY(1, 1);

            btnStopMonitoring.Enabled = true;
        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            btnStopMonitoring.Enabled = false;
            stopMonitoring = true;
            pbPrevious.Enabled = true;
            btnStartMonitoring.Enabled = true;
        }

        private void frmCpu_Load(object sender, EventArgs e)
        {

        }

        private void pbPrevious_Click(object sender, EventArgs e)
        {
            if (numberOfValueObtained> frmHome.chartLenght)
            {
                lastCurrent = lastCurrent - frmHome.chartLenght;
                firstCurrent = lastCurrent - frmHome.chartLenght;

                if (firstCurrent < 0) { firstCurrent = 0; }
                if (lastCurrent < frmHome.chartLenght) { lastCurrent = frmHome.chartLenght; }

                chartCpuUsage.Series["Cpu Usage"].Points.Clear();

                int index = 1;
                for (int i = firstCurrent; i < lastCurrent; i++)
                {
                    chartCpuUsage.Series["Cpu Usage"].Points.AddXY(index, cpuValues[i]);
                    index++;
                }

                pbNext.Enabled = true;
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (numberOfValueObtained > frmHome.chartLenght)
            {
                firstCurrent += frmHome.chartLenght;
                lastCurrent = firstCurrent + frmHome.chartLenght;

                if (firstCurrent > numberOfValueObtained - frmHome.chartLenght) { firstCurrent = numberOfValueObtained - frmHome.chartLenght; }
                if (lastCurrent > numberOfValueObtained) { lastCurrent = numberOfValueObtained; }


                chartCpuUsage.Series["Cpu Usage"].Points.Clear();

                int index = 1;
                for (int i = firstCurrent; i < lastCurrent; i++)
                {
                    chartCpuUsage.Series["Cpu Usage"].Points.AddXY(index, cpuValues[i]);
                    index++;
                }
            }
        }
    }
}
