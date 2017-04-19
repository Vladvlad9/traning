namespace tst2
{
    partial class Data_types
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_types));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile_menu = new MetroFramework.Controls.MetroTile();
            this.metroTile_finish_data_type = new MetroFramework.Controls.MetroTile();
            this.metroTile_const_data_type = new MetroFramework.Controls.MetroTile();
            this.metroTile_bool_type = new MetroFramework.Controls.MetroTile();
            this.metroTile_double_type = new MetroFramework.Controls.MetroTile();
            this.metroTile_char_type = new MetroFramework.Controls.MetroTile();
            this.metroTile_float_type = new MetroFramework.Controls.MetroTile();
            this.metroTile_integer_type = new MetroFramework.Controls.MetroTile();
            this.metroTile_obschee_date_type = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fastColoredTextBox_task = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fastColoredTextBox_theory = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fastColoredTextBox_code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.metroButton_check_job_data_type = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.metroPanel1.Controls.Add(this.metroTile_finish_data_type);
            this.metroPanel1.Controls.Add(this.metroTile_const_data_type);
            this.metroPanel1.Controls.Add(this.metroTile_bool_type);
            this.metroPanel1.Controls.Add(this.metroTile_double_type);
            this.metroPanel1.Controls.Add(this.metroTile_char_type);
            this.metroPanel1.Controls.Add(this.metroTile_float_type);
            this.metroPanel1.Controls.Add(this.metroTile_integer_type);
            this.metroPanel1.Controls.Add(this.metroTile_obschee_date_type);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(32, 564);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // metroTile_finish_data_type
            // 
            this.metroTile_finish_data_type.ActiveControl = null;
            this.metroTile_finish_data_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_finish_data_type.Location = new System.Drawing.Point(0, 376);
            this.metroTile_finish_data_type.Name = "metroTile_finish_data_type";
            this.metroTile_finish_data_type.Size = new System.Drawing.Size(229, 41);
            this.metroTile_finish_data_type.TabIndex = 2;
            this.metroTile_finish_data_type.Text = "Закрепление материала";
            this.metroTile_finish_data_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_finish_data_type.TileImage = global::tst2.Properties.Resources.finish_flag_32;
            this.metroTile_finish_data_type.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_finish_data_type.UseCustomBackColor = true;
            this.metroTile_finish_data_type.UseSelectable = true;
            this.metroTile_finish_data_type.UseTileImage = true;
            this.metroTile_finish_data_type.Click += new System.EventHandler(this.metroTile_finish_data_type_Click);
            // 
            // metroTile_const_data_type
            // 
            this.metroTile_const_data_type.ActiveControl = null;
            this.metroTile_const_data_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_const_data_type.Location = new System.Drawing.Point(0, 329);
            this.metroTile_const_data_type.Name = "metroTile_const_data_type";
            this.metroTile_const_data_type.Size = new System.Drawing.Size(229, 41);
            this.metroTile_const_data_type.TabIndex = 2;
            this.metroTile_const_data_type.Text = "Константы";
            this.metroTile_const_data_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_const_data_type.TileImage = global::tst2.Properties.Resources.const_number_32;
            this.metroTile_const_data_type.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_const_data_type.UseCustomBackColor = true;
            this.metroTile_const_data_type.UseSelectable = true;
            this.metroTile_const_data_type.UseTileImage = true;
            this.metroTile_const_data_type.Click += new System.EventHandler(this.metroTile_const_data_type_Click);
            // 
            // metroTile_bool_type
            // 
            this.metroTile_bool_type.ActiveControl = null;
            this.metroTile_bool_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_bool_type.Location = new System.Drawing.Point(0, 282);
            this.metroTile_bool_type.Name = "metroTile_bool_type";
            this.metroTile_bool_type.Size = new System.Drawing.Size(229, 41);
            this.metroTile_bool_type.TabIndex = 2;
            this.metroTile_bool_type.Text = "Логический тип данных";
            this.metroTile_bool_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_bool_type.TileImage = global::tst2.Properties.Resources.bool_number_32;
            this.metroTile_bool_type.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_bool_type.UseCustomBackColor = true;
            this.metroTile_bool_type.UseSelectable = true;
            this.metroTile_bool_type.UseTileImage = true;
            this.metroTile_bool_type.Click += new System.EventHandler(this.metroTile_bool_type_Click);
            // 
            // metroTile_double_type
            // 
            this.metroTile_double_type.ActiveControl = null;
            this.metroTile_double_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_double_type.Location = new System.Drawing.Point(0, 188);
            this.metroTile_double_type.Name = "metroTile_double_type";
            this.metroTile_double_type.Size = new System.Drawing.Size(229, 41);
            this.metroTile_double_type.TabIndex = 2;
            this.metroTile_double_type.Text = "Тип данных double";
            this.metroTile_double_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_double_type.TileImage = global::tst2.Properties.Resources.double_32;
            this.metroTile_double_type.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_double_type.UseCustomBackColor = true;
            this.metroTile_double_type.UseSelectable = true;
            this.metroTile_double_type.UseTileImage = true;
            this.metroTile_double_type.Click += new System.EventHandler(this.metroTile_double_type_Click);
            // 
            // metroTile_char_type
            // 
            this.metroTile_char_type.ActiveControl = null;
            this.metroTile_char_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_char_type.Location = new System.Drawing.Point(0, 235);
            this.metroTile_char_type.Name = "metroTile_char_type";
            this.metroTile_char_type.Size = new System.Drawing.Size(229, 41);
            this.metroTile_char_type.TabIndex = 2;
            this.metroTile_char_type.Text = "Тип данных char";
            this.metroTile_char_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_char_type.TileImage = global::tst2.Properties.Resources.char_32;
            this.metroTile_char_type.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_char_type.UseCustomBackColor = true;
            this.metroTile_char_type.UseSelectable = true;
            this.metroTile_char_type.UseTileImage = true;
            this.metroTile_char_type.Click += new System.EventHandler(this.metroTile_char_type_Click);
            // 
            // metroTile_float_type
            // 
            this.metroTile_float_type.ActiveControl = null;
            this.metroTile_float_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_float_type.Location = new System.Drawing.Point(0, 141);
            this.metroTile_float_type.Name = "metroTile_float_type";
            this.metroTile_float_type.Size = new System.Drawing.Size(229, 41);
            this.metroTile_float_type.TabIndex = 2;
            this.metroTile_float_type.Text = "Тип данных float";
            this.metroTile_float_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_float_type.TileImage = global::tst2.Properties.Resources.float1_number_32;
            this.metroTile_float_type.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_float_type.UseCustomBackColor = true;
            this.metroTile_float_type.UseSelectable = true;
            this.metroTile_float_type.UseTileImage = true;
            this.metroTile_float_type.Click += new System.EventHandler(this.metroTile_float_type_Click);
            // 
            // metroTile_integer_type
            // 
            this.metroTile_integer_type.ActiveControl = null;
            this.metroTile_integer_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_integer_type.Location = new System.Drawing.Point(0, 94);
            this.metroTile_integer_type.Name = "metroTile_integer_type";
            this.metroTile_integer_type.Size = new System.Drawing.Size(231, 41);
            this.metroTile_integer_type.TabIndex = 2;
            this.metroTile_integer_type.Text = "Целочисленный тип данных";
            this.metroTile_integer_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_integer_type.TileImage = global::tst2.Properties.Resources.int_number_32;
            this.metroTile_integer_type.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_integer_type.UseCustomBackColor = true;
            this.metroTile_integer_type.UseSelectable = true;
            this.metroTile_integer_type.UseTileImage = true;
            this.metroTile_integer_type.Click += new System.EventHandler(this.metroTile_integer_type_Click);
            // 
            // metroTile_obschee_date_type
            // 
            this.metroTile_obschee_date_type.ActiveControl = null;
            this.metroTile_obschee_date_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_obschee_date_type.Location = new System.Drawing.Point(0, 47);
            this.metroTile_obschee_date_type.Name = "metroTile_obschee_date_type";
            this.metroTile_obschee_date_type.Size = new System.Drawing.Size(231, 41);
            this.metroTile_obschee_date_type.TabIndex = 2;
            this.metroTile_obschee_date_type.Text = "Общее";
            this.metroTile_obschee_date_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_obschee_date_type.TileImage = global::tst2.Properties.Resources.Structure;
            this.metroTile_obschee_date_type.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_obschee_date_type.UseCustomBackColor = true;
            this.metroTile_obschee_date_type.UseSelectable = true;
            this.metroTile_obschee_date_type.UseTileImage = true;
            this.metroTile_obschee_date_type.Click += new System.EventHandler(this.metroTile_obschee_Click);
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
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.tableLayoutPanel2.Controls.Add(this.metroButton_check_job_data_type, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(745, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(670, 564);
            this.tableLayoutPanel2.TabIndex = 7;
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
            this.fastColoredTextBox_code.Size = new System.Drawing.Size(664, 480);
            this.fastColoredTextBox_code.TabIndex = 0;
            this.fastColoredTextBox_code.Zoom = 100;
            // 
            // metroButton_check_job_data_type
            // 
            this.metroButton_check_job_data_type.Location = new System.Drawing.Point(3, 489);
            this.metroButton_check_job_data_type.Name = "metroButton_check_job_data_type";
            this.metroButton_check_job_data_type.Size = new System.Drawing.Size(184, 72);
            this.metroButton_check_job_data_type.TabIndex = 1;
            this.metroButton_check_job_data_type.Text = "Продолжить(проверить)";
            this.metroButton_check_job_data_type.UseSelectable = true;
            this.metroButton_check_job_data_type.Click += new System.EventHandler(this.metroButton_check_job_data_type_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Data_types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Data_types";
            this.Size = new System.Drawing.Size(1400, 564);
            this.Load += new System.EventHandler(this.Data_types_Load);
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
        private MetroFramework.Controls.MetroTile metroTile_char_type;
        private MetroFramework.Controls.MetroTile metroTile_float_type;
        private MetroFramework.Controls.MetroTile metroTile_integer_type;
        private MetroFramework.Controls.MetroTile metroTile_obschee_date_type;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_task;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_theory;
        private MetroFramework.Controls.MetroTile metroTile_finish_data_type;
        private MetroFramework.Controls.MetroTile metroTile_const_data_type;
        private MetroFramework.Controls.MetroTile metroTile_bool_type;
        private MetroFramework.Controls.MetroTile metroTile_double_type;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_code;
        private MetroFramework.Controls.MetroButton metroButton_check_job_data_type;
        private System.Windows.Forms.Timer timer1;
    }
}
