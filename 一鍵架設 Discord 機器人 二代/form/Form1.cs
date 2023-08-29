using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using 一鍵架設_Discord_機器人_二代.tips;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            CMDTextBox.Text += "【STARTUP】- 機器人配置確認中...\n";
            string filePath = "config.json";
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);
            string work = (string)jsonObject["work"];
            string file = (string)jsonObject["file"];
            try
            {
                Process process = null;
                string batDir = string.Format(@"" + work);
                process = new Process();
                process.StartInfo.WorkingDirectory = batDir;
                process.StartInfo.FileName = file;
                process.StartInfo.CreateNoWindow = false;
                process.Start();
                botsuccess a = new botsuccess();
                a.StartPosition = FormStartPosition.Manual;
                a.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - a.Width,
                                       Screen.PrimaryScreen.WorkingArea.Height - a.Height);

                a.Show();
                CMDTextBox.Text += "【STARTUP】- 機器人已成功運行!\n";
                Close();
            }
            catch
            {
                botdeny a = new botdeny();
                a.StartPosition = FormStartPosition.Manual;
                a.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - a.Width,
                                       Screen.PrimaryScreen.WorkingArea.Height - a.Height);

                a.Show();
                CMDTextBox.Text += "【ERROR】- 路徑或檔案名稱配置錯誤!\n";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void OK_Tick(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            writebat f = new writebat();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - f.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - f.Height);

            f.ShowDialog();
        }

        private void default_run_Click(object sender, EventArgs e)
        {
            writetoken f = new writetoken();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - f.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - f.Height);

            f.ShowDialog();
            CMDTextBox.Text += "【STARTUP】- 機器人配置確認中...\n";
            try
            {
                Process process = null;
                string batDir = string.Format(@"" + "./bot");
                process = new Process();
                process.StartInfo.WorkingDirectory = batDir;
                process.StartInfo.FileName = "一鍵啟動.bat";
                process.StartInfo.CreateNoWindow = false;
                process.Start();
                botsuccess af = new botsuccess();
                af.StartPosition = FormStartPosition.Manual;
                af.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - af.Width,
                                       Screen.PrimaryScreen.WorkingArea.Height - af.Height);

                af.Show();
                CMDTextBox.Text += "【STARTUP】- 機器人已成功運行!\n";
                Close();
            }
            catch
            {
                botdeny ae = new botdeny();
                ae.StartPosition = FormStartPosition.Manual;
                ae.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - ae.Width,
                                       Screen.PrimaryScreen.WorkingArea.Height - ae.Height);

                ae.Show();
                CMDTextBox.Text += "【ERROR】- 路徑或檔案名稱配置錯誤!\n";
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            CMDTextBox.Text = "";
        }
    }
}
