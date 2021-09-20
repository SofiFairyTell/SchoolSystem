namespace WindowsFormsApp1
{
    partial class Учитель
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновлениеРасписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновлениеПитанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьИнформациюОбУченикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Оценки = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.Оценки.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновлениеРасписанияToolStripMenuItem,
            this.обновлениеПитанияToolStripMenuItem,
            this.обновитьИнформациюОбУченикеToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // обновлениеРасписанияToolStripMenuItem
            // 
            this.обновлениеРасписанияToolStripMenuItem.Name = "обновлениеРасписанияToolStripMenuItem";
            this.обновлениеРасписанияToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.обновлениеРасписанияToolStripMenuItem.Text = "Обновление расписания";
            // 
            // обновлениеПитанияToolStripMenuItem
            // 
            this.обновлениеПитанияToolStripMenuItem.Name = "обновлениеПитанияToolStripMenuItem";
            this.обновлениеПитанияToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.обновлениеПитанияToolStripMenuItem.Text = "Обновление питания";
            // 
            // обновитьИнформациюОбУченикеToolStripMenuItem
            // 
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Name = "обновитьИнформациюОбУченикеToolStripMenuItem";
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Text = "Обновить информацию об ученике";
            // 
            // Оценки
            // 
            this.Оценки.Controls.Add(this.tabPage1);
            this.Оценки.Controls.Add(this.tabPage2);
            this.Оценки.Controls.Add(this.tabPage7);
            this.Оценки.Controls.Add(this.tabPage5);
            this.Оценки.Controls.Add(this.tabPage10);
            this.Оценки.Location = new System.Drawing.Point(9, 25);
            this.Оценки.Margin = new System.Windows.Forms.Padding(2);
            this.Оценки.Name = "Оценки";
            this.Оценки.SelectedIndex = 0;
            this.Оценки.Size = new System.Drawing.Size(581, 336);
            this.Оценки.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(573, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация об учителе";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(573, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage7.Size = new System.Drawing.Size(573, 310);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Выставление оценок";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(573, 310);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Достижения/Повышение квалификации";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(573, 310);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "Расписание олимпиад";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // Учитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 370);
            this.Controls.Add(this.Оценки);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Учитель";
            this.Text = "Учитель";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Оценки.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновлениеРасписанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновлениеПитанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьИнформациюОбУченикеToolStripMenuItem;
        private System.Windows.Forms.TabControl Оценки;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage10;
    }
}