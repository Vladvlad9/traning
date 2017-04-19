namespace tst2
{
    partial class Comments_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comments_Form));
            this.timer_panel_menu = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile_menu = new MetroFramework.Controls.MetroTile();
            this.metroTile_Multiline_comments = new MetroFramework.Controls.MetroTile();
            this.metroTile_Singleline_comments = new MetroFramework.Controls.MetroTile();
            this.metroTile_Purpose = new MetroFramework.Controls.MetroTile();
            this.metroTile_Structure = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
<<<<<<< HEAD
            this.fastColoredTextBox_task = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fastColoredTextBox_theory = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fastColoredTextBox_code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.metroButton_check_job_comments = new MetroFramework.Controls.MetroButton();
=======
            this.fastColoredTextBox_code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.fastColoredTextBox_theory = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fastColoredTextBox_task = new FastColoredTextBoxNS.FastColoredTextBox();
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.metroPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_task)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_theory)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_code)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_theory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_task)).BeginInit();
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.SuspendLayout();
            // 
            // timer_panel_menu
            // 
            this.timer_panel_menu.Tick += new System.EventHandler(this.timer_panel_menu_Tick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(213)))));
            this.metroPanel1.Controls.Add(this.metroTile_menu);
            this.metroPanel1.Controls.Add(this.metroTile_Multiline_comments);
            this.metroPanel1.Controls.Add(this.metroTile_Singleline_comments);
            this.metroPanel1.Controls.Add(this.metroTile_Purpose);
            this.metroPanel1.Controls.Add(this.metroTile_Structure);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(35, 564);
            this.metroPanel1.TabIndex = 0;
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
            this.metroTile_menu.Text = "Общее";
            this.metroTile_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_menu.TileImage = global::tst2.Properties.Resources._1491480801_menu_alt;
            this.metroTile_menu.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_menu.UseCustomBackColor = true;
            this.metroTile_menu.UseSelectable = true;
            this.metroTile_menu.UseTileImage = true;
            this.metroTile_menu.Click += new System.EventHandler(this.metroTile_menu_Click);
            // 
            // metroTile_Multiline_comments
            // 
            this.metroTile_Multiline_comments.ActiveControl = null;
            this.metroTile_Multiline_comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_Multiline_comments.Location = new System.Drawing.Point(0, 188);
            this.metroTile_Multiline_comments.Name = "metroTile_Multiline_comments";
            this.metroTile_Multiline_comments.Size = new System.Drawing.Size(229, 41);
            this.metroTile_Multiline_comments.TabIndex = 2;
            this.metroTile_Multiline_comments.Text = "Многострочные комментарии";
            this.metroTile_Multiline_comments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_Multiline_comments.TileImage = global::tst2.Properties.Resources.comment32;
            this.metroTile_Multiline_comments.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_Multiline_comments.UseCustomBackColor = true;
            this.metroTile_Multiline_comments.UseSelectable = true;
            this.metroTile_Multiline_comments.UseTileImage = true;
            this.metroTile_Multiline_comments.Click += new System.EventHandler(this.metroTile_Multiline_comments_Click);
            // 
            // metroTile_Singleline_comments
            // 
            this.metroTile_Singleline_comments.ActiveControl = null;
            this.metroTile_Singleline_comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_Singleline_comments.Location = new System.Drawing.Point(0, 141);
            this.metroTile_Singleline_comments.Name = "metroTile_Singleline_comments";
            this.metroTile_Singleline_comments.Size = new System.Drawing.Size(229, 41);
            this.metroTile_Singleline_comments.TabIndex = 2;
            this.metroTile_Singleline_comments.Text = "Однострочные комментарии";
            this.metroTile_Singleline_comments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_Singleline_comments.TileImage = global::tst2.Properties.Resources.programming_comment_32;
            this.metroTile_Singleline_comments.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_Singleline_comments.UseCustomBackColor = true;
            this.metroTile_Singleline_comments.UseSelectable = true;
            this.metroTile_Singleline_comments.UseTileImage = true;
            this.metroTile_Singleline_comments.Click += new System.EventHandler(this.metroTile_Singleline_comments_Click);
            // 
            // metroTile_Purpose
            // 
            this.metroTile_Purpose.ActiveControl = null;
            this.metroTile_Purpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_Purpose.Location = new System.Drawing.Point(0, 94);
            this.metroTile_Purpose.Name = "metroTile_Purpose";
            this.metroTile_Purpose.Size = new System.Drawing.Size(231, 41);
            this.metroTile_Purpose.TabIndex = 2;
            this.metroTile_Purpose.Text = "Предназначение";
            this.metroTile_Purpose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_Purpose.TileImage = global::tst2.Properties.Resources._1491763647_Untitled_2_28;
            this.metroTile_Purpose.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_Purpose.UseCustomBackColor = true;
            this.metroTile_Purpose.UseSelectable = true;
            this.metroTile_Purpose.UseTileImage = true;
            this.metroTile_Purpose.Click += new System.EventHandler(this.metroTile_Purpose_Click);
            // 
            // metroTile_Structure
            // 
            this.metroTile_Structure.ActiveControl = null;
            this.metroTile_Structure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.metroTile_Structure.Location = new System.Drawing.Point(0, 47);
            this.metroTile_Structure.Name = "metroTile_Structure";
            this.metroTile_Structure.Size = new System.Drawing.Size(231, 41);
            this.metroTile_Structure.TabIndex = 2;
            this.metroTile_Structure.Text = "Структура";
            this.metroTile_Structure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile_Structure.TileImage = global::tst2.Properties.Resources.Structure;
            this.metroTile_Structure.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_Structure.UseCustomBackColor = true;
            this.metroTile_Structure.UseSelectable = true;
            this.metroTile_Structure.UseTileImage = true;
            this.metroTile_Structure.Click += new System.EventHandler(this.metroTile_Structure_Click);
            // 
