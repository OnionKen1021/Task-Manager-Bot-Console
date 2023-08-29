using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 一鍵架設_Discord_機器人_二代.tips;

namespace 一鍵架設_Discord_機器人_二代.form
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {

            loadthread a = new loadthread();
            a.StartPosition = FormStartPosition.Manual;
            a.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - a.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - a.Height);
            a.Show();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value++;
            label1.Text = "Loading...... " + ProgressBar1.Value + "%";
            if (ProgressBar1.Value == 100)
            {
                this.Hide();
                var myForm = new main();
                loadthread a = new loadthread();
                myForm.Show();
                a.Hide();
                timer1.Stop();
            }

        }
    }
}
