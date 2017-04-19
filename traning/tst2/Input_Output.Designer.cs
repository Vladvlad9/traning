namespace tst2
{
    partial class Input_Output
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
            this.metroTile_Increment_decrement = new MetroFramework.Controls.MetroTile();
            this.metroTile_Cast = new MetroFramework.Controls.MetroTile();
            this.metroTile_Arithmetic_operations = new MetroFramework.Controls.MetroTile();
            this.metroTile_Data_types = new MetroFramework.Controls.MetroTile();
            this.metroTile_Comments = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile_Increment_decrement
            // 
            this.metroTile_Increment_decrement.ActiveControl = null;
            this.metroTile_Increment_decrement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_Increment_decrement.Location = new System.Drawing.Point(706, 81);
            this.metroTile_Increment_decrement.Name = "metroTile_Increment_decrement";
            this.metroTile_Increment_decrement.Size = new System.Drawing.Size(343, 150);
            this.metroTile_Increment_decrement.TabIndex = 0;
            this.metroTile_Increment_decrement.Text = "Инкремент. Декремент. Префиксная форма записи.";
            this.metroTile_Increment_decrement.UseSelectable = true;
            this.metroTile_Increment_decrement.Click += new System.EventHandler(this.metroTile_Increment_decrement_Click);
            // 
            // metroTile_Cast
            // 
            this.metroTile_Cast.ActiveControl = null;
            this.metroTile_Cast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_Cast.Location = new System.Drawing.Point(706, 237);
            this.metroTile_Cast.Name = "metroTile_Cast";
            this.metroTile_Cast.Size = new System.Drawing.Size(343, 150);
            this.metroTile_Cast.TabIndex = 0;
            this.metroTile_Cast.Text = "Приведение типов.";
            this.metroTile_Cast.UseSelectable = true;
            // 
            // metroTile_Arithmetic_operations
            // 
            this.metroTile_Arithmetic_operations.ActiveControl = null;
            this.metroTile_Arithmetic_operations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_Arithmetic_operations.Location = new System.Drawing.Point(334, 237);
            this.metroTile_Arithmetic_operations.Name = "metroTile_Arithmetic_operations";
            this.metroTile_Arithmetic_operations.Size = new System.Drawing.Size(326, 150);
            this.metroTile_Arithmetic_operations.TabIndex = 0;
            this.metroTile_Arithmetic_operations.Text = "Арифметические операции";
            this.metroTile_Arithmetic_operations.TileImage = global::tst2.Properties.Resources._34_64;
            this.metroTile_Arithmetic_operations.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Arithmetic_operations.UseSelectable = true;
            this.metroTile_Arithmetic_operations.UseTileImage = true;
            this.metroTile_Arithmetic_operations.Click += new System.EventHandler(this.metroTile_Arithmetic_operations_Click);
            // 
            // metroTile_Data_types
            // 
            this.metroTile_Data_types.ActiveControl = null;
            this.metroTile_Data_types.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_Data_types.Location = new System.Drawing.Point(500, 81);
            this.metroTile_Data_types.Name = "metroTile_Data_types";
            this.metroTile_Data_types.Size = new System.Drawing.Size(160, 150);
            this.metroTile_Data_types.TabIndex = 0;
            this.metroTile_Data_types.Text = "Типы данных";
            this.metroTile_Data_types.TileImage = global::tst2.Properties.Resources.sharpicons_file_64;
            this.metroTile_Data_types.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Data_types.UseSelectable = true;
            this.metroTile_Data_types.UseTileImage = true;
            this.metroTile_Data_types.Click += new System.EventHandler(this.metroTile_Data_types_Click);
            // 
            // metroTile_Comments
            // 
            this.metroTile_Comments.ActiveControl = null;
            this.metroTile_Comments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_Comments.Location = new System.Drawing.Point(334, 81);
            this.metroTile_Comments.Name = "metroTile_Comments";
            this.metroTile_Comments.Size = new System.Drawing.Size(160, 150);
            this.metroTile_Comments.TabIndex = 0;
            this.metroTile_Comments.Text = "Комментарии";
            this.metroTile_Comments.TileImage = global::tst2.Properties.Resources.programming_comment_128;
            this.metroTile_Comments.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Comments.UseSelectable = true;
            this.metroTile_Comments.UseTileImage = true;
            this.metroTile_Comments.Click += new System.EventHandler(this.metroTile_Comments_Click);
            // 
            // Input_Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile_Arithmetic_operations);
            this.Controls.Add(this.metroTile_Increment_decrement);
            this.Controls.Add(this.metroTile_Data_types);
            this.Controls.Add(this.metroTile_Cast);
            this.Controls.Add(this.metroTile_Comments);
            this.Name = "Input_Output";
            this.Size = new System.Drawing.Size(1400, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile_Comments;
        private MetroFramework.Controls.MetroTile metroTile_Data_types;
        private MetroFramework.Controls.MetroTile metroTile_Arithmetic_operations;
        private MetroFramework.Controls.MetroTile metroTile_Increment_decrement;
        private MetroFramework.Controls.MetroTile metroTile_Cast;
    }
}
