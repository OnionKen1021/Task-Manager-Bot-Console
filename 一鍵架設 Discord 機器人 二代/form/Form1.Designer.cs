namespace 一鍵架設_Discord_機器人_二代.form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CMDTextBox = new System.Windows.Forms.RichTextBox();
            this.Run = new Guna.UI2.WinForms.Guna2Button();
            this.CMDtextUI = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.error = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OK = new System.Windows.Forms.Timer(this.components);
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.default_run = new Guna.UI2.WinForms.Guna2Button();
            this.Clean = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMDTextBox
            // 
            this.CMDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.CMDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CMDTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CMDTextBox.ForeColor = System.Drawing.Color.White;
            this.CMDTextBox.Location = new System.Drawing.Point(237, 12);
            this.CMDTextBox.Name = "CMDTextBox";
            this.CMDTextBox.Size = new System.Drawing.Size(563, 370);
            this.CMDTextBox.TabIndex = 0;
            this.CMDTextBox.Text = "";
            // 
            // Run
            // 
            this.Run.Animated = true;
            this.Run.BackColor = System.Drawing.Color.Transparent;
            this.Run.BorderRadius = 1;
            this.Run.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Run.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Run.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Run.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Run.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Run.FillColor = System.Drawing.Color.Transparent;
            this.Run.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.Run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Run.Image = ((System.Drawing.Image)(resources.GetObject("Run.Image")));
            this.Run.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Run.Location = new System.Drawing.Point(9, 50);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(200, 44);
            this.Run.TabIndex = 13;
            this.Run.Text = "運行機器人";
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // CMDtextUI
            // 
            this.CMDtextUI.TargetControl = this.CMDTextBox;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // OK
            // 
            this.OK.Interval = 1000;
            this.OK.Tick += new System.EventHandler(this.OK_Tick);
            // 
            // Button1
            // 
            this.Button1.Animated = true;
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BorderRadius = 1;
            this.Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1.FillColor = System.Drawing.Color.Transparent;
            this.Button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button1.Location = new System.Drawing.Point(9, 100);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(200, 44);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "初始執行檔";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // default_run
            // 
            this.default_run.Animated = true;
            this.default_run.BackColor = System.Drawing.Color.Transparent;
            this.default_run.BorderRadius = 1;
            this.default_run.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.default_run.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.default_run.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.default_run.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.default_run.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.default_run.FillColor = System.Drawing.Color.Transparent;
            this.default_run.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.default_run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.default_run.Image = ((System.Drawing.Image)(resources.GetObject("default_run.Image")));
            this.default_run.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.default_run.Location = new System.Drawing.Point(9, 193);
            this.default_run.Name = "default_run";
            this.default_run.Size = new System.Drawing.Size(200, 44);
            this.default_run.TabIndex = 16;
            this.default_run.Text = "一鍵啟動 (默認)";
            this.default_run.Click += new System.EventHandler(this.default_run_Click);
            // 
            // Clean
            // 
            this.Clean.Animated = true;
            this.Clean.BackColor = System.Drawing.Color.Transparent;
            this.Clean.BorderRadius = 1;
            this.Clean.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Clean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clean.FillColor = System.Drawing.Color.Transparent;
            this.Clean.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.Clean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Clean.Image = ((System.Drawing.Image)(resources.GetObject("Clean.Image")));
            this.Clean.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Clean.Location = new System.Drawing.Point(9, 310);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(200, 44);
            this.Clean.TabIndex = 17;
            this.Clean.Text = "清空輸出";
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel4.Controls.Add(this.label2);
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Controls.Add(this.label21);
            this.guna2Panel4.Controls.Add(this.default_run);
            this.guna2Panel4.Controls.Add(this.Clean);
            this.guna2Panel4.Controls.Add(this.label29);
            this.guna2Panel4.Controls.Add(this.guna2Button4);
            this.guna2Panel4.Controls.Add(this.Button1);
            this.guna2Panel4.Controls.Add(this.guna2Button6);
            this.guna2Panel4.Controls.Add(this.Run);
            this.guna2Panel4.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(219, 370);
            this.guna2Panel4.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(6, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Other:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(10, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Started:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
            this.label21.Location = new System.Drawing.Point(10, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 15);
            this.label21.TabIndex = 46;
            this.label21.Text = "advanced:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.LightGray;
            this.label29.Location = new System.Drawing.Point(1, 1);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(155, 15);
            this.label29.TabIndex = 1;
            this.label29.Text = "Task Manager - Bot";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 1;
            this.guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Location = new System.Drawing.Point(3, 389);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(200, 45);
            this.guna2Button4.TabIndex = 20;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderRadius = 1;
            this.guna2Button6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.Location = new System.Drawing.Point(3, 434);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(200, 45);
            this.guna2Button6.TabIndex = 17;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.guna2Button7);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 388);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(788, 70);
            this.guna2Panel1.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(10, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "command:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(1, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Task Manager - Command";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 1;
            this.guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(3, 389);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(200, 45);
            this.guna2Button3.TabIndex = 20;
            // 
            // guna2Button7
            // 
            this.guna2Button7.Animated = true;
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 1;
            this.guna2Button7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.Location = new System.Drawing.Point(3, 434);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(200, 45);
            this.guna2Button7.TabIndex = 17;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.guna2Panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.guna2Panel4;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(225, 13);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "在這裡輸入你的指令";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(551, 45);
            this.guna2TextBox1.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(812, 470);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.CMDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CMDTextBox;
        private Guna.UI2.WinForms.Guna2Button Run;
        private Guna.UI2.WinForms.Guna2Elipse CMDtextUI;
        private System.Windows.Forms.Timer error;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer OK;
        private Guna.UI2.WinForms.Guna2Button Button1;
        private Guna.UI2.WinForms.Guna2Button default_run;
        private Guna.UI2.WinForms.Guna2Button Clean;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label29;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}