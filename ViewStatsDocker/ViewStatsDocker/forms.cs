
using System.Windows.Forms;

namespace ViewStatsDocker
{
    class forms
    {
        public static frmMain Frm_Main = new frmMain();
        public static frmHome Frm_Home = new frmHome();
        public static frmCpu Frm_Cpu = new frmCpu();
        public static frmMemory Frm_Memory = new frmMemory();
        public static frmLink Frm_Link = new frmLink();
        public static frmDisk Frm_Disk = new frmDisk();


        public static void Run()
        {
            Application.Run(Frm_Main);
        }
    }
}
