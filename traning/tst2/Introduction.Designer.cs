namespace tst2
{
    partial class Introduction
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile_libraries = new MetroFramework.Controls.MetroTile();
            this.metroTile_debugger = new MetroFramework.Controls.MetroTile();
            this.metroTile_compiler = new MetroFramework.Controls.MetroTile();
            this.metroTile_algorithm = new MetroFramework.Controls.MetroTile();
            this.metroTile_back = new MetroFramework.Controls.MetroTile();
            this.timer_panel_menu = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fastColoredTextBox_task = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fastColoredTextBox_theory = new FastColoredTextBoxNS.FastColoredTextBox();
            this.timer_button = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
<<<<<<< HEAD
            this.metroButton_check_job = new MetroFramework.Controls.MetroButton();
=======
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.fastColoredTextBox_code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.metroPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_task)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_theory)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_code)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.metroPanel1.Controls.Add(this.metroTile_libraries);
            this.metroPanel1.Controls.Add(this.metroTile_debugger);
            this.metroPanel1.Controls.Add(this.metroTile_compiler);
            this.metroPanel1.Controls.Add(this.metroTile_algorithm);
            this.metroPanel1.Controls.Add(this.metroTile_back);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(35, 564);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile_libraries
            // 
            this.metroTile_libraries.ActiveControl = null;
            this.metroTile_libraries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_libraries.Location = new System.Drawing.Point(0, 188);
            this.metroTile_libraries.Name = "metroTile_libraries";
            this.metroTile_libraries.Size = new System.Drawing.Size(169, 41);
            this.metroTile_libraries.TabIndex = 1;
            this.metroTile_libraries.Text = "Библиотеки";
            this.metroTile_libraries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_libraries.TileImage = global::tst2.Properties.Resources.Bibliotech;
            this.metroTile_libraries.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_libraries.UseCustomBackColor = true;
            this.metroTile_libraries.UseSelectable = true;
            this.metroTile_libraries.UseTileImage = true;
            this.metroTile_libraries.Click += new System.EventHandler(this.metroTile_libraries_Click);
            // 
            // metroTile_debugger
            // 
            this.metroTile_debugger.ActiveControl = null;
            this.metroTile_debugger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_debugger.Location = new System.Drawing.Point(0, 141);
            this.metroTile_debugger.Name = "metroTile_debugger";
            this.metroTile_debugger.Size = new System.Drawing.Size(169, 41);
            this.metroTile_debugger.TabIndex = 1;
            this.metroTile_debugger.Text = "Отладчик";
            this.metroTile_debugger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_debugger.TileImage = global::tst2.Properties.Resources.debugger_32;
            this.metroTile_debugger.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_debugger.UseCustomBackColor = true;
            this.metroTile_debugger.UseSelectable = true;
            this.metroTile_debugger.UseTileImage = true;
            this.metroTile_debugger.Click += new System.EventHandler(this.metroTile_debugger_Click);
            // 
            // metroTile_compiler
            // 
            this.metroTile_compiler.ActiveControl = null;
            this.metroTile_compiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_compiler.Location = new System.Drawing.Point(0, 94);
            this.metroTile_compiler.Name = "metroTile_compiler";
            this.metroTile_compiler.Size = new System.Drawing.Size(169, 41);
            this.metroTile_compiler.TabIndex = 1;
            this.metroTile_compiler.Text = "Компилятор";
            this.metroTile_compiler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_compiler.TileImage = global::tst2.Properties.Resources.compile;
            this.metroTile_compiler.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_compiler.UseCustomBackColor = true;
            this.metroTile_compiler.UseSelectable = true;
            this.metroTile_compiler.UseTileImage = true;
            this.metroTile_compiler.Click += new System.EventHandler(this.metroTile_compiler_Click);
            // 
            // metroTile_algorithm
            // 
            this.metroTile_algorithm.ActiveControl = null;
            this.metroTile_algorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_algorithm.Location = new System.Drawing.Point(0, 47);
            this.metroTile_algorithm.Name = "metroTile_algorithm";
            this.metroTile_algorithm.Size = new System.Drawing.Size(169, 41);
            this.metroTile_algorithm.TabIndex = 1;
            this.metroTile_algorithm.Text = "Алгоритм";
            this.metroTile_algorithm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_algorithm.TileImage = global::tst2.Properties.Resources.svg_9_32;
            this.metroTile_algorithm.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_algorithm.UseCustomBackColor = true;
            this.metroTile_algorithm.UseSelectable = true;
            this.metroTile_algorithm.UseTileImage = true;
            this.metroTile_algorithm.Click += new System.EventHandler(this.metroTile_algorithm_Click);
            // 
            // metroTile_back
            // 
            this.metroTile_back.ActiveControl = null;
            this.metroTile_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_back.Location = new System.Drawing.Point(0, 0);
            this.metroTile_back.Name = "metroTile_back";
            this.metroTile_back.Size = new System.Drawing.Size(169, 41);
            this.metroTile_back.TabIndex = 1;
            this.metroTile_back.Text = "Общее";
            this.metroTile_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_back.TileImage = global::tst2.Properties.Resources._1491480801_menu_alt;
            this.metroTile_back.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_back.UseCustomBackColor = true;
            this.metroTile_back.UseSelectable = true;
            this.metroTile_back.UseTileImage = true;
            this.metroTile_back.Click += new System.EventHandler(this.metroTile_back_Click);
            // 
            // timer_panel_menu
            // 
            this.timer_panel_menu.Tick += new System.EventHandler(this.timer_panel_menu_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox_task, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox_theory, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.29078F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.70922F));
