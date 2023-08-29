using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 一鍵架設_Discord_機器人_二代.tips
{
    public partial class botdeny : Form
    {
        public botdeny()
        {
            InitializeComponent();
        }

        private void botdeny_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value++;
            label1.Text = "Closing...... " + ProgressBar1.Value + "%";
            if (ProgressBar1.Value == 100)
            {
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
