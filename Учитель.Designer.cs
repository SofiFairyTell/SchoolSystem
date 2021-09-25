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
            this.УчительУченики = new System.Windows.Forms.TabPage();
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
            this.УчительОценки = new System.Windows.Forms.TabPage();
            this.УчительИнфо = new System.Windows.Forms.TabPage();
            this.полеПредмет = new System.Windows.Forms.ComboBox();
            this.полеИмя = new System.Windows.Forms.TextBox();
            this.полеФамилия = new System.Windows.Forms.TextBox();
            this.ПредметУчителя = new System.Windows.Forms.Label();
            this.ИмяУчителя = new System.Windows.Forms.Label();
            this.ФамилияУчителя = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.УчительПанель = new System.Windows.Forms.TabControl();
            this.УчительРасписание = new System.Windows.Forms.TabPage();
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
            this.полеОтчество = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.НайтиМоеРасписание = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.УчительУченики.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.УченикиСписок)).BeginInit();
            this.УчительИнфо.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.УчительПанель.SuspendLayout();
            this.УчительРасписание.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеЗанятий)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1030, 28);
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
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
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            this.инструментыToolStripMenuItem.Click += new System.EventHandler(this.инструментыToolStripMenuItem_Click);
            // 
            // обновлениеРасписанияToolStripMenuItem
            // 
            this.обновлениеРасписанияToolStripMenuItem.Name = "обновлениеРасписанияToolStripMenuItem";
            this.обновлениеРасписанияToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.обновлениеРасписанияToolStripMenuItem.Text = "Обновление расписания";
            this.обновлениеРасписанияToolStripMenuItem.Click += new System.EventHandler(this.базуРасписанияToolStripMenuItem_Click);
            // 
            // обновитьИнформациюОбУченикеToolStripMenuItem
            // 
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Name = "обновитьИнформациюОбУченикеToolStripMenuItem";
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.обновитьИнформациюОбУченикеToolStripMenuItem.Text = "Обновить список учеников";
            // 
            // УчительУченики
            // 
            this.УчительУченики.Controls.Add(this.УченикиСписок);
            this.УчительУченики.Controls.Add(this.ОтменитьСортировку);
            this.УчительУченики.Controls.Add(this.НайтиУченика);
            this.УчительУченики.Controls.Add(this.КлассыСписок);
            this.УчительУченики.Controls.Add(this.label9);
            this.УчительУченики.Location = new System.Drawing.Point(4, 25);
            this.УчительУченики.Name = "УчительУченики";
            this.УчительУченики.Padding = new System.Windows.Forms.Padding(3);
            this.УчительУченики.Size = new System.Drawing.Size(988, 435);
            this.УчительУченики.TabIndex = 11;
            this.УчительУченики.Text = "Список учеников";
            this.УчительУченики.UseVisualStyleBackColor = true;
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
            this.УченикиСписок.Size = new System.Drawing.Size(946, 366);
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
            // УчительОценки
            // 
            this.УчительОценки.Location = new System.Drawing.Point(4, 25);
            this.УчительОценки.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.УчительОценки.Name = "УчительОценки";
            this.УчительОценки.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.УчительОценки.Size = new System.Drawing.Size(988, 435);
            this.УчительОценки.TabIndex = 7;
            this.УчительОценки.Text = "Выставление оценок";
            this.УчительОценки.UseVisualStyleBackColor = true;
            // 
            // УчительИнфо
            // 
            this.УчительИнфо.BackColor = System.Drawing.Color.Linen;
            this.УчительИнфо.Controls.Add(this.НайтиМоеРасписание);
            this.УчительИнфо.Controls.Add(this.label2);
            this.УчительИнфо.Controls.Add(this.полеОтчество);
            this.УчительИнфо.Controls.Add(this.полеПредмет);
            this.УчительИнфо.Controls.Add(this.полеИмя);
            this.УчительИнфо.Controls.Add(this.полеФамилия);
            this.УчительИнфо.Controls.Add(this.ПредметУчителя);
            this.УчительИнфо.Controls.Add(this.ИмяУчителя);
            this.УчительИнфо.Controls.Add(this.ФамилияУчителя);
            this.УчительИнфо.Controls.Add(this.pictureBox1);
            this.УчительИнфо.Location = new System.Drawing.Point(4, 25);
            this.УчительИнфо.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.УчительИнфо.Name = "УчительИнфо";
            this.УчительИнфо.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.УчительИнфо.Size = new System.Drawing.Size(988, 435);
            this.УчительИнфо.TabIndex = 0;
            this.УчительИнфо.Text = "Информация об учителе";
            // 
            // полеПредмет
            // 
            this.полеПредмет.BackColor = System.Drawing.SystemColors.Window;
            this.полеПредмет.FormattingEnabled = true;
            this.полеПредмет.Items.AddRange(new object[] {
            "Русский язык",
            "Математика",
            "Окружающий мир",
            "Литературное чтение",
            "Алгебра",
            "Геометрия",
            "Обществознание",
            "Английский язык"});
            this.полеПредмет.Location = new System.Drawing.Point(336, 157);
            this.полеПредмет.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.полеПредмет.Name = "полеПредмет";
            this.полеПредмет.Size = new System.Drawing.Size(320, 24);
            this.полеПредмет.TabIndex = 107;
            // 
            // полеИмя
            // 
            this.полеИмя.BackColor = System.Drawing.SystemColors.Window;
            this.полеИмя.Location = new System.Drawing.Point(336, 62);
            this.полеИмя.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.полеИмя.Name = "полеИмя";
            this.полеИмя.Size = new System.Drawing.Size(320, 22);
            this.полеИмя.TabIndex = 97;
            // 
            // полеФамилия
            // 
            this.полеФамилия.BackColor = System.Drawing.SystemColors.Window;
            this.полеФамилия.Location = new System.Drawing.Point(336, 22);
            this.полеФамилия.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.полеФамилия.Name = "полеФамилия";
            this.полеФамилия.Size = new System.Drawing.Size(320, 22);
            this.полеФамилия.TabIndex = 96;
            // 
            // ПредметУчителя
            // 
            this.ПредметУчителя.AutoSize = true;
            this.ПредметУчителя.Location = new System.Drawing.Point(260, 160);
            this.ПредметУчителя.Name = "ПредметУчителя";
            this.ПредметУчителя.Size = new System.Drawing.Size(66, 17);
            this.ПредметУчителя.TabIndex = 3;
            this.ПредметУчителя.Text = "Предмет";
            // 
            // ИмяУчителя
            // 
            this.ИмяУчителя.AutoSize = true;
            this.ИмяУчителя.Location = new System.Drawing.Point(260, 68);
            this.ИмяУчителя.Name = "ИмяУчителя";
            this.ИмяУчителя.Size = new System.Drawing.Size(35, 17);
            this.ИмяУчителя.TabIndex = 2;
            this.ИмяУчителя.Text = "Имя";
            // 
            // ФамилияУчителя
            // 
            this.ФамилияУчителя.AutoSize = true;
            this.ФамилияУчителя.Location = new System.Drawing.Point(260, 22);
            this.ФамилияУчителя.Name = "ФамилияУчителя";
            this.ФамилияУчителя.Size = new System.Drawing.Size(70, 17);
            this.ФамилияУчителя.TabIndex = 1;
            this.ФамилияУчителя.Text = "Фамилия";
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
            // УчительПанель
            // 
            this.УчительПанель.Controls.Add(this.УчительИнфо);
            this.УчительПанель.Controls.Add(this.УчительРасписание);
            this.УчительПанель.Controls.Add(this.УчительОценки);
            this.УчительПанель.Controls.Add(this.УчительУченики);
            this.УчительПанель.Location = new System.Drawing.Point(12, 31);
            this.УчительПанель.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.УчительПанель.Name = "УчительПанель";
            this.УчительПанель.SelectedIndex = 0;
            this.УчительПанель.Size = new System.Drawing.Size(996, 464);
            this.УчительПанель.TabIndex = 2;
            // 
            // УчительРасписание
            // 
            this.УчительРасписание.Controls.Add(this.РасписаниеЗанятий);
            this.УчительРасписание.Controls.Add(this.ОтменаСортировкиРасписание);
            this.УчительРасписание.Controls.Add(this.НайтиКласс);
            this.УчительРасписание.Controls.Add(this.ВыборКласса);
            this.УчительРасписание.Controls.Add(this.label1);
            this.УчительРасписание.Location = new System.Drawing.Point(4, 25);
            this.УчительРасписание.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.УчительРасписание.Name = "УчительРасписание";
            this.УчительРасписание.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.УчительРасписание.Size = new System.Drawing.Size(988, 435);
            this.УчительРасписание.TabIndex = 1;
            this.УчительРасписание.Text = "Расписание";
            this.УчительРасписание.UseVisualStyleBackColor = true;
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
            this.РасписаниеЗанятий.Size = new System.Drawing.Size(947, 358);
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
            "1,2,3",
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
            this.ВыборКласса.Size = new System.Drawing.Size(155, 24);
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
            // полеОтчество
            // 
            this.полеОтчество.BackColor = System.Drawing.SystemColors.Window;
            this.полеОтчество.Location = new System.Drawing.Point(336, 103);
            this.полеОтчество.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.полеОтчество.Name = "полеОтчество";
            this.полеОтчество.Size = new System.Drawing.Size(320, 22);
            this.полеОтчество.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "Отчество";
            // 
            // НайтиМоеРасписание
            // 
            this.НайтиМоеРасписание.BackColor = System.Drawing.SystemColors.Window;
            this.НайтиМоеРасписание.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НайтиМоеРасписание.Location = new System.Drawing.Point(559, 205);
            this.НайтиМоеРасписание.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.НайтиМоеРасписание.Name = "НайтиМоеРасписание";
            this.НайтиМоеРасписание.Size = new System.Drawing.Size(97, 34);
            this.НайтиМоеРасписание.TabIndex = 114;
            this.НайтиМоеРасписание.Text = "Найти мое расписание";
            this.НайтиМоеРасписание.UseVisualStyleBackColor = false;
            this.НайтиМоеРасписание.Click += new System.EventHandler(this.НайтиМоеРасписание_Click);
            // 
            // Учитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 506);
            this.Controls.Add(this.УчительПанель);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Учитель";
            this.Text = "Учитель";
            this.Load += new System.EventHandler(this.УчительForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.УчительУченики.ResumeLayout(false);
            this.УчительУченики.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.УченикиСписок)).EndInit();
            this.УчительИнфо.ResumeLayout(false);
            this.УчительИнфо.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.УчительПанель.ResumeLayout(false);
            this.УчительРасписание.ResumeLayout(false);
            this.УчительРасписание.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.РасписаниеЗанятий)).EndInit();
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
        private System.Windows.Forms.TabPage УчительУченики;
        private System.Windows.Forms.TabPage УчительОценки;
        private System.Windows.Forms.TabPage УчительИнфо;
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
        private System.Windows.Forms.TabPage УчительРасписание;
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
        private System.Windows.Forms.TextBox полеИмя;
        private System.Windows.Forms.TextBox полеФамилия;
        private System.Windows.Forms.ComboBox полеПредмет;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox полеОтчество;
        private System.Windows.Forms.Button НайтиМоеРасписание;
    }
}