<<<<<<< HEAD
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 564);
=======
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 564);
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // fastColoredTextBox_task
            // 
            this.fastColoredTextBox_task.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox_task.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox_task.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fastColoredTextBox_task.BackBrush = null;
            this.fastColoredTextBox_task.BookmarkColor = System.Drawing.Color.LightBlue;
            this.fastColoredTextBox_task.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBox_task.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox_task.CaretBlinking = false;
            this.fastColoredTextBox_task.CharHeight = 18;
            this.fastColoredTextBox_task.CharWidth = 10;
            this.fastColoredTextBox_task.CurrentLineColor = System.Drawing.Color.White;
            this.fastColoredTextBox_task.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox_task.DisabledColor = System.Drawing.Color.Silver;
            this.fastColoredTextBox_task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox_task.Font = new System.Drawing.Font("Courier New", 12F);
            this.fastColoredTextBox_task.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastColoredTextBox_task.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fastColoredTextBox_task.IndentBackColor = System.Drawing.Color.White;
            this.fastColoredTextBox_task.IsReplaceMode = false;
            this.fastColoredTextBox_task.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox_task.LeftBracket = '(';
            this.fastColoredTextBox_task.LeftBracket2 = '{';
            this.fastColoredTextBox_task.LineNumberColor = System.Drawing.Color.White;
            this.fastColoredTextBox_task.Location = new System.Drawing.Point(3, 421);
            this.fastColoredTextBox_task.Name = "fastColoredTextBox_task";
            this.fastColoredTextBox_task.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox_task.RightBracket = ')';
            this.fastColoredTextBox_task.RightBracket2 = '}';
            this.fastColoredTextBox_task.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fastColoredTextBox_task.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_task.ServiceColors")));
            this.fastColoredTextBox_task.ServiceLinesColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.fastColoredTextBox_task.Size = new System.Drawing.Size(694, 140);
