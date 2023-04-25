namespace UndergraduatePractice.Directories
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipUnCode = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelStudentCode = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.toolTipRecBook = new System.Windows.Forms.ToolTip(this.components);
            this.maskedTextBoxCode = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(567, 20);
            this.toolStripStatusLabelInfo.Text = "Оформление нового студента начинается с ввода номера его зачетной книжки";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(237, 181);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(149, 28);
            this.comboBoxGroup.TabIndex = 43;
            this.toolTipUnCode.SetToolTip(this.comboBoxGroup, "Выберите из списка");
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(25, 143);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(75, 20);
            this.labelSurname.TabIndex = 42;
            this.labelSurname.Text = "Отчество:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(657, 25);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(237, 100);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(405, 27);
            this.textBoxFirstName.TabIndex = 34;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(237, 61);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(405, 27);
            this.textBoxLastName.TabIndex = 32;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(25, 103);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(42, 20);
            this.labelFirstName.TabIndex = 31;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(25, 64);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 30;
            this.labelLastName.Text = "Фамилия:";
            // 
            // labelStudentCode
            // 
            this.labelStudentCode.AutoSize = true;
            this.labelStudentCode.Location = new System.Drawing.Point(25, 27);
            this.labelStudentCode.Name = "labelStudentCode";
            this.labelStudentCode.Size = new System.Drawing.Size(184, 20);
            this.labelStudentCode.TabIndex = 29;
            this.labelStudentCode.Text = "Номер зачетной книжки:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(331, 269);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(310, 35);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Удалить данные";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(490, 229);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(152, 35);
            this.buttonEnd.TabIndex = 40;
            this.buttonEnd.Text = "В конец";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(331, 229);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(152, 35);
            this.buttonForward.TabIndex = 39;
            this.buttonForward.Text = "Вперед";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(16, 269);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(310, 35);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "Сохранить данные";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(174, 229);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 35);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 229);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 35);
            this.buttonStart.TabIndex = 36;
            this.buttonStart.Text = "В начало";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(25, 184);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(61, 20);
            this.labelGroup.TabIndex = 44;
            this.labelGroup.Text = "Группа:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(237, 140);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(405, 27);
            this.textBoxSurname.TabIndex = 45;
            // 
            // maskedTextBoxCode
            // 
            this.maskedTextBoxCode.Location = new System.Drawing.Point(237, 23);
            this.maskedTextBoxCode.Mask = "0000000";
            this.maskedTextBoxCode.Name = "maskedTextBoxCode";
            this.maskedTextBoxCode.Size = new System.Drawing.Size(66, 27);
            this.maskedTextBoxCode.TabIndex = 46;
            this.maskedTextBoxCode.ValidatingType = typeof(int);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(657, 349);
            this.Controls.Add(this.maskedTextBoxCode);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelStudentCode);
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
            this.Name = "Student";
            this.Text = "Студент";
            this.Load += new System.EventHandler(this.Student_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private ToolTip toolTipUnCode;
        private ComboBox comboBoxGroup;
        private Label labelSurname;
        private StatusStrip statusStrip1;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelStudentCode;
        private Button buttonDelete;
        private Button buttonEnd;
        private Button buttonForward;
        private Button buttonSave;
        private Button buttonBack;
        private Button buttonStart;
        private Label labelGroup;
        private TextBox textBoxSurname;
        private ToolTip toolTipRecBook;
        private MaskedTextBox maskedTextBoxCode;
    }
}