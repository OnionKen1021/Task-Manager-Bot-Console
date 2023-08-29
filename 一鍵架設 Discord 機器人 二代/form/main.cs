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
using 一鍵架設_Discord_機器人_二代.form;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;
using 一鍵架設_Discord_機器人_二代.tips;

namespace 一鍵架設_Discord_機器人_二代
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            button1_act.FillColor = Color.FromArgb(216, 254, 249);
            button2_act.FillColor = Color.Transparent;
            button3_act.FillColor = Color.Transparent;
            button4_act.FillColor = Color.Transparent;
            button5_act.FillColor = Color.Transparent;
            button6_act.FillColor = Color.Transparent;

            loadform(new Form1());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button1_act.FillColor = Color.Transparent;
            button2_act.FillColor = Color.FromArgb(216, 254, 249);
            button3_act.FillColor = Color.Transparent;
            button4_act.FillColor = Color.Transparent;
            button5_act.FillColor = Color.Transparent;
            button6_act.FillColor = Color.Transparent;

            loadform(new Form2());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button1_act.FillColor = Color.Transparent;
            button2_act.FillColor = Color.Transparent;
            button3_act.FillColor = Color.FromArgb(216, 254, 249);
            button4_act.FillColor = Color.Transparent;
            button5_act.FillColor = Color.Transparent;
            button6_act.FillColor = Color.Transparent;

            loadform(new Form3());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button1_act.FillColor = Color.Transparent;
            button2_act.FillColor = Color.Transparent;
            button3_act.FillColor = Color.Transparent;
            button4_act.FillColor = Color.FromArgb(216, 254, 249);
            button5_act.FillColor = Color.Transparent;
            button6_act.FillColor = Color.Transparent;

            loadform(new Form4());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button1_act.FillColor = Color.Transparent;
            button2_act.FillColor = Color.Transparent;
            button3_act.FillColor = Color.Transparent;
            button4_act.FillColor = Color.Transparent;
            button5_act.FillColor = Color.FromArgb(216, 254, 249);
            button6_act.FillColor = Color.Transparent;

            loadform(new Form7());
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button1_act.FillColor = Color.Transparent;
            button2_act.FillColor = Color.Transparent;
            button3_act.FillColor = Color.Transparent;
            button4_act.FillColor = Color.Transparent;
            button5_act.FillColor = Color.Transparent;
            button6_act.FillColor = Color.FromArgb(216, 254, 249);

            settings a = new settings();
            a.StartPosition = FormStartPosition.Manual;
            a.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - a.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - a.Height);
            a.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            loadform(new Form8());

            botrunning a = new botrunning();
            a.StartPosition = FormStartPosition.Manual;
            a.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - a.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - a.Height);

            a.Show();
            timer1.Start();
            try
            {
                string filePath = "config.json";
                string jsonContent = File.ReadAllText(filePath);
                JObject jsonObject = JObject.Parse(jsonContent);
                string run = (string)jsonObject["run"];

                if (run == "OK")
                {

                }
                else
                {
                    var myForm = new license();
                    myForm.Show();
                }
            }
            catch
            {
                var myForm = new license();
                myForm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void notifyIcon_MouseLeftClick(object sender, MouseEventArgs e)
        {
            var myForm = new license();
            myForm.Show();
        }
    }
}
