using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Process process = null;
            string batDir = string.Format(@"" + "C:\\Users\\wlk26\\Downloads\\一鍵架設 Discord 機器人 二代\\installed version");
            process = new Process();
            process.StartInfo.WorkingDirectory = batDir;
            process.StartInfo.FileName = "update";
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            Close();
        }
    }
}
