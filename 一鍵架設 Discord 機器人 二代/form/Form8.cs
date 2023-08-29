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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void su_discord_Click_1(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://discord.gg/NFNPjMMFWW");
        }

        private void vs_Click_1(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://visualstudio.microsoft.com/zh-hant/downloads/");
        }

        private void ot_guna_Click_1(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://gunaui.com/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float Fcpu = fcpu.NextValue();
            float Fram = fram.NextValue();
            float rdisk = RDisk.NextValue();
            ProgressBarCPU.Value = (int)Fcpu;
            ProgressBarRAM.Value = (int)Fram;
            ProgressBarDISK.Value = (int)rdisk;
        }
    }
}
