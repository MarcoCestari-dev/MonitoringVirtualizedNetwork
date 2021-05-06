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
    public partial class frmMemory : Form
    {
        public frmMemory()
        {
            InitializeComponent();
        }

        public static bool stopMonitoring = false;
        public static int counter = 0;

        double memUsage;
        int firstCurrent = 0;
        int lastCurrent = 0;
        int numberOfValueObtained = 0;

        

        int memUsageCurrent = 0;
        int memUsageAvgSum = 0;
        int memUsageMax = 0;
        int memUsageMin = 0;

        List<double> memValues = new List<double>();

        private void asyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (stopMonitoring == false)
            {
                memUsage = Functions.cmdRequestAndReader.dockerConnecterMem();
                counter += 1;

                (sender as BackgroundWorker).ReportProgress(0);
            }

        }

        private void asyncWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (counter == frmHome.chartLenght+1)
            {
                counter = 1;
                chartMemUsage.Series["Memory Usage"].Points.AddXY(counter, memUsage);
                chartMemUsage.Series["Memory Usage"].Points.Clear();

                forms.Frm_Home.chartMemoryUsage.Series["Memory Usage"].Points.AddXY(counter, memUsage);
                forms.Frm_Home.chartMemoryUsage.Series["Memory Usage"].Points.Clear();
            }
            chartMemUsage.Series["Memory Usage"].Points.AddXY(counter, memUsage);
            forms.Frm_Home.chartMemoryUsage.Series["Memory Usage"].Points.AddXY(counter, memUsage);


            memValues.Add(memUsage);
            numberOfValueObtained++;
            lastCurrent = numberOfValueObtained;

            memUsageCurrent = Convert.ToInt32(memUsage);

            lblMemUsage.Text = memUsageCurrent + " MiB";
            memUsageAvgSum = memUsageAvgSum + memUsageCurrent;
            lblMemUsageAvg.Text = memUsageAvgSum / numberOfValueObtained + " MiB";

            if (memUsageCurrent < memUsageMin) { memUsageMin = memUsageCurrent; }
            lblMemUsageMin.Text = memUsageMin + " MiB";

            if (memUsageCurrent > memUsageMax) { memUsageMax = memUsageCurrent; }
            lblMemUsageMax.Text = memUsageMax + " MiB";

            chartMemUsage.ChartAreas[0].AxisY.Maximum = memUsageMax + 10;
            forms.Frm_Home.chartMemoryUsage.ChartAreas[0].AxisY.Maximum = memUsageMax + 10;


        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            btnStartMonitoring.Enabled = false;

            stopMonitoring = false;
            asyncWorker.WorkerReportsProgress = true;
            counter = 0;
            asyncWorker.RunWorkerAsync();

            chartMemUsage.Series["Memory Usage"].Points.Clear();
            chartMemUsage.Series["Memory Usage"].Points.AddXY(1, 1);

            btnStopMonitoring.Enabled = true;
        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            btnStopMonitoring.Enabled = false;

            stopMonitoring = true;
            pbPrevious.Enabled = true;

            btnStartMonitoring.Enabled = true;
        }

        private void frmMem_Load(object sender, EventArgs e)
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

                chartMemUsage.Series["Memory Usage"].Points.Clear();

                int index = 1;
                for (int i = firstCurrent; i < lastCurrent; i++)
                {
                    chartMemUsage.Series["Memory Usage"].Points.AddXY(index, memValues[i]);
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


                chartMemUsage.Series["Memory Usage"].Points.Clear();

                int index = 1;
                for (int i = firstCurrent; i < lastCurrent; i++)
                {
                    chartMemUsage.Series["Memory Usage"].Points.AddXY(index, memValues[i]);
                    index++;
                }
            }
        }
    }
}
