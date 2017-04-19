namespace tst2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.metroCheckBox_remember = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton_show_login = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_Login = new MetroFramework.Controls.MetroTextBox();
            this.groupBox_new_user = new System.Windows.Forms.GroupBox();
            this.metroButton_new_user_login = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_new_user_password = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_new_user_login = new MetroFramework.Controls.MetroTextBox();
            this.metroButton_login = new MetroFramework.Controls.MetroButton();
            this.metroButton_new_user = new MetroFramework.Controls.MetroButton();
            this.timer_login = new System.Windows.Forms.Timer(this.components);
            this.timer_new_user = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Login.SuspendLayout();
            this.groupBox_new_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar1.AnimationFunction")));
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(98, 25);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(190, 190);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 55;
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Controls.Add(this.metroCheckBox_remember);
            this.groupBox_Login.Controls.Add(this.metroButton_show_login);
            this.groupBox_Login.Controls.Add(this.metroTextBox_Password);
            this.groupBox_Login.Controls.Add(this.metroTextBox_Login);
            this.groupBox_Login.Location = new System.Drawing.Point(58, 233);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(270, 210);
            this.groupBox_Login.TabIndex = 2;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "Login to yor account";
            // 
            // metroCheckBox_remember
            // 
            this.metroCheckBox_remember.AutoSize = true;
            this.metroCheckBox_remember.Checked = true;
            this.metroCheckBox_remember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox_remember.Location = new System.Drawing.Point(42, 166);
            this.metroCheckBox_remember.Name = "metroCheckBox_remember";
            this.metroCheckBox_remember.Size = new System.Drawing.Size(81, 15);
            this.metroCheckBox_remember.TabIndex = 3;
            this.metroCheckBox_remember.Text = "Remember";
            this.metroCheckBox_remember.UseSelectable = true;
            // 
            // metroButton_show_login
            // 
            this.metroButton_show_login.Location = new System.Drawing.Point(150, 162);
            this.metroButton_show_login.Name = "metroButton_show_login";
            this.metroButton_show_login.Size = new System.Drawing.Size(80, 25);
            this.metroButton_show_login.TabIndex = 2;
            this.metroButton_show_login.Text = "Log";
            this.metroButton_show_login.UseSelectable = true;
            this.metroButton_show_login.Click += new System.EventHandler(this.metroButton_show_login_Click);
            // 
            // metroTextBox_Password
            // 
            // 
            // 
            // 
            this.metroTextBox_Password.CustomButton.Image = null;
            this.metroTextBox_Password.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.metroTextBox_Password.CustomButton.Name = "";
            this.metroTextBox_Password.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Password.CustomButton.TabIndex = 1;
            this.metroTextBox_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Password.CustomButton.UseSelectable = true;
            this.metroTextBox_Password.DisplayIcon = true;
            this.metroTextBox_Password.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox_Password.Icon")));
            this.metroTextBox_Password.Lines = new string[] {
        "admin"};
            this.metroTextBox_Password.Location = new System.Drawing.Point(40, 120);
            this.metroTextBox_Password.MaxLength = 32767;
            this.metroTextBox_Password.Name = "metroTextBox_Password";
            this.metroTextBox_Password.PasswordChar = '*';
            this.metroTextBox_Password.PromptText = "Password";
            this.metroTextBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Password.SelectedText = "";
            this.metroTextBox_Password.SelectionLength = 0;
            this.metroTextBox_Password.SelectionStart = 0;
            this.metroTextBox_Password.ShortcutsEnabled = true;
            this.metroTextBox_Password.ShowButton = true;
            this.metroTextBox_Password.ShowClearButton = true;
            this.metroTextBox_Password.Size = new System.Drawing.Size(190, 25);
            this.metroTextBox_Password.TabIndex = 1;
            this.metroTextBox_Password.Text = "admin";
            this.metroTextBox_Password.UseSelectable = true;
            this.metroTextBox_Password.WaterMark = "Password";
            this.metroTextBox_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_Login
            // 
            // 
            // 
            // 
            this.metroTextBox_Login.CustomButton.Image = null;
            this.metroTextBox_Login.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.metroTextBox_Login.CustomButton.Name = "";
            this.metroTextBox_Login.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox_Login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Login.CustomButton.TabIndex = 1;
            this.metroTextBox_Login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Login.CustomButton.UseSelectable = true;
            this.metroTextBox_Login.DisplayIcon = true;
            this.metroTextBox_Login.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox_Login.Icon")));
            this.metroTextBox_Login.Lines = new string[0];
            this.metroTextBox_Login.Location = new System.Drawing.Point(40, 48);
            this.metroTextBox_Login.MaxLength = 32767;
            this.metroTextBox_Login.Name = "metroTextBox_Login";
            this.metroTextBox_Login.PasswordChar = '\0';
            this.metroTextBox_Login.PromptText = "Login";
            this.metroTextBox_Login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Login.SelectedText = "";
            this.metroTextBox_Login.SelectionLength = 0;
            this.metroTextBox_Login.SelectionStart = 0;
            this.metroTextBox_Login.ShortcutsEnabled = true;
            this.metroTextBox_Login.ShowButton = true;
            this.metroTextBox_Login.ShowClearButton = true;
            this.metroTextBox_Login.Size = new System.Drawing.Size(190, 25);
            this.metroTextBox_Login.TabIndex = 0;
            this.metroTextBox_Login.UseSelectable = true;
            this.metroTextBox_Login.WaterMark = "Login";
            this.metroTextBox_Login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox_new_user
            // 
            this.groupBox_new_user.Controls.Add(this.metroButton_new_user_login);
            this.groupBox_new_user.Controls.Add(this.metroTextBox_new_user_password);
            this.groupBox_new_user.Controls.Add(this.metroTextBox_new_user_login);
            this.groupBox_new_user.Location = new System.Drawing.Point(57, 233);
            this.groupBox_new_user.Name = "groupBox_new_user";
            this.groupBox_new_user.Size = new System.Drawing.Size(0, 210);
            this.groupBox_new_user.TabIndex = 3;
            this.groupBox_new_user.TabStop = false;
            this.groupBox_new_user.Text = "New user";
            // 
            // metroButton_new_user_login
            // 
            this.metroButton_new_user_login.Location = new System.Drawing.Point(150, 162);
            this.metroButton_new_user_login.Name = "metroButton_new_user_login";
            this.metroButton_new_user_login.Size = new System.Drawing.Size(80, 25);
            this.metroButton_new_user_login.TabIndex = 2;
            this.metroButton_new_user_login.Text = "Create";
            this.metroButton_new_user_login.UseSelectable = true;
            this.metroButton_new_user_login.Click += new System.EventHandler(this.metroButton_new_user_login_Click);
            // 
            // metroTextBox_new_user_password
            // 
            // 
            // 
            // 
            this.metroTextBox_new_user_password.CustomButton.Image = null;
            this.metroTextBox_new_user_password.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.metroTextBox_new_user_password.CustomButton.Name = "";
            this.metroTextBox_new_user_password.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox_new_user_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_new_user_password.CustomButton.TabIndex = 1;
            this.metroTextBox_new_user_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_new_user_password.CustomButton.UseSelectable = true;
            this.metroTextBox_new_user_password.CustomButton.Visible = false;
            this.metroTextBox_new_user_password.Lines = new string[0];
            this.metroTextBox_new_user_password.Location = new System.Drawing.Point(40, 120);
            this.metroTextBox_new_user_password.MaxLength = 32767;
            this.metroTextBox_new_user_password.Name = "metroTextBox_new_user_password";
            this.metroTextBox_new_user_password.PasswordChar = '\0';
            this.metroTextBox_new_user_password.PromptText = "Password";
            this.metroTextBox_new_user_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_new_user_password.SelectedText = "";
            this.metroTextBox_new_user_password.SelectionLength = 0;
            this.metroTextBox_new_user_password.SelectionStart = 0;
            this.metroTextBox_new_user_password.ShortcutsEnabled = true;
            this.metroTextBox_new_user_password.Size = new System.Drawing.Size(190, 25);
            this.metroTextBox_new_user_password.TabIndex = 1;
            this.metroTextBox_new_user_password.UseSelectable = true;
            this.metroTextBox_new_user_password.WaterMark = "Password";
            this.metroTextBox_new_user_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_new_user_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_new_user_login
            // 
            // 
            // 
            // 
            this.metroTextBox_new_user_login.CustomButton.Image = null;
            this.metroTextBox_new_user_login.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.metroTextBox_new_user_login.CustomButton.Name = "";
            this.metroTextBox_new_user_login.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox_new_user_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_new_user_login.CustomButton.TabIndex = 1;
            this.metroTextBox_new_user_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_new_user_login.CustomButton.UseSelectable = true;
            this.metroTextBox_new_user_login.CustomButton.Visible = false;
            this.metroTextBox_new_user_login.Lines = new string[0];
            this.metroTextBox_new_user_login.Location = new System.Drawing.Point(40, 48);
            this.metroTextBox_new_user_login.MaxLength = 32767;
            this.metroTextBox_new_user_login.Name = "metroTextBox_new_user_login";
            this.metroTextBox_new_user_login.PasswordChar = '\0';
            this.metroTextBox_new_user_login.PromptText = "Login";
            this.metroTextBox_new_user_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_new_user_login.SelectedText = "";
            this.metroTextBox_new_user_login.SelectionLength = 0;
            this.metroTextBox_new_user_login.SelectionStart = 0;
            this.metroTextBox_new_user_login.ShortcutsEnabled = true;
            this.metroTextBox_new_user_login.Size = new System.Drawing.Size(190, 25);
            this.metroTextBox_new_user_login.TabIndex = 0;
            this.metroTextBox_new_user_login.UseSelectable = true;
            this.metroTextBox_new_user_login.WaterMark = "Login";
            this.metroTextBox_new_user_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_new_user_login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton_login
            // 
            this.metroButton_login.Enabled = false;
            this.metroButton_login.Location = new System.Drawing.Point(58, 458);
            this.metroButton_login.Name = "metroButton_login";
            this.metroButton_login.Size = new System.Drawing.Size(85, 65);
            this.metroButton_login.TabIndex = 3;
            this.metroButton_login.Text = "Login";
            this.metroButton_login.UseSelectable = true;
            this.metroButton_login.Click += new System.EventHandler(this.metroButton_login_Click);
            // 
            // metroButton_new_user
            // 
            this.metroButton_new_user.Location = new System.Drawing.Point(242, 458);
            this.metroButton_new_user.Name = "metroButton_new_user";
            this.metroButton_new_user.Size = new System.Drawing.Size(86, 65);
            this.metroButton_new_user.TabIndex = 4;
            this.metroButton_new_user.Text = "New user";
            this.metroButton_new_user.UseSelectable = true;
            this.metroButton_new_user.Click += new System.EventHandler(this.metroButton_new_user_Click);
            // 
            // timer_login
            // 
            this.timer_login.Interval = 10;
            this.timer_login.Tick += new System.EventHandler(this.timer_login_Tick);
            // 
            // timer_new_user
            // 
            this.timer_new_user.Interval = 10;
            this.timer_new_user.Tick += new System.EventHandler(this.timer_new_user_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(136, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 531);
            this.Controls.Add(this.groupBox_new_user);
            this.Controls.Add(this.metroButton_new_user);
            this.Controls.Add(this.metroButton_login);
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.circularProgressBar1);
            this.Movable = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.groupBox_new_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private MetroFramework.Controls.MetroButton metroButton_login;
        private MetroFramework.Controls.MetroButton metroButton_new_user;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Password;
        private System.Windows.Forms.Timer timer_login;
        private System.Windows.Forms.Timer timer_new_user;
        private MetroFramework.Controls.MetroButton metroButton_show_login;
        private System.Windows.Forms.GroupBox groupBox_new_user;
        private MetroFramework.Controls.MetroButton metroButton_new_user_login;
        private MetroFramework.Controls.MetroTextBox metroTextBox_new_user_password;
        private MetroFramework.Controls.MetroTextBox metroTextBox_new_user_login;
        public MetroFramework.Controls.MetroTextBox metroTextBox_Login;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox_remember;
    }
}

