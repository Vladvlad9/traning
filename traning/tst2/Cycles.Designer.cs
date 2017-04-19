namespace tst2
{
    partial class Cycles
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
            this.metroTile_Comments = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile_Comments
            // 
            this.metroTile_Comments.ActiveControl = null;
            this.metroTile_Comments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_Comments.Location = new System.Drawing.Point(520, 97);
            this.metroTile_Comments.Name = "metroTile_Comments";
            this.metroTile_Comments.Size = new System.Drawing.Size(160, 150);
            this.metroTile_Comments.TabIndex = 1;
            this.metroTile_Comments.Text = "Цикл for";
            this.metroTile_Comments.TileImage = global::tst2.Properties.Resources.programming_comment_128;
            this.metroTile_Comments.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Comments.UseSelectable = true;
            this.metroTile_Comments.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(686, 97);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(160, 150);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Цикл while";
            this.metroTile1.TileImage = global::tst2.Properties.Resources.programming_comment_128;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile2.Location = new System.Drawing.Point(520, 253);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(160, 150);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Цикл do while";
            this.metroTile2.TileImage = global::tst2.Properties.Resources.programming_comment_128;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile3.Location = new System.Drawing.Point(686, 253);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(160, 150);
            this.metroTile3.TabIndex = 1;
            this.metroTile3.Text = "Цикл foreach";
            this.metroTile3.TileImage = global::tst2.Properties.Resources.programming_comment_128;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // Cycles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile_Comments);
            this.Name = "Cycles";
            this.Size = new System.Drawing.Size(1400, 563);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile_Comments;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}
