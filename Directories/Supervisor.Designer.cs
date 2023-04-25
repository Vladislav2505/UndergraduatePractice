namespace UndergraduatePractice.Directories
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStudentCode = new System.Windows.Forms.Label();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipChoice = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(239, 23);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(149, 27);
            this.textBoxCode.TabIndex = 50;
            this.toolTipInfo.SetToolTip(this.textBoxCode, "Код задается автоматически");
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(239, 140);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(405, 27);
            this.textBoxSurname.TabIndex = 62;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(27, 184);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(189, 20);
            this.labelPost.TabIndex = 61;
            this.labelPost.Text = "Должность руководителя:";
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Items.AddRange(new object[] {
            "Преподаватель",
            "Работник отдела кадров",
            "Главный психолог",
            "Директор",
            "Глава кафедры",
            "Бухгалтер",
            "Работник деканата"});
            this.comboBoxPost.Location = new System.Drawing.Point(239, 181);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(246, 28);
            this.comboBoxPost.TabIndex = 60;
            this.toolTipChoice.SetToolTip(this.comboBoxPost, "Выберите из списка");
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(27, 143);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(75, 20);
            this.labelSurname.TabIndex = 59;
            this.labelSurname.Text = "Отчество:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 25);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(459, 20);
            this.toolStripStatusLabelInfo.Text = "Оформление нового руководителя начинается с ввода его ФИО";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(239, 100);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(405, 27);
            this.textBoxFirstName.TabIndex = 51;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(239, 61);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(405, 27);
            this.textBoxLastName.TabIndex = 49;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 103);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(42, 20);
            this.labelFirstName.TabIndex = 48;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(27, 64);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 47;
            this.labelLastName.Text = "Фамилия:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(334, 269);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(310, 35);
            this.buttonDelete.TabIndex = 58;
            this.buttonDelete.Text = "Удалить данные";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(491, 229);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(152, 35);
            this.buttonEnd.TabIndex = 57;
            this.buttonEnd.Text = "В конец";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(334, 229);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(152, 35);
            this.buttonForward.TabIndex = 56;
            this.buttonForward.Text = "Вперед";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 269);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(310, 35);
            this.buttonSave.TabIndex = 55;
            this.buttonSave.Text = "Сохранить данные";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(176, 229);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 35);
            this.buttonBack.TabIndex = 54;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(18, 229);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 35);
            this.buttonStart.TabIndex = 53;
            this.buttonStart.Text = "В начало";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelStudentCode
            // 
            this.labelStudentCode.AutoSize = true;
            this.labelStudentCode.Location = new System.Drawing.Point(27, 27);
            this.labelStudentCode.Name = "labelStudentCode";
            this.labelStudentCode.Size = new System.Drawing.Size(38, 20);
            this.labelStudentCode.TabIndex = 46;
            this.labelStudentCode.Text = "Код:";
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(656, 349);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelStudentCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Supervisor";
            this.Text = "Руководитель от вуза";
            this.Load += new System.EventHandler(this.Supervisor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxCode;
        private TextBox textBoxSurname;
        private Label labelPost;
        private ComboBox comboBoxPost;
        private Label labelSurname;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelFirstName;
        private Label labelLastName;
        private Button buttonDelete;
        private Button buttonEnd;
        private Button buttonForward;
        private Button buttonSave;
        private Button buttonBack;
        private Button buttonStart;
        private Label labelStudentCode;
        private ToolTip toolTipInfo;
        private ToolTip toolTipChoice;
    }
}