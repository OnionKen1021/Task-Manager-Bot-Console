using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class license : Form
    {
        public license()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string filePath = "config.json";
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);
            jsonObject["run"] = "OK";
            string modifiedJson = jsonObject.ToString();
            File.WriteAllText(filePath, modifiedJson);
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://discord.gg/NFNPjMMFWW");
        }
    }
}
