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
    public partial class frmDisk : Form
    {
        public frmDisk()
        {
            InitializeComponent();
        }

        public static bool stopMonitoring = false;
        public static int counter = 0;

        string DiskUsage;
        int firstCurrent = 0;
        int lastCurrent = 0;
        int numberOfValueObtained = 0;

        double DiskUsagePrevious = 0;
        double DiskUsageTotalOutput = 0;
        //double DiskUsageTotalInput = 0;

        double DiskUsageMaxOutput = 0;
        //double DiskUsageMaxInput = 0;

        double DiskUsageMinOutput = 0;
        //double DiskUsageMinInput = 0;


        List<double> DiskValues = new List<double>();

        private void asyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (stopMonitoring == false)
            {
                DiskUsage = Functions.cmdRequestAndReader.dockerConnecterDisk();
                counter += 1;

                (sender as BackgroundWorker).ReportProgress(0);
            }

        }

        private void asyncWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Output
            String[] outputsFromBat = DiskUsage.ToString().Split('/');
            DiskUsageTotalOutput = Convert.ToDouble(outputsFromBat[0].Replace("kB", "").Replace(".", ",").Replace("MB", "").Replace("B", ""));

            double DiskUsageCurrent = DiskUsageTotalOutput - DiskUsagePrevious;

            if (counter == 1 || DiskUsageCurrent < 0 || DiskUsagePrevious==0)
            {
                DiskUsageCurrent = 0;
            }

            if (counter == frmHome.chartLenght+1)
            {
                counter = 1;
                chartDiskUsage.Series["Disk Usage"].Points.AddXY(counter, DiskUsageCurrent);
                chartDiskUsage.Series["Disk Usage"].Points.Clear();

                forms.Frm_Home.chartDiskUsage.Series["Disk Usage"].Points.AddXY(counter, DiskUsageCurrent);
                forms.Frm_Home.chartDiskUsage.Series["Disk Usage"].Points.Clear();
            }

            chartDiskUsage.Series["Disk Usage"].Points.AddXY(counter, DiskUsageCurrent);
            forms.Frm_Home.chartDiskUsage.Series["Disk Usage"].Points.AddXY(counter, DiskUsageCurrent);

            numberOfValueObtained++;

            lblDiskUsage.Text = DiskUsageCurrent + " kB";
            lblDiskUsageTotal.Text = DiskUsageTotalOutput + " MB";

            if (DiskUsageCurrent < DiskUsageMinOutput) { DiskUsageMinOutput = DiskUsageCurrent; }
            lblDiskUsageMin.Text = DiskUsageMinOutput + " kB";

            if (DiskUsageCurrent > DiskUsageMaxOutput) { DiskUsageMaxOutput = DiskUsageCurrent; }
            lblDiskUsageMax.Text = DiskUsageMaxOutput + " kB";

            chartDiskUsage.ChartAreas[0].AxisY.Maximum = DiskUsageCurrent + 5;
            forms.Frm_Home.chartDiskUsage.ChartAreas[0].AxisY.Maximum = DiskUsageCurrent + 5;

            DiskValues.Add(DiskUsageCurrent);

            DiskUsagePrevious = DiskUsageTotalOutput;

            //// -------------------------------------------------

            //DiskUsageTotalInput = Convert.ToDouble(paths[0].Replace("MB", "").Replace("B", "").Replace(".", ","));

            //double DiskUsageCurrentInput = DiskUsageTotalOutput - DiskUsagePrevious;

            //if (counter == 1 || DiskUsageCurrent < 0 || DiskUsagePrevious == 0)
            //{
            //    DiskUsageCurrent = 0;
            //}

            //if (counter == frmHome.chartLenght + 1)
            //{
            //    counter = 1;
            //    chartDiskUsage.Series["Disk Usage"].Points.AddXY(counter, DiskUsageCurrent);
            //    chartDiskUsage.Series["Disk Usage"].Points.Clear();

            //    forms.Frm_Home.chartDiskUsage.Series["Disk Usage"].Points.AddXY(counter, DiskUsageCurrent);
            //    forms.Frm_Home.chartDiskUsage.Series["Disk Usage"].Points.Clear();
            //}

            //chartDiskUsage.Series["Disk Usage"].Points.AddXY(counter, DiskUsageCurrent);
            //forms.Frm_Home.chartDiskUsage.Series["Disk Usage"].Points.AddXY(counter, DiskUsageCurrent);


            //numberOfValueObtained++;

            //lblDiskUsage.Text = lblDiskUsage.Text + " / " + DiskUsageCurrent + " Kb";

            //lblDiskUsageTotal.Text = lblDiskUsageTotal.Text + " / " + DiskUsageTotalOutput + " kB";

            //if (DiskUsageCurrent < DiskUsageMinInput) { DiskUsageMinInput = DiskUsageCurrent; }
            //lblDiskUsageMin.Text = lblDiskUsageMin.Text + "/" + DiskUsageMinInput + " kB";

            //if (DiskUsageCurrent > DiskUsageMaxInput) { DiskUsageMaxInput = DiskUsageCurrent; }
            //lblDiskUsageMax.Text = lblDiskUsageMax.Text + "/" + DiskUsageMaxInput + " kB";

            //chartDiskUsage.ChartAreas[0].AxisY.Maximum = DiskUsageCurrent + 5;
            //forms.Frm_Home.chartDiskUsage.ChartAreas[0].AxisY.Maximum = DiskUsageCurrent + 5;

            //DiskValues.Add(DiskUsageCurrent);

            //DiskUsagePrevious = DiskUsageTotalOutput;
        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            btnStartMonitoring.Enabled = false;

            stopMonitoring = false;
            asyncWorker.WorkerReportsProgress = true;
            counter = 0;
            asyncWorker.RunWorkerAsync();

            chartDiskUsage.Series["Disk Usage"].Points.Clear();
            chartDiskUsage.Series["Disk Usage"].Points.AddXY(1, 1);

            btnStopMonitoring.Enabled = true;
        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            btnStopMonitoring.Enabled = false;

            stopMonitoring = true;
            pbPrevious.Enabled = true;

            btnStartMonitoring.Enabled = true;
        }

        private void frmDisk_Load(object sender, EventArgs e)
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

                chartDiskUsage.Series["Disk Usage"].Points.Clear();

                int index = 1;
                for (int i = firstCurrent; i < lastCurrent; i++)
                {
                    chartDiskUsage.Series["Disk Usage"].Points.AddXY(index, DiskValues[i]);
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


                chartDiskUsage.Series["Disk Usage"].Points.Clear();

                int index = 1;
                for (int i = firstCurrent; i < lastCurrent; i++)
                {
                    chartDiskUsage.Series["Disk Usage"].Points.AddXY(index, DiskValues[i]);
                    index++;
                }
            }
        }
    }
}