=======
            this.fastColoredTextBox_task.Size = new System.Drawing.Size(584, 140);
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.fastColoredTextBox_task.TabIndex = 13;
            this.fastColoredTextBox_task.WordWrap = true;
            this.fastColoredTextBox_task.Zoom = 100;
            // 
            // fastColoredTextBox_theory
            // 
            this.fastColoredTextBox_theory.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox_theory.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox_theory.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fastColoredTextBox_theory.BackBrush = null;
            this.fastColoredTextBox_theory.BookmarkColor = System.Drawing.Color.LightBlue;
            this.fastColoredTextBox_theory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBox_theory.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox_theory.CaretBlinking = false;
            this.fastColoredTextBox_theory.CharHeight = 18;
            this.fastColoredTextBox_theory.CharWidth = 10;
            this.fastColoredTextBox_theory.CurrentLineColor = System.Drawing.Color.White;
            this.fastColoredTextBox_theory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox_theory.DisabledColor = System.Drawing.Color.Silver;
            this.fastColoredTextBox_theory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox_theory.Font = new System.Drawing.Font("Courier New", 12F);
            this.fastColoredTextBox_theory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastColoredTextBox_theory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fastColoredTextBox_theory.IndentBackColor = System.Drawing.Color.White;
            this.fastColoredTextBox_theory.IsReplaceMode = false;
            this.fastColoredTextBox_theory.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox_theory.LeftBracket = '(';
            this.fastColoredTextBox_theory.LeftBracket2 = '{';
            this.fastColoredTextBox_theory.LineNumberColor = System.Drawing.Color.White;
            this.fastColoredTextBox_theory.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox_theory.Name = "fastColoredTextBox_theory";
            this.fastColoredTextBox_theory.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox_theory.RightBracket = ')';
            this.fastColoredTextBox_theory.RightBracket2 = '}';
            this.fastColoredTextBox_theory.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fastColoredTextBox_theory.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_theory.ServiceColors")));
            this.fastColoredTextBox_theory.ServiceLinesColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.fastColoredTextBox_theory.Size = new System.Drawing.Size(694, 412);
            this.fastColoredTextBox_theory.TabIndex = 12;
            this.fastColoredTextBox_theory.WordWrap = true;
            this.fastColoredTextBox_theory.Zoom = 100;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.metroButton_check_job, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fastColoredTextBox_code, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(735, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(675, 564);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // metroButton_check_job
            // 
            this.metroButton_check_job.Location = new System.Drawing.Point(3, 497);
            this.metroButton_check_job.Name = "metroButton_check_job";
            this.metroButton_check_job.Size = new System.Drawing.Size(172, 64);
            this.metroButton_check_job.TabIndex = 13;
            this.metroButton_check_job.Text = "Продолжить";
            this.metroButton_check_job.UseSelectable = true;
            this.metroButton_check_job.Click += new System.EventHandler(this.metroButton_check_job_Click);
            // 
            // fastColoredTextBox_code
            // 
=======
            this.fastColoredTextBox_theory.Size = new System.Drawing.Size(584, 412);
            this.fastColoredTextBox_theory.TabIndex = 12;
            this.fastColoredTextBox_theory.WordWrap = true;
            this.fastColoredTextBox_theory.Zoom = 100;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fastColoredTextBox_code, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(625, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(590, 564);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // fastColoredTextBox_code
            // 
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.fastColoredTextBox_code.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
<<<<<<< HEAD
            this.fastColoredTextBox_code.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox_code.BackBrush = null;
=======
            this.fastColoredTextBox_code.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox_code.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox_code.BackBrush = null;
            this.fastColoredTextBox_code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBox_code.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.fastColoredTextBox_code.CharHeight = 14;
            this.fastColoredTextBox_code.CharWidth = 8;
            this.fastColoredTextBox_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox_code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox_code.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox_code.IsReplaceMode = false;
            this.fastColoredTextBox_code.Language = FastColoredTextBoxNS.Language.CSharp;
<<<<<<< HEAD
            this.fastColoredTextBox_code.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox_code.Name = "fastColoredTextBox_code";
            this.fastColoredTextBox_code.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox_code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox_code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_code.ServiceColors")));
            this.fastColoredTextBox_code.Size = new System.Drawing.Size(669, 488);
            this.fastColoredTextBox_code.TabIndex = 14;
=======
            this.fastColoredTextBox_code.LeftBracket = '(';
            this.fastColoredTextBox_code.LeftBracket2 = '{';
            this.fastColoredTextBox_code.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox_code.Name = "fastColoredTextBox_code";
            this.fastColoredTextBox_code.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox_code.RightBracket = ')';
            this.fastColoredTextBox_code.RightBracket2 = '}';
            this.fastColoredTextBox_code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox_code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_code.ServiceColors")));
            this.fastColoredTextBox_code.ServiceLinesColor = System.Drawing.Color.Black;
            this.fastColoredTextBox_code.Size = new System.Drawing.Size(584, 558);
            this.fastColoredTextBox_code.TabIndex = 3;
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.fastColoredTextBox_code.Zoom = 100;
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Introduction";
            this.Size = new System.Drawing.Size(1400, 564);
            this.Load += new System.EventHandler(this.Introduction_Load);
            this.metroPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_task)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_theory)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_code)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile_libraries;
        private MetroFramework.Controls.MetroTile metroTile_debugger;
        private MetroFramework.Controls.MetroTile metroTile_compiler;
        private MetroFramework.Controls.MetroTile metroTile_algorithm;
        private MetroFramework.Controls.MetroTile metroTile_back;
        private System.Windows.Forms.Timer timer_panel_menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer_button;
<<<<<<< HEAD
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_task;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_theory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton metroButton_check_job;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_code;
=======
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_code;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_task;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_theory;
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
    }
}