<<<<<<< HEAD
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox_task, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox_theory, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 564);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // fastColoredTextBox_task
            // 
            this.fastColoredTextBox_task.AutoCompleteBracketsList = new char[] {
=======
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fastColoredTextBox_task, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fastColoredTextBox_theory, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(35, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 564);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox_code, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroButton1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(635, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.33601F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.66398F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 564);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // fastColoredTextBox_code
            // 
            this.fastColoredTextBox_code.AutoCompleteBracketsList = new char[] {
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
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
            this.fastColoredTextBox_task.Size = new System.Drawing.Size(694, 160);
            this.fastColoredTextBox_task.TabIndex = 13;
            this.fastColoredTextBox_task.WordWrap = true;
            this.fastColoredTextBox_task.Zoom = 100;
            // 
            // fastColoredTextBox_theory
            // 
=======
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
            this.fastColoredTextBox_code.ServiceLinesColor = System.Drawing.Color.Black;
            this.fastColoredTextBox_code.Size = new System.Drawing.Size(827, 489);
            this.fastColoredTextBox_code.TabIndex = 2;
            this.fastColoredTextBox_code.Zoom = 100;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButton1.Location = new System.Drawing.Point(3, 498);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 53);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // fastColoredTextBox_theory
            // 
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
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
<<<<<<< HEAD
            this.fastColoredTextBox_theory.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fastColoredTextBox_theory.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_theory.ServiceColors")));
            this.fastColoredTextBox_theory.ServiceLinesColor = System.Drawing.Color.White;
            this.fastColoredTextBox_theory.Size = new System.Drawing.Size(694, 392);
            this.fastColoredTextBox_theory.TabIndex = 12;
            this.fastColoredTextBox_theory.WordWrap = true;
            this.fastColoredTextBox_theory.Zoom = 100;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fastColoredTextBox_code, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroButton_check_job_comments, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(735, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(670, 564);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // fastColoredTextBox_code
            // 
            this.fastColoredTextBox_code.AutoCompleteBracketsList = new char[] {
=======
            this.fastColoredTextBox_theory.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fastColoredTextBox_theory.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_theory.ServiceColors")));
            this.fastColoredTextBox_theory.ServiceLinesColor = System.Drawing.Color.White;
            this.fastColoredTextBox_theory.Size = new System.Drawing.Size(594, 392);
            this.fastColoredTextBox_theory.TabIndex = 12;
            this.fastColoredTextBox_theory.WordWrap = true;
            this.fastColoredTextBox_theory.Zoom = 100;
            // 
            // fastColoredTextBox_task
            // 
            this.fastColoredTextBox_task.AutoCompleteBracketsList = new char[] {
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
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
            // metroButton_check_job_comments
            // 
            this.metroButton_check_job_comments.Location = new System.Drawing.Point(3, 489);
            this.metroButton_check_job_comments.Name = "metroButton_check_job_comments";
            this.metroButton_check_job_comments.Size = new System.Drawing.Size(184, 72);
            this.metroButton_check_job_comments.TabIndex = 1;
            this.metroButton_check_job_comments.Text = "Продолжить(проверить)";
            this.metroButton_check_job_comments.UseSelectable = true;
            this.metroButton_check_job_comments.Click += new System.EventHandler(this.metroButton_check_job_comments_Click);
=======
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
            this.fastColoredTextBox_task.Size = new System.Drawing.Size(594, 160);
            this.fastColoredTextBox_task.TabIndex = 13;
            this.fastColoredTextBox_task.WordWrap = true;
            this.fastColoredTextBox_task.Zoom = 100;
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            // 
            // Comments_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Comments_Form";
            this.Size = new System.Drawing.Size(1400, 564);
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.Comments_Form_Load);
=======
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.metroPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_task)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_theory)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_code)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_theory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_task)).EndInit();
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_panel_menu;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile_Structure;
        private MetroFramework.Controls.MetroTile metroTile_menu;
        private MetroFramework.Controls.MetroTile metroTile_Multiline_comments;
        private MetroFramework.Controls.MetroTile metroTile_Singleline_comments;
        private MetroFramework.Controls.MetroTile metroTile_Purpose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
<<<<<<< HEAD
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_task;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_theory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_code;
        private MetroFramework.Controls.MetroButton metroButton_check_job_comments;
=======
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_code;
        private MetroFramework.Controls.MetroButton metroButton1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_task;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_theory;
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
    }
}
