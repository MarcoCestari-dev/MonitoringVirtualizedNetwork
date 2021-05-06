using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ViewStatsDocker.Functions
{
    class cmdRequestAndReader
    {

        public static int lineCount = 0;
        public static string cpu;
        public static string mem;
        public static string link;
        public static string disk;

        public static double dockerConnecterCpu()
        {
            Process process = new Process();
            process.StartInfo.FileName = Application.StartupPath + "//cpu.bat";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    cpu = e.Data.ToString();
                }
            });

            process.Start();

            process.BeginOutputReadLine();
            process.WaitForExit();

            process.Close();

            cpu = cpu.Replace("MiB", "").Replace(".", ",").Replace("/", "").Replace("983,2", "").Replace("%", "");
            if (IsNumeric(cpu) == false) { cpu = "0"; }

            return Math.Round(Convert.ToDouble(cpu));
        }

        public static double dockerConnecterMem()
        {
            Process process = new Process();
            process.StartInfo.FileName = Application.StartupPath + "//mem.bat";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    mem = e.Data.ToString();
                }
            });

            process.Start();

            process.BeginOutputReadLine();
            process.WaitForExit();

            process.Close();

            mem = mem.Replace("MiB", "").Replace(".", ",").Replace("/", "").Replace("983,2", "").Replace("%", "");
            if (IsNumeric(mem) == false) { mem = "0"; }

            return Math.Round(Convert.ToDouble(mem));
        }

        public static string dockerConnecterLink()
        {
            Process process = new Process();
            process.StartInfo.FileName = Application.StartupPath + "//link.bat";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    link = e.Data.ToString();
                }
            });

            process.Start();

            process.BeginOutputReadLine();
            process.WaitForExit();

            process.Close();    

            return link;
        }

        public static string dockerConnecterDisk()
        {
            Process process = new Process();
            process.StartInfo.FileName = Application.StartupPath + "//disk.bat";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    disk = e.Data.ToString();
                }
            });

            process.Start();

            process.BeginOutputReadLine();
            process.WaitForExit();

            process.Close();

            return disk;
        }

        public static bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }
    }
}
