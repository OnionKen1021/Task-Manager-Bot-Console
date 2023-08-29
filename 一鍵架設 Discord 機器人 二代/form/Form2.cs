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
using System.IO;
using Newtonsoft.Json;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string filePath = "./config.json";
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);
            jsonObject["work"] = worktextbox.Text;
            jsonObject["file"] = filetextbox.Text;
            string modifiedJson = jsonObject.ToString();
            File.WriteAllText(filePath, modifiedJson);

            filePath = "./bot/config.json";
            jsonContent = File.ReadAllText(filePath);
            jsonObject = JObject.Parse(jsonContent);
            jsonObject["token"] = tokentextbox.Text;
            modifiedJson = jsonObject.ToString();
            File.WriteAllText(filePath, modifiedJson);

            MessageBox.Show("work: " + worktextbox.Text + "\n" + "file: " + filetextbox.Text + "\n" + "token: " + tokentextbox.Text);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
