namespace 一鍵架設_Discord_機器人_二代.form
{
    partial class loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task Manager V3 - Loading";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(610, 20);
            this.guna2Panel1.TabIndex = 33;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ProgressBar1.Location = new System.Drawing.Point(160, 130);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.ProgressBar1.Size = new System.Drawing.Size(246, 10);
            this.ProgressBar1.TabIndex = 34;
            this.ProgressBar1.Text = "ProgressBar1";
            this.ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Elipse1
            // 
            this.Elipse1.TargetControl = this;
            // 
            // Elipse2
            // 
            this.Elipse2.BorderRadius = 3;
            this.Elipse2.TargetControl = this.ProgressBar1;
            // 
            // DragControl1
            // 
            this.DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1.TargetControl = this;
            this.DragControl1.UseTransparentDrag = true;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.guna2Panel1;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // DragControl3
            // 
            this.DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl3.TargetControl = this.label3;
            this.DragControl3.UseTransparentDrag = true;
            // 
            // DragControl4
            // 
            this.DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl4.TargetControl = this.ProgressBar1;
            this.DragControl4.UseTransparentDrag = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(161, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loading......";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("hooge 05_55", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(158, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 34);
            this.label4.TabIndex = 36;
            this.label4.Text = "Task Manager\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BorderlessForm1
            // 
            this.BorderlessForm1.BorderRadius = 6;
            this.BorderlessForm1.ContainerControl = this;
            this.BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.pictureBox1;
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(422, 165);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loading";
            this.Load += new System.EventHandler(this.loading_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl DragControl4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}