namespace tst2
{
    partial class Arithmetic_operations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arithmetic_operations));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fastColoredTextBox_task = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fastColoredTextBox_theory = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fastColoredTextBox_code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.metroButton_check_job_arithmetic_operations = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTile_menu = new MetroFramework.Controls.MetroTile();
            this.metroTile_finish_arithmetic_operations = new MetroFramework.Controls.MetroTile();
            this.metroTile_division = new MetroFramework.Controls.MetroTile();
            this.metroTile_minus = new MetroFramework.Controls.MetroTile();
            this.metroTile_multiplication = new MetroFramework.Controls.MetroTile();
            this.metroTile_plus = new MetroFramework.Controls.MetroTile();
            this.metroTile_equally = new MetroFramework.Controls.MetroTile();
            this.metroTile_obschee_arithmetic_operations = new MetroFramework.Controls.MetroTile();
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
            this.metroPanel1.Controls.Add(this.metroTile_menu);
            this.metroPanel1.Controls.Add(this.metroTile_finish_arithmetic_operations);
            this.metroPanel1.Controls.Add(this.metroTile_division);
            this.metroPanel1.Controls.Add(this.metroTile_minus);
            this.metroPanel1.Controls.Add(this.metroTile_multiplication);
            this.metroPanel1.Controls.Add(this.metroTile_plus);
            this.metroPanel1.Controls.Add(this.metroTile_equally);
            this.metroPanel1.Controls.Add(this.metroTile_obschee_arithmetic_operations);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(32, 564);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox_task, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox_theory, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 564);
            this.tableLayoutPanel1.TabIndex = 7;
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
            this.fastColoredTextBox_task.Location = new System.Drawing.Point(3, 401);
            this.fastColoredTextBox_task.Name = "fastColoredTextBox_task";
            this.fastColoredTextBox_task.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox_task.RightBracket = ')';
            this.fastColoredTextBox_task.RightBracket2 = '}';
            this.fastColoredTextBox_task.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fastColoredTextBox_task.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_task.ServiceColors")));
            this.fastColoredTextBox_task.ServiceLinesColor = System.Drawing.Color.White;
            this.fastColoredTextBox_task.Size = new System.Drawing.Size(707, 160);
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
            this.fastColoredTextBox_theory.Size = new System.Drawing.Size(707, 392);
            this.fastColoredTextBox_theory.TabIndex = 12;
            this.fastColoredTextBox_theory.WordWrap = true;
            this.fastColoredTextBox_theory.Zoom = 100;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fastColoredTextBox_code, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroButton_check_job_arithmetic_operations, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(745, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 564);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // fastColoredTextBox_code
            // 
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
            this.fastColoredTextBox_code.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox_code.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox_code.BackBrush = null;
            this.fastColoredTextBox_code.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox_code.CharHeight = 14;
            this.fastColoredTextBox_code.CharWidth = 8;
            this.fastColoredTextBox_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox_code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox_code.IsReplaceMode = false;
            this.fastColoredTextBox_code.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox_code.LeftBracket = '(';
            this.fastColoredTextBox_code.LeftBracket2 = '{';
            this.fastColoredTextBox_code.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox_code.Name = "fastColoredTextBox_code";
            this.fastColoredTextBox_code.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox_code.RightBracket = ')';
            this.fastColoredTextBox_code.RightBracket2 = '}';
            this.fastColoredTextBox_code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox_code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_code.ServiceColors")));
            this.fastColoredTextBox_code.Size = new System.Drawing.Size(705, 480);
            this.fastColoredTextBox_code.TabIndex = 0;
            this.fastColoredTextBox_code.Zoom = 100;
            // 
            // metroButton_check_job_arithmetic_operations
            // 
            this.metroButton_check_job_arithmetic_operations.Location = new System.Drawing.Point(3, 489);
            this.metroButton_check_job_arithmetic_operations.Name = "metroButton_check_job_arithmetic_operations";
            this.metroButton_check_job_arithmetic_operations.Size = new System.Drawing.Size(184, 72);
            this.metroButton_check_job_arithmetic_operations.TabIndex = 1;
            this.metroButton_check_job_arithmetic_operations.Text = "Продолжить(проверить)";
            this.metroButton_check_job_arithmetic_operations.UseSelectable = true;
            this.metroButton_check_job_arithmetic_operations.Click += new System.EventHandler(this.metroButton_check_job_arithmetic_operations_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTile_menu
            // 
            this.metroTile_menu.ActiveControl = null;
            this.metroTile_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_menu.Location = new System.Drawing.Point(0, 0);
            this.metroTile_menu.Name = "metroTile_menu";
            this.metroTile_menu.Size = new System.Drawing.Size(229, 41);
            this.metroTile_menu.TabIndex = 2;
            this.metroTile_menu.Text = " Меню";
            this.metroTile_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_menu.TileImage = global::tst2.Properties.Resources._1491480801_menu_alt;
            this.metroTile_menu.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_menu.UseCustomBackColor = true;
            this.metroTile_menu.UseSelectable = true;
            this.metroTile_menu.UseTileImage = true;
            this.metroTile_menu.Click += new System.EventHandler(this.metroTile_menu_Click);
            // 
            // metroTile_finish_arithmetic_operations
            // 
            this.metroTile_finish_arithmetic_operations.ActiveControl = null;
            this.metroTile_finish_arithmetic_operations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_finish_arithmetic_operations.Location = new System.Drawing.Point(0, 329);
            this.metroTile_finish_arithmetic_operations.Name = "metroTile_finish_arithmetic_operations";
            this.metroTile_finish_arithmetic_operations.Size = new System.Drawing.Size(230, 41);
            this.metroTile_finish_arithmetic_operations.TabIndex = 2;
            this.metroTile_finish_arithmetic_operations.Text = "Закрепление материала";
            this.metroTile_finish_arithmetic_operations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_finish_arithmetic_operations.TileImage = global::tst2.Properties.Resources.finish_flag_32;
            this.metroTile_finish_arithmetic_operations.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_finish_arithmetic_operations.UseCustomBackColor = true;
            this.metroTile_finish_arithmetic_operations.UseSelectable = true;
            this.metroTile_finish_arithmetic_operations.UseTileImage = true;
            this.metroTile_finish_arithmetic_operations.Click += new System.EventHandler(this.metroTile_finish_arithmetic_operations_Click);
            // 
            // metroTile_division
            // 
            this.metroTile_division.ActiveControl = null;
            this.metroTile_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_division.Location = new System.Drawing.Point(0, 282);
            this.metroTile_division.Name = "metroTile_division";
            this.metroTile_division.Size = new System.Drawing.Size(230, 41);
            this.metroTile_division.TabIndex = 2;
            this.metroTile_division.Text = "Деление";
            this.metroTile_division.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_division.TileImage = global::tst2.Properties.Resources.yumminky_web_74_32;
            this.metroTile_division.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_division.UseCustomBackColor = true;
            this.metroTile_division.UseSelectable = true;
            this.metroTile_division.UseTileImage = true;
            this.metroTile_division.Click += new System.EventHandler(this.metroTile_division_Click);
            // 
            // metroTile_minus
            // 
            this.metroTile_minus.ActiveControl = null;
            this.metroTile_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_minus.Location = new System.Drawing.Point(0, 188);
            this.metroTile_minus.Name = "metroTile_minus";
            this.metroTile_minus.Size = new System.Drawing.Size(230, 41);
            this.metroTile_minus.TabIndex = 2;
            this.metroTile_minus.Text = "Разность";
            this.metroTile_minus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_minus.TileImage = global::tst2.Properties.Resources.minus_32;
            this.metroTile_minus.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_minus.UseCustomBackColor = true;
            this.metroTile_minus.UseSelectable = true;
            this.metroTile_minus.UseTileImage = true;
            this.metroTile_minus.Click += new System.EventHandler(this.metroTile_minus_Click);
            // 
            // metroTile_multiplication
            // 
            this.metroTile_multiplication.ActiveControl = null;
            this.metroTile_multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_multiplication.Location = new System.Drawing.Point(0, 235);
            this.metroTile_multiplication.Name = "metroTile_multiplication";
            this.metroTile_multiplication.Size = new System.Drawing.Size(230, 41);
            this.metroTile_multiplication.TabIndex = 2;
            this.metroTile_multiplication.Text = "Произведение";
            this.metroTile_multiplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_multiplication.TileImage = global::tst2.Properties.Resources.multiplication_32;
            this.metroTile_multiplication.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_multiplication.UseCustomBackColor = true;
            this.metroTile_multiplication.UseSelectable = true;
            this.metroTile_multiplication.UseTileImage = true;
            this.metroTile_multiplication.Click += new System.EventHandler(this.metroTile_multiplication_Click);
            // 
            // metroTile_plus
            // 
            this.metroTile_plus.ActiveControl = null;
            this.metroTile_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_plus.Location = new System.Drawing.Point(0, 141);
            this.metroTile_plus.Name = "metroTile_plus";
            this.metroTile_plus.Size = new System.Drawing.Size(230, 41);
            this.metroTile_plus.TabIndex = 2;
            this.metroTile_plus.Text = "Сумма";
            this.metroTile_plus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_plus.TileImage = global::tst2.Properties.Resources.plus_32;
            this.metroTile_plus.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_plus.UseCustomBackColor = true;
            this.metroTile_plus.UseSelectable = true;
            this.metroTile_plus.UseTileImage = true;
            this.metroTile_plus.Click += new System.EventHandler(this.metroTile_plus_Click);
            // 
            // metroTile_equally
            // 
            this.metroTile_equally.ActiveControl = null;
            this.metroTile_equally.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_equally.Location = new System.Drawing.Point(0, 94);
            this.metroTile_equally.Name = "metroTile_equally";
            this.metroTile_equally.Size = new System.Drawing.Size(230, 41);
            this.metroTile_equally.TabIndex = 2;
            this.metroTile_equally.Text = "Оператор присваивания";
            this.metroTile_equally.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_equally.TileImage = global::tst2.Properties.Resources.equally_math_function_action_32;
            this.metroTile_equally.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_equally.UseCustomBackColor = true;
            this.metroTile_equally.UseSelectable = true;
            this.metroTile_equally.UseTileImage = true;
            this.metroTile_equally.Click += new System.EventHandler(this.metroTile_equally_Click);
            // 
            // metroTile_obschee_arithmetic_operations
            // 
            this.metroTile_obschee_arithmetic_operations.ActiveControl = null;
            this.metroTile_obschee_arithmetic_operations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_obschee_arithmetic_operations.Location = new System.Drawing.Point(0, 47);
            this.metroTile_obschee_arithmetic_operations.Name = "metroTile_obschee_arithmetic_operations";
            this.metroTile_obschee_arithmetic_operations.Size = new System.Drawing.Size(230, 41);
            this.metroTile_obschee_arithmetic_operations.TabIndex = 2;
            this.metroTile_obschee_arithmetic_operations.Text = "Общее";
            this.metroTile_obschee_arithmetic_operations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_obschee_arithmetic_operations.TileImage = global::tst2.Properties.Resources.Structure;
            this.metroTile_obschee_arithmetic_operations.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_obschee_arithmetic_operations.UseCustomBackColor = true;
            this.metroTile_obschee_arithmetic_operations.UseSelectable = true;
            this.metroTile_obschee_arithmetic_operations.UseTileImage = true;
            this.metroTile_obschee_arithmetic_operations.Click += new System.EventHandler(this.metroTile_obschee_arithmetic_operations_Click);
            // 
            // Arithmetic_operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Arithmetic_operations";
            this.Size = new System.Drawing.Size(1459, 564);
            this.Load += new System.EventHandler(this.Arithmetic_operations_Load);
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
        private MetroFramework.Controls.MetroTile metroTile_menu;
        private MetroFramework.Controls.MetroTile metroTile_finish_arithmetic_operations;
        private MetroFramework.Controls.MetroTile metroTile_division;
        private MetroFramework.Controls.MetroTile metroTile_minus;
        private MetroFramework.Controls.MetroTile metroTile_multiplication;
        private MetroFramework.Controls.MetroTile metroTile_plus;
        private MetroFramework.Controls.MetroTile metroTile_equally;
        private MetroFramework.Controls.MetroTile metroTile_obschee_arithmetic_operations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_task;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_theory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_code;
        private MetroFramework.Controls.MetroButton metroButton_check_job_arithmetic_operations;
        private System.Windows.Forms.Timer timer1;
    }
}
