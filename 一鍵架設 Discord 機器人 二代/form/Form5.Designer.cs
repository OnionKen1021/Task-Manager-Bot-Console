namespace 一鍵架設_Discord_機器人_二代.form
{
    partial class writebat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(writebat));
            this.check = new Guna.UI2.WinForms.Guna2Button();
            this.close = new Guna.UI2.WinForms.Guna2Button();
            this.path_set = new Guna.UI2.WinForms.Guna2TextBox();
            this.file_set = new Guna.UI2.WinForms.Guna2TextBox();
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Animated = true;
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.BorderRadius = 1;
            this.check.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.check.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.check.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.check.FillColor = System.Drawing.Color.Transparent;
            this.check.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.check.Image = ((System.Drawing.Image)(resources.GetObject("check.Image")));
            this.check.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.check.Location = new System.Drawing.Point(218, 133);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(200, 44);
            this.check.TabIndex = 14;
            this.check.Text = "儲存設置";
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // close
            // 
            this.close.Animated = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BorderRadius = 1;
            this.close.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close.FillColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.close.Location = new System.Drawing.Point(12, 133);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(200, 44);
            this.close.TabIndex = 15;
            this.close.Text = "取消設置";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // path_set
            // 
            this.path_set.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.path_set.DefaultText = "";
            this.path_set.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.path_set.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.path_set.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.path_set.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.path_set.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.path_set.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.path_set.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.path_set.IconLeft = ((System.Drawing.Image)(resources.GetObject("path_set.IconLeft")));
            this.path_set.Location = new System.Drawing.Point(12, 25);
            this.path_set.Name = "path_set";
            this.path_set.PasswordChar = '\0';
            this.path_set.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.path_set.PlaceholderText = "文件路徑 (機器人工作區域)";
            this.path_set.SelectedText = "";
            this.path_set.Size = new System.Drawing.Size(406, 45);
            this.path_set.TabIndex = 16;
            // 
            // file_set
            // 
            this.file_set.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.file_set.DefaultText = "";
            this.file_set.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.file_set.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.file_set.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.file_set.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.file_set.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.file_set.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.file_set.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.file_set.IconLeft = ((System.Drawing.Image)(resources.GetObject("file_set.IconLeft")));
            this.file_set.Location = new System.Drawing.Point(12, 76);
            this.file_set.Name = "file_set";
            this.file_set.PasswordChar = '\0';
            this.file_set.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.file_set.PlaceholderText = "檔案名稱 (需與啟動項目同名) (ex: main.py -> main)";
            this.file_set.SelectedText = "";
            this.file_set.Size = new System.Drawing.Size(406, 45);
            this.file_set.TabIndex = 17;
            // 
            // Elipse1
            // 
            this.Elipse1.TargetControl = this;
            // 
            // DragControl1
            // 
            this.DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1.TargetControl = this;
            this.DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label29);
            this.guna2Panel1.Location = new System.Drawing.Point(0, -4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(433, 23);
            this.guna2Panel1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(9, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Settings";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("hooge 05_55", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.LightGray;
            this.label29.Location = new System.Drawing.Point(82, 5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(182, 15);
            this.label29.TabIndex = 2;
            this.label29.Text = "Task Manager - 進階設置";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.guna2Panel1;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 1;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("hooge 05_55", 9.749999F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(397, -3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(33, 29);
            this.guna2Button1.TabIndex = 50;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // writebat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(428, 189);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.file_set);
            this.Controls.Add(this.path_set);
            this.Controls.Add(this.close);
            this.Controls.Add(this.check);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "writebat";
            this.Text = "Form5";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button check;
        private Guna.UI2.WinForms.Guna2Button close;
        private Guna.UI2.WinForms.Guna2TextBox path_set;
        private Guna.UI2.WinForms.Guna2TextBox file_set;
        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}