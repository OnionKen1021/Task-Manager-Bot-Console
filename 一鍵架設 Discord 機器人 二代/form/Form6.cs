﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class writetoken : Form
    {
        public writetoken()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            string filePath = "./bot/config.json";
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);
            jsonObject["token"] = token_set.Text;
            string modifiedJson = jsonObject.ToString();
            File.WriteAllText(filePath, modifiedJson);
            this.Hide();
            MessageBox.Show("已儲存所有設置項目資料!");
        }

        private void check_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
