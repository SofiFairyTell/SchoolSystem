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
            this.обновитьИнформациюОбУченикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.УчительПанель = new System.Windows.Forms.TabControl();
            this.УченикиСписок = new System.Windows.Forms.DataGridView();
            this.IDУченика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия_ученик = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя_ученика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество_ученика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Класс_ученика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ОтменитьСортировку = new System.Windows.Forms.Button();
            this.НайтиУченика = new System.Windows.Forms.Button();
            this.КлассыСписок = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.РасписаниеЗанятий = new System.Windows.Forms.DataGridView();
            this.Кабинет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Предмет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО_учителя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДеньНедели = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Н_класса = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ОтменаСортировкиРасписание = new System.Windows.Forms.Button();
            this.НайтиКласс = new System.Windows.Forms.Button();
            this.ВыборКласса = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ФамилияУчителя = new System.Windows.Forms.Label();
            this.ИмяУчителя = new System.Windows.Forms.Label();
            this.ПредметУчителя = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.УчительПанель.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.УченикиСписок)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеЗанятий)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1030, 30);
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновлениеРасписанияToolStripMenuItem,
            this.обновитьИнформациюОбУченикеToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            this.инструментыToolStripMenuItem.Click += new System.EventHandler(this.инструментыToolStripMenuItem_Click);
            // 
            // обновлениеРасписанияToolStripMenuItem
            // 
            this.обновлениеРасписанияToolStripMenuItem.Name = "обновлениеРасписанияToolStripMenuItem";
            this.обновлениеРасписанияToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.обновлениеРасписанияToolStripMenuItem.Text = "Обновление расписания";
            // 
            // обновитьИнформациюОбУченикеToolStripMenuItem
            // 
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Name = "обновитьИнформациюОбУченикеToolStripMenuItem";
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Text = "Обновить список учеников";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.УченикиСписок);
            this.tabPage3.Controls.Add(this.ОтменитьСортировку);
            this.tabPage3.Controls.Add(this.НайтиУченика);
            this.tabPage3.Controls.Add(this.КлассыСписок);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(988, 385);
            this.tabPage3.TabIndex = 11;
            this.tabPage3.Text = "Список учеников";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Size = new System.Drawing.Size(988, 385);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Выставление оценок";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox16);
            this.tabPage1.Controls.Add(this.textBox17);
            this.tabPage1.Controls.Add(this.ПредметУчителя);
            this.tabPage1.Controls.Add(this.ИмяУчителя);
            this.tabPage1.Controls.Add(this.ФамилияУчителя);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(988, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация об учителе";
            // 
            // УчительПанель
            // 
            this.УчительПанель.Controls.Add(this.tabPage1);
            this.УчительПанель.Controls.Add(this.tabPage2);
            this.УчительПанель.Controls.Add(this.tabPage7);
            this.УчительПанель.Controls.Add(this.tabPage3);
            this.УчительПанель.Location = new System.Drawing.Point(12, 31);
            this.УчительПанель.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.УчительПанель.Name = "УчительПанель";
            this.УчительПанель.SelectedIndex = 0;
            this.УчительПанель.Size = new System.Drawing.Size(996, 414);
            this.УчительПанель.TabIndex = 2;
            // 
            // УченикиСписок
            // 
            this.УченикиСписок.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.УченикиСписок.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDУченика,
            this.Фамилия_ученик,
            this.Имя_ученика,
            this.Отчество_ученика,
            this.Класс_ученика});
            this.УченикиСписок.Location = new System.Drawing.Point(19, 50);
            this.УченикиСписок.Name = "УченикиСписок";
            this.УченикиСписок.RowHeadersWidth = 51;
            this.УченикиСписок.RowTemplate.Height = 24;
            this.УченикиСписок.Size = new System.Drawing.Size(699, 304);
            this.УченикиСписок.TabIndex = 116;
            // 
            // IDУченика
            // 
            this.IDУченика.HeaderText = "ID";
            this.IDУченика.MinimumWidth = 6;
            this.IDУченика.Name = "IDУченика";
            this.IDУченика.Width = 125;
            // 
            // Фамилия_ученик
            // 
            this.Фамилия_ученик.HeaderText = "Фамилия";
            this.Фамилия_ученик.MinimumWidth = 6;
            this.Фамилия_ученик.Name = "Фамилия_ученик";
            this.Фамилия_ученик.Width = 125;
            // 
            // Имя_ученика
            // 
            this.Имя_ученика.HeaderText = "Имя";
            this.Имя_ученика.MinimumWidth = 6;
            this.Имя_ученика.Name = "Имя_ученика";
            this.Имя_ученика.Width = 125;
            // 
            // Отчество_ученика
            // 
            this.Отчество_ученика.HeaderText = "Отчество";
            this.Отчество_ученика.MinimumWidth = 6;
            this.Отчество_ученика.Name = "Отчество_ученика";
            this.Отчество_ученика.Width = 125;
            // 
            // Класс_ученика
            // 
            this.Класс_ученика.HeaderText = "Номер класса";
            this.Класс_ученика.MinimumWidth = 6;
            this.Класс_ученика.Name = "Класс_ученика";
            this.Класс_ученика.Width = 125;
            // 
            // ОтменитьСортировку
            // 
            this.ОтменитьСортировку.BackColor = System.Drawing.SystemColors.Window;
            this.ОтменитьСортировку.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ОтменитьСортировку.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ОтменитьСортировку.Location = new System.Drawing.Point(568, 11);
            this.ОтменитьСортировку.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ОтменитьСортировку.Name = "ОтменитьСортировку";
            this.ОтменитьСортировку.Size = new System.Drawing.Size(340, 34);
            this.ОтменитьСортировку.TabIndex = 115;
            this.ОтменитьСортировку.Text = "Отменить сортировку";
            this.ОтменитьСортировку.UseVisualStyleBackColor = false;
            this.ОтменитьСортировку.Click += new System.EventHandler(this.ОтменаСортировкиРасписание_Click);
            // 
            // НайтиУченика
            // 
            this.НайтиУченика.BackColor = System.Drawing.SystemColors.Window;
            this.НайтиУченика.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НайтиУченика.Location = new System.Drawing.Point(357, 11);
            this.НайтиУченика.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.НайтиУченика.Name = "НайтиУченика";
            this.НайтиУченика.Size = new System.Drawing.Size(192, 34);
            this.НайтиУченика.TabIndex = 114;
            this.НайтиУченика.Text = "Найти";
            this.НайтиУченика.UseVisualStyleBackColor = false;
            this.НайтиУченика.Click += new System.EventHandler(this.НайтиУченика_Click);
            // 
            // КлассыСписок
            // 
            this.КлассыСписок.FormattingEnabled = true;
            this.КлассыСписок.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.КлассыСписок.Location = new System.Drawing.Point(163, 18);
            this.КлассыСписок.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.КлассыСписок.Name = "КлассыСписок";
            this.КлассыСписок.Size = new System.Drawing.Size(184, 24);
            this.КлассыСписок.TabIndex = 113;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(15, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 112;
            this.label9.Text = "Выбрать класс";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.РасписаниеЗанятий);
            this.tabPage2.Controls.Add(this.ОтменаСортировкиРасписание);
            this.tabPage2.Controls.Add(this.НайтиКласс);
            this.tabPage2.Controls.Add(this.ВыборКласса);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(988, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // РасписаниеЗанятий
            // 
            this.РасписаниеЗанятий.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.РасписаниеЗанятий.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Кабинет,
            this.Время,
            this.Предмет,
            this.ФИО_учителя,
            this.ДеньНедели,
            this.Н_класса});
            this.РасписаниеЗанятий.Location = new System.Drawing.Point(23, 61);
            this.РасписаниеЗанятий.Name = "РасписаниеЗанятий";
            this.РасписаниеЗанятий.RowHeadersWidth = 51;
            this.РасписаниеЗанятий.RowTemplate.Height = 24;
            this.РасписаниеЗанятий.Size = new System.Drawing.Size(809, 301);
            this.РасписаниеЗанятий.TabIndex = 115;
            // 
            // Кабинет
            // 
            this.Кабинет.HeaderText = "Кабинет";
            this.Кабинет.MinimumWidth = 6;
            this.Кабинет.Name = "Кабинет";
            this.Кабинет.Width = 125;
            // 
            // Время
            // 
            this.Время.HeaderText = "Время";
            this.Время.MinimumWidth = 6;
            this.Время.Name = "Время";
            this.Время.Width = 125;
            // 
            // Предмет
            // 
            this.Предмет.HeaderText = "Предмет";
            this.Предмет.MinimumWidth = 6;
            this.Предмет.Name = "Предмет";
            this.Предмет.Width = 125;
            // 
            // ФИО_учителя
            // 
            this.ФИО_учителя.HeaderText = "Учитель";
            this.ФИО_учителя.MinimumWidth = 6;
            this.ФИО_учителя.Name = "ФИО_учителя";
            this.ФИО_учителя.Width = 125;
            // 
            // ДеньНедели
            // 
            this.ДеньНедели.HeaderText = "День недели";
            this.ДеньНедели.MinimumWidth = 6;
            this.ДеньНедели.Name = "ДеньНедели";
            this.ДеньНедели.Width = 125;
            // 
            // Н_класса
            // 
            this.Н_класса.HeaderText = "Номер класса";
            this.Н_класса.MinimumWidth = 6;
            this.Н_класса.Name = "Н_класса";
            this.Н_класса.Width = 125;
            // 
            // ОтменаСортировкиРасписание
            // 
            this.ОтменаСортировкиРасписание.BackColor = System.Drawing.SystemColors.Window;
            this.ОтменаСортировкиРасписание.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ОтменаСортировкиРасписание.Location = new System.Drawing.Point(467, 6);
            this.ОтменаСортировкиРасписание.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ОтменаСортировкиРасписание.Name = "ОтменаСортировкиРасписание";
            this.ОтменаСортировкиРасписание.Size = new System.Drawing.Size(300, 34);
            this.ОтменаСортировкиРасписание.TabIndex = 114;
            this.ОтменаСортировкиРасписание.Text = "Отменить сортировку";
            this.ОтменаСортировкиРасписание.UseVisualStyleBackColor = false;
            this.ОтменаСортировкиРасписание.Click += new System.EventHandler(this.ОтменаСортировкиРасписание_Click);
            // 
            // НайтиКласс
            // 
            this.НайтиКласс.BackColor = System.Drawing.SystemColors.Window;
            this.НайтиКласс.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НайтиКласс.Location = new System.Drawing.Point(337, 6);
            this.НайтиКласс.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.НайтиКласс.Name = "НайтиКласс";
            this.НайтиКласс.Size = new System.Drawing.Size(97, 34);
            this.НайтиКласс.TabIndex = 113;
            this.НайтиКласс.Text = "Найти";
            this.НайтиКласс.UseVisualStyleBackColor = false;
            this.НайтиКласс.Click += new System.EventHandler(this.НайтиРасписание_Click);
            // 
            // ВыборКласса
            // 
            this.ВыборКласса.BackColor = System.Drawing.SystemColors.Window;
            this.ВыборКласса.FormattingEnabled = true;
            this.ВыборКласса.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ВыборКласса.Location = new System.Drawing.Point(176, 11);
            this.ВыборКласса.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ВыборКласса.Name = "ВыборКласса";
            this.ВыборКласса.Size = new System.Drawing.Size(140, 24);
            this.ВыборКласса.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 111;
            this.label1.Text = "Выбрать класс";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._1579603709_1_p_foni_s_poligonami_6;
            this.pictureBox1.Location = new System.Drawing.Point(20, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ФамилияУчителя
            // 
            this.ФамилияУчителя.AutoSize = true;
            this.ФамилияУчителя.Location = new System.Drawing.Point(271, 59);
            this.ФамилияУчителя.Name = "ФамилияУчителя";
            this.ФамилияУчителя.Size = new System.Drawing.Size(70, 17);
            this.ФамилияУчителя.TabIndex = 1;
            this.ФамилияУчителя.Text = "Фамилия";
            // 
            // ИмяУчителя
            // 
            this.ИмяУчителя.AutoSize = true;
            this.ИмяУчителя.Location = new System.Drawing.Point(271, 105);
            this.ИмяУчителя.Name = "ИмяУчителя";
            this.ИмяУчителя.Size = new System.Drawing.Size(35, 17);
            this.ИмяУчителя.TabIndex = 2;
            this.ИмяУчителя.Text = "Имя";
            // 
            // ПредметУчителя
            // 
            this.ПредметУчителя.AutoSize = true;
            this.ПредметУчителя.Location = new System.Drawing.Point(271, 156);
            this.ПредметУчителя.Name = "ПредметУчителя";
            this.ПредметУчителя.Size = new System.Drawing.Size(66, 17);
            this.ПредметУчителя.TabIndex = 3;
            this.ПредметУчителя.Text = "Предмет";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Window;
            this.textBox16.Location = new System.Drawing.Point(347, 99);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(320, 22);
            this.textBox16.TabIndex = 97;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Window;
            this.textBox17.Location = new System.Drawing.Point(347, 59);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(320, 22);
            this.textBox17.TabIndex = 96;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Русский язык",
            "Математика",
            "Окружающий мир",
            "Литературное чтение",
            "Алгебра",
            "Геометрия",
            "Обществознание",
            "Английский язык"});
            this.comboBox1.Location = new System.Drawing.Point(347, 156);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 24);
            this.comboBox1.TabIndex = 107;
            // 
            // Учитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 490);
            this.Controls.Add(this.УчительПанель);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Учитель";
            this.Text = "Учитель";
            this.Load += new System.EventHandler(this.УчительForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.УчительПанель.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.УченикиСписок)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеЗанятий)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem обновитьИнформациюОбУченикеToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl УчительПанель;
        private System.Windows.Forms.DataGridView УченикиСписок;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDУченика;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия_ученик;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя_ученика;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отчество_ученика;
        private System.Windows.Forms.DataGridViewTextBoxColumn Класс_ученика;
        private System.Windows.Forms.Button ОтменитьСортировку;
        private System.Windows.Forms.Button НайтиУченика;
        private System.Windows.Forms.ComboBox КлассыСписок;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView РасписаниеЗанятий;
        private System.Windows.Forms.DataGridViewTextBoxColumn Кабинет;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время;
        private System.Windows.Forms.DataGridViewTextBoxColumn Предмет;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_учителя;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДеньНедели;
        private System.Windows.Forms.DataGridViewTextBoxColumn Н_класса;
        private System.Windows.Forms.Button ОтменаСортировкиРасписание;
        private System.Windows.Forms.Button НайтиКласс;
        private System.Windows.Forms.ComboBox ВыборКласса;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ПредметУчителя;
        private System.Windows.Forms.Label ИмяУчителя;
        private System.Windows.Forms.Label ФамилияУчителя;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}