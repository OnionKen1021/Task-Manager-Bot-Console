using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static class WindowsCmdCommand
        {
            public static void Run(string command, out string output, out string error, string directory = null)
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true,
                        Arguments = "/c " + command,
                        CreateNoWindow = true,
                        WorkingDirectory = directory ?? string.Empty,
                    }
                };
                process.Start();
                process.WaitForExit();
                output = process.StandardOutput.ReadToEnd();
                error = process.StandardError.ReadToEnd();
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            WindowsCmdCommand.Run(guna2TextBox1.Text, out string output, out string error);
            CMDTextBox.Text += output;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WindowsCmdCommand.Run("dir", out string output, out string error);
            CMDTextBox.Text += output;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WindowsCmdCommand.Run("pip -V", out string output, out string error);
            CMDTextBox.Text += output;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            WindowsCmdCommand.Run("pip list", out string output, out string error);
            CMDTextBox.Text += output;
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            CMDTextBox.Text = "";
        }
    }
}
