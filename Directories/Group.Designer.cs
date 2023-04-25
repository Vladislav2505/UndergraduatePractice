namespace UndergraduatePractice.Directories
{
    partial class Group
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group));
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipUnCode = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxSpecCode = new System.Windows.Forms.ComboBox();
            this.comboBoxStName = new System.Windows.Forms.ComboBox();
            this.labelUnCode = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelShortName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTermProtection = new System.Windows.Forms.DateTimePicker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.comboBoxStream = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(380, 20);
            this.toolStripStatusLabelInfo.Text = "Оформление новой группы начинается с ввода кода";
            // 
            // comboBoxSpecCode
            // 
            this.comboBoxSpecCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSpecCode.FormattingEnabled = true;
            this.comboBoxSpecCode.Location = new System.Drawing.Point(232, 130);
            this.comboBoxSpecCode.Name = "comboBoxSpecCode";
            this.comboBoxSpecCode.Size = new System.Drawing.Size(418, 25);
            this.comboBoxSpecCode.TabIndex = 43;
            this.toolTipUnCode.SetToolTip(this.comboBoxSpecCode, "Выберите из списка");
            // 
            // comboBoxStName
            // 
            this.comboBoxStName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStName.FormattingEnabled = true;
            this.comboBoxStName.Location = new System.Drawing.Point(232, 171);
            this.comboBoxStName.Name = "comboBoxStName";
            this.comboBoxStName.Size = new System.Drawing.Size(261, 28);
            this.comboBoxStName.TabIndex = 46;
            this.toolTipUnCode.SetToolTip(this.comboBoxStName, "Выберите из списка");
            // 
            // labelUnCode
            // 
            this.labelUnCode.AutoSize = true;
            this.labelUnCode.Location = new System.Drawing.Point(31, 131);
            this.labelUnCode.Name = "labelUnCode";
            this.labelUnCode.Size = new System.Drawing.Size(148, 20);
            this.labelUnCode.TabIndex = 42;
            this.labelUnCode.Text = "Код специальности:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 315);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(662, 25);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(232, 11);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(132, 27);
            this.textBoxCode.TabIndex = 33;
            // 
            // labelShortName
            // 
            this.labelShortName.AutoSize = true;
            this.labelShortName.Location = new System.Drawing.Point(31, 91);
            this.labelShortName.Name = "labelShortName";
            this.labelShortName.Size = new System.Drawing.Size(171, 20);
            this.labelShortName.TabIndex = 31;
            this.labelShortName.Text = "Срок защиты практики:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 20);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Поток:";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(31, 13);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(38, 20);
            this.labelCode.TabIndex = 29;
            this.labelCode.Text = "Код:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(341, 264);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(310, 35);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Удалить данные";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(498, 223);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(152, 35);
            this.buttonEnd.TabIndex = 40;
            this.buttonEnd.Text = "В конец";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(341, 223);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(152, 35);
            this.buttonForward.TabIndex = 39;
            this.buttonForward.Text = "Вперед";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(24, 264);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(310, 35);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "Сохранить данные";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(182, 223);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 35);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(24, 223);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 35);
            this.buttonStart.TabIndex = 36;
            this.buttonStart.Text = "В начало";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Форма обучения:";
            // 
            // dateTimePickerTermProtection
            // 
            this.dateTimePickerTermProtection.Location = new System.Drawing.Point(232, 85);
            this.dateTimePickerTermProtection.Name = "dateTimePickerTermProtection";
            this.dateTimePickerTermProtection.Size = new System.Drawing.Size(208, 27);
            this.dateTimePickerTermProtection.TabIndex = 45;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // comboBoxStream
            // 
            this.comboBoxStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStream.FormattingEnabled = true;
            this.comboBoxStream.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxStream.Location = new System.Drawing.Point(232, 48);
            this.comboBoxStream.Name = "comboBoxStream";
            this.comboBoxStream.Size = new System.Drawing.Size(132, 28);
            this.comboBoxStream.TabIndex = 47;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(662, 340);
            this.Controls.Add(this.comboBoxStName);
            this.Controls.Add(this.dateTimePickerTermProtection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSpecCode);
            this.Controls.Add(this.labelUnCode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.comboBoxStream);
            this.Controls.Add(this.labelShortName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Group";
            this.Text = "Группа";
            this.Load += new System.EventHandler(this.Group_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private ToolTip toolTipUnCode;
        private ComboBox comboBoxSpecCode;
        private Label labelUnCode;
        private StatusStrip statusStrip1;
        private TextBox textBoxCode;
        private Label labelShortName;
        private Label labelName;
        private Label labelCode;
        private Button buttonDelete;
        private Button buttonEnd;
        private Button buttonForward;
        private Button buttonSave;
        private Button buttonBack;
        private Button buttonStart;
        private Label label1;
        private DateTimePicker dateTimePickerTermProtection;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox comboBoxStName;
        private ComboBox comboBoxStream;
    }
}