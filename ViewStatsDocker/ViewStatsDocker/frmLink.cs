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
    public partial class frmLink : Form
    {
        public frmLink()
        {
            InitializeComponent();
        }

        public static bool stopMonitoring = false;
        public static int counter = 0;

        string LinkUsage;
        int firstCurrent = 0;
        int lastCurrent = 0;
        int numberOfValueObtained = 0;

        double LinkUsagePrevious = 0;
        double LinkUsageTotalOutput = 0;
        //double LinkUsageTotalInput = 0;

        double LinkUsageMaxOutput = 0;
        //double LinkUsageMaxInput = 0;

        double LinkUsageMinOutput = 0;
        //double LinkUsageMinInput = 0;


        List<double> LinkValues = new List<double>();

        private void asyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (stopMonitoring == false)
            {
                LinkUsage = Functions.cmdRequestAndReader.dockerConnecterLink();
                counter += 1;

                (sender as BackgroundWorker).ReportProgress(0);
            }

        }

        private void asyncWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Output
            String[] outputsFromBat = LinkUsage.ToString().Split('/');
            LinkUsageTotalOutput = Convert.ToDouble(outputsFromBat[1].Replace("kB", "").Replace("B", "").Replace(".", ","));

            double LinkUsageCurrent = LinkUsageTotalOutput - LinkUsagePrevious;

            LinkUsageCurrent = Math.Round(LinkUsageCurrent, 2);
            if (counter == 1 || LinkUsageCurrent < 0 || LinkUsagePrevious==0)
            {
                LinkUsageCurrent = 0;
            }

            if (counter == frmHome.chartLenght+1)
            {
                counter = 1;
                chartLinkUsage.Series["Link Usage"].Points.AddXY(counter, LinkUsageCurrent);
                chartLinkUsage.Series["Link Usage"].Points.Clear();

                forms.Frm_Home.chartLinkUsage.Series["Link Usage"].Points.AddXY(counter, LinkUsageCurrent);
                forms.Frm_Home.chartLinkUsage.Series["Link Usage"].Points.Clear();
            }

            chartLinkUsage.Series["Link Usage"].Points.AddXY(counter, LinkUsageCurrent);
            forms.Frm_Home.chartLinkUsage.Series["Link Usage"].Points.AddXY(counter, LinkUsageCurrent);

            numberOfValueObtained++;

            lblLinkUsage.Text = LinkUsageCurrent + " kB";
            lblLinkUsageTotal.Text = LinkUsageTotalOutput + " kB";

            if (LinkUsageCurrent < LinkUsageMinOutput) { LinkUsageMinOutput = LinkUsageCurrent; }
            lblLinkUsageMin.Text = LinkUsageMinOutput + " kB";

            if (LinkUsageCurrent > LinkUsageMaxOutput) { LinkUsageMaxOutput = LinkUsageCurrent; }
            lblLinkUsageMax.Text = LinkUsageMaxOutput + " kB";

            chartLinkUsage.ChartAreas[0].AxisY.Maximum = LinkUsageCurrent + 5;
            forms.Frm_Home.chartLinkUsage.ChartAreas[0].AxisY.Maximum = LinkUsageCurrent + 5;

            LinkValues.Add(LinkUsageCurrent);

            LinkUsagePrevious = LinkUsageTotalOutput;

            //// -------------------------------------------------

            //LinkUsageTotalInput = Convert.ToDouble(paths[0].Replace("MB", "").Replace("B", "").Replace(".", ","));

            //double LinkUsageCurrentInput = LinkUsageTotalOutput - LinkUsagePrevious;

            //if (counter == 1 || LinkUsageCurrent < 0 || LinkUsagePrevious == 0)
            //{
            //    LinkUsageCurrent = 0;
            //}

            //if (counter == frmHome.chartLenght + 1)
            //{
            //    counter = 1;
            //    chartLinkUsage.Series["Link Usage"].Points.AddXY(counter, LinkUsageCurrent);
            //    chartLinkUsage.Series["Link Usage"].Points.Clear();

            //    forms.Frm_Home.chartLinkUsage.Series["Link Usage"].Points.AddXY(counter, LinkUsageCurrent);
            //    forms.Frm_Home.chartLinkUsage.Series["Link Usage"].Points.Clear();
            //}

            //chartLinkUsage.Series["Link Usage"].Points.AddXY(counter, LinkUsageCurrent);
            //forms.Frm_Home.chartLinkUsage.Series["Link Usage"].Points.AddXY(counter, LinkUsageCurrent);


            //numberOfValueObtained++;

            //lblLinkUsage.Text = lblLinkUsage.Text + " / " + LinkUsageCurrent + " Kb";

            //lblLinkUsageTotal.Text = lblLinkUsageTotal.Text + " / " + LinkUsageTotalOutput + " kB";

            //if (LinkUsageCurrent < LinkUsageMinInput) { LinkUsageMinInput = LinkUsageCurrent; }
            //lblLinkUsageMin.Text = lblLinkUsageMin.Text + "/" + LinkUsageMinInput + " kB";

            //if (LinkUsageCurrent > LinkUsageMaxInput) { LinkUsageMaxInput = LinkUsageCurrent; }
            //lblLinkUsageMax.Text = lblLinkUsageMax.Text + "/" + LinkUsageMaxInput + " kB";

            //chartLinkUsage.ChartAreas[0].AxisY.Maximum = LinkUsageCurrent + 5;
            //forms.Frm_Home.chartLinkUsage.ChartAreas[0].AxisY.Maximum = LinkUsageCurrent + 5;

            //LinkValues.Add(LinkUsageCurrent);

            //LinkUsagePrevious = LinkUsageTotalOutput;
        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            btnStartMonitoring.Enabled = false;

            stopMonitoring = false;
            asyncWorker.WorkerReportsProgress = true;
            counter = 0;
            asyncWorker.RunWorkerAsync();

            chartLinkUsage.Series["Link Usage"].Points.Clear();
            chartLinkUsage.Series["Link Usage"].Points.AddXY(1, 1);

            btnStopMonitoring.Enabled = true;
        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            btnStopMonitoring.Enabled = false;

            stopMonitoring = true;
            pbPrevious.Enabled = true;

            btnStartMonitoring.Enabled = true;
        }

        private void frmLink_Load(object sender, EventArgs e)
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

                chartLinkUsage.Series["Link Usage"].Points.Clear();

                int index = 1;
                for (int i = firstCurrent; i < lastCurrent; i++)
                {
                    chartLinkUsage.Series["Link Usage"].Points.AddXY(index, LinkValues[i]);
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


                chartLinkUsage.Series["Link Usage"].Points.Clear();

                int index = 1;
                for (int i = firstCurrent; i < lastCurrent; i++)
                {
                    chartLinkUsage.Series["Link Usage"].Points.AddXY(index, LinkValues[i]);
                    index++;
                }
            }
        }
    }
}
