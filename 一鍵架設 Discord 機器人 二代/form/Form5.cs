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
using Newtonsoft.Json.Linq;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class writebat : Form
    {
        public writebat()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void check_Click(object sender, EventArgs e)
        {
            string filePath = "./config.json";
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);
            jsonObject["work"] = path_set.Text;
            jsonObject["file"] = file_set.Text;
            string modifiedJson = jsonObject.ToString();
            File.WriteAllText(filePath, modifiedJson);

            string bat = "@echo off\r\ncmd /k py "+file_set.Text+".py";
            string file_name = path_set.Text + @"\" + file_set.Text + ".bat";
            File.WriteAllText(file_name, bat, Encoding.GetEncoding(936));
            this.Hide();
            MessageBox.Show("已儲存所有設置項目資料!");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
