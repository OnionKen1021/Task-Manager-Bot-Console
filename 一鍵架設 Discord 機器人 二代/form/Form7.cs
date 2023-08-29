using Newtonsoft.Json.Linq;
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
using System.IO;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
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

                Close();
            }
            catch
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var myForm = new writebat();
            myForm.Show();
        }

        private void default_run_Click(object sender, EventArgs e)
        {
            var myForm = new writetoken();
            myForm.ShowDialog();

            try
            {
                Process process = null;
                string batDir = string.Format(@"" + "./bot");
                process = new Process();
                process.StartInfo.WorkingDirectory = batDir;
                process.StartInfo.FileName = "一鍵啟動.bat";
                process.StartInfo.CreateNoWindow = false;
                process.Start();
                Close();
            }
            catch
            {

            }
        }
    }
}
