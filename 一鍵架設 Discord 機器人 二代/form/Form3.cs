using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            string filePath = "./startup.json"; // 將路徑替換為你的JSON文件的實際路徑

            // 讀取JSON文件內容
            string jsonContent = File.ReadAllText(filePath);

            // 將JSON字串解析為JObject
            JObject jsonObject = JObject.Parse(jsonContent);

            if (ToggleSwitch1.Checked)
            {
                Button1.Text = "使用自帶系統: True";
                jsonObject["default_system"] = "True";
            }
            else
            {
                Button1.Text = "使用自帶系統: False";
                jsonObject["default_system"] = "False";
            }

            string modifiedJson = jsonObject.ToString();
            File.WriteAllText(filePath, modifiedJson);
        }

        private void ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            string filePath = "./startup.json"; // 將路徑替換為你的JSON文件的實際路徑

            // 讀取JSON文件內容
            string jsonContent = File.ReadAllText(filePath);

            // 將JSON字串解析為JObject
            JObject jsonObject = JObject.Parse(jsonContent);

            if (ToggleSwitch2.Checked)
            {
                Button2.Text = "啟動前確認值: True";
                jsonObject["save_startup"] = "True";
            }
            else
            {
                Button2.Text = "啟動前確認值: False";
                jsonObject["save_startup"] = "False";
            }

            string modifiedJson = jsonObject.ToString();
            File.WriteAllText(filePath, modifiedJson);
        }

        private void ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            string filePath = "./startup.json"; // 將路徑替換為你的JSON文件的實際路徑

            // 讀取JSON文件內容
            string jsonContent = File.ReadAllText(filePath);

            // 將JSON字串解析為JObject
            JObject jsonObject = JObject.Parse(jsonContent);

            if (ToggleSwitch3.Checked)
            {
                Button3.Text = "使用默認路徑: True";
                jsonObject["default_path"] = "True";
            }
            else
            {
                Button3.Text = "使用默認路徑: False";
                jsonObject["default_path"] = "False";
            }

            string modifiedJson = jsonObject.ToString();
            File.WriteAllText(filePath, modifiedJson);
        }
    }
}
