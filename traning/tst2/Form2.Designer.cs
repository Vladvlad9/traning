namespace tst2 {
    partial class Form2 {
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink_Back = new MetroFramework.Controls.MetroLink();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.timer_in_program = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.Controls.Add(this.metroLink_Back);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1360, 67);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLink1
            // 
            this.metroLink1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLink1.Image = global::tst2.Properties.Resources.common_logout_signout_exit_outline_stroke_32;
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(1315, 0);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(45, 67);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.UseSelectable = true;
            // 
            // metroLink_Back
            // 
            this.metroLink_Back.Image = global::tst2.Properties.Resources._1487615501_circle_back_arrow_glyph;
            this.metroLink_Back.ImageSize = 32;
            this.metroLink_Back.Location = new System.Drawing.Point(3, 10);
            this.metroLink_Back.Name = "metroLink_Back";
            this.metroLink_Back.Size = new System.Drawing.Size(45, 40);
            this.metroLink_Back.TabIndex = 1;
            this.metroLink_Back.UseSelectable = true;
            this.metroLink_Back.Click += new System.EventHandler(this.metroLink_Back_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 127);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1360, 711);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // timer_in_program
            // 
            this.timer_in_program.Interval = 1000;
            this.timer_in_program.Tick += new System.EventHandler(this.timer_in_program_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 858);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel1);
            this.MinimumSize = new System.Drawing.Size(1400, 750);
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink_Back;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLink metroLink1;
        public System.Windows.Forms.Timer timer_in_program;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}