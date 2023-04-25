namespace UndergraduatePractice
{
    partial class UndergraduatePracticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UndergraduatePracticeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вузToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаОбученияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предприятиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководительОтВузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСтудентовИПредприятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прохождениеПрактикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПаролейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.журналыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(549, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вузToolStripMenuItem,
            this.факультетToolStripMenuItem,
            this.формаОбученияToolStripMenuItem,
            this.специальностьToolStripMenuItem,
            this.группаToolStripMenuItem,
            this.студентToolStripMenuItem,
            this.предприятиеToolStripMenuItem,
            this.руководительОтВузаToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // вузToolStripMenuItem
            // 
            this.вузToolStripMenuItem.Name = "вузToolStripMenuItem";
            this.вузToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.вузToolStripMenuItem.Text = "Вуз";
            this.вузToolStripMenuItem.Click += new System.EventHandler(this.вузToolStripMenuItem_Click);
            // 
            // факультетToolStripMenuItem
            // 
            this.факультетToolStripMenuItem.Name = "факультетToolStripMenuItem";
            this.факультетToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.факультетToolStripMenuItem.Text = "Факультет";
            this.факультетToolStripMenuItem.Click += new System.EventHandler(this.факультетToolStripMenuItem_Click);
            // 
            // формаОбученияToolStripMenuItem
            // 
            this.формаОбученияToolStripMenuItem.Name = "формаОбученияToolStripMenuItem";
            this.формаОбученияToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.формаОбученияToolStripMenuItem.Text = "Форма обучения";
            this.формаОбученияToolStripMenuItem.Click += new System.EventHandler(this.формаОбученияToolStripMenuItem_Click);
            // 
            // специальностьToolStripMenuItem
            // 
            this.специальностьToolStripMenuItem.Name = "специальностьToolStripMenuItem";
            this.специальностьToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.специальностьToolStripMenuItem.Text = "Специальность";
            this.специальностьToolStripMenuItem.Click += new System.EventHandler(this.специальностьToolStripMenuItem_Click);
            // 
            // группаToolStripMenuItem
            // 
            this.группаToolStripMenuItem.Name = "группаToolStripMenuItem";
            this.группаToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.группаToolStripMenuItem.Text = "Группа";
            this.группаToolStripMenuItem.Click += new System.EventHandler(this.группаToolStripMenuItem_Click);
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.студентToolStripMenuItem.Text = "Студент";
            this.студентToolStripMenuItem.Click += new System.EventHandler(this.студентToolStripMenuItem_Click);
            // 
            // предприятиеToolStripMenuItem
            // 
            this.предприятиеToolStripMenuItem.Name = "предприятиеToolStripMenuItem";
            this.предприятиеToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.предприятиеToolStripMenuItem.Text = "Предприятие";
            this.предприятиеToolStripMenuItem.Click += new System.EventHandler(this.предприятиеToolStripMenuItem_Click);
            // 
            // руководительОтВузаToolStripMenuItem
            // 
            this.руководительОтВузаToolStripMenuItem.Name = "руководительОтВузаToolStripMenuItem";
            this.руководительОтВузаToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.руководительОтВузаToolStripMenuItem.Text = "Руководитель от вуза";
            this.руководительОтВузаToolStripMenuItem.Click += new System.EventHandler(this.руководительОтВузаToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискСтудентовИПредприятийToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // поискСтудентовИПредприятийToolStripMenuItem
            // 
            this.поискСтудентовИПредприятийToolStripMenuItem.Name = "поискСтудентовИПредприятийToolStripMenuItem";
            this.поискСтудентовИПредприятийToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.поискСтудентовИПредприятийToolStripMenuItem.Text = "Поиск студентов и предприятий";
            this.поискСтудентовИПредприятийToolStripMenuItem.Click += new System.EventHandler(this.поискСтудентовИПредприятийToolStripMenuItem_Click);
            // 
            // журналыToolStripMenuItem
            // 
            this.журналыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прохождениеПрактикиToolStripMenuItem});
            this.журналыToolStripMenuItem.Name = "журналыToolStripMenuItem";
            this.журналыToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.журналыToolStripMenuItem.Text = "Журналы";
            // 
            // прохождениеПрактикиToolStripMenuItem
            // 
            this.прохождениеПрактикиToolStripMenuItem.Name = "прохождениеПрактикиToolStripMenuItem";
            this.прохождениеПрактикиToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.прохождениеПрактикиToolStripMenuItem.Text = "Прохождение практики";
            this.прохождениеПрактикиToolStripMenuItem.Click += new System.EventHandler(this.прохождениеПрактикиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрСправкиToolStripMenuItem,
            this.настройкаПаролейToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // просмотрСправкиToolStripMenuItem
            // 
            this.просмотрСправкиToolStripMenuItem.Name = "просмотрСправкиToolStripMenuItem";
            this.просмотрСправкиToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.просмотрСправкиToolStripMenuItem.Text = "Просмотр справки";
            this.просмотрСправкиToolStripMenuItem.Click += new System.EventHandler(this.просмотрСправкиToolStripMenuItem_Click);
            // 
            // настройкаПаролейToolStripMenuItem
            // 
            this.настройкаПаролейToolStripMenuItem.Name = "настройкаПаролейToolStripMenuItem";
            this.настройкаПаролейToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.настройкаПаролейToolStripMenuItem.Text = "Настройка паролей";
            this.настройкаПаролейToolStripMenuItem.Click += new System.EventHandler(this.настройкаПаролейToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // UndergraduatePracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = global::UndergraduatePractice.Properties.Resources._1601964775_content_700x455;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 359);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UndergraduatePracticeForm";
            this.Text = "Система прохождения преддипломной практики студентами вуза";
            this.Load += new System.EventHandler(this.UndergraduatePracticeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem данныеToolStripMenuItem;
        private ToolStripMenuItem вузToolStripMenuItem;
        private ToolStripMenuItem факультетToolStripMenuItem;
        private ToolStripMenuItem формаОбученияToolStripMenuItem;
        private ToolStripMenuItem специальностьToolStripMenuItem;
        private ToolStripMenuItem группаToolStripMenuItem;
        private ToolStripMenuItem студентToolStripMenuItem;
        private ToolStripMenuItem предприятиеToolStripMenuItem;
        private ToolStripMenuItem руководительОтВузаToolStripMenuItem;
        private ToolStripMenuItem запросыToolStripMenuItem;
        private ToolStripMenuItem журналыToolStripMenuItem;
        private ToolStripMenuItem прохождениеПрактикиToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem просмотрСправкиToolStripMenuItem;
        private ToolStripMenuItem настройкаПаролейToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem поискСтудентовИПредприятийToolStripMenuItem;
    }
}