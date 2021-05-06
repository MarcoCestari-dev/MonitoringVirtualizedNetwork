using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewStatsDocker.Functions
{
    class changeTab
    {
        public static void changeControlPanel(string Str, Form Frm)
        {
            forms.Frm_Main.lblNamePanel.Text = Str;
            forms.Frm_Main.contentPanel.Controls.Clear();
            Frm.TopLevel = false;
            Frm.AutoScroll = true;
            forms.Frm_Main.contentPanel.Controls.Add(Frm);

            Frm.Dock = DockStyle.Fill;
            Frm.Show();
        }

        public static void openImageForm(string imagePath)
        {
            forms.Frm_Main.Enabled = false;
            //forms.Frm_ViewImage.pbBiggerImage.Image = Image.FromFile(imagePath);
            //forms.Frm_ViewImage.lblPath.Text = imagePath;
            //forms.Frm_ViewImage.Show();
        }
    }
}
