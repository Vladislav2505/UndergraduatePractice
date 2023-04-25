namespace UndergraduatePractice.Journal
{
    partial class Internship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Internship));
            this.labelStudentCode = new System.Windows.Forms.Label();
            this.labelSupervisorCode = new System.Windows.Forms.Label();
            this.labelCompanyCode = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelWork = new System.Windows.Forms.Label();
            this.comboBoxStudentCode = new System.Windows.Forms.ComboBox();
            this.comboBoxSupervisorCode = new System.Windows.Forms.ComboBox();
            this.comboBoxCompanyCode = new System.Windows.Forms.ComboBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.comboBoxWork = new System.Windows.Forms.ComboBox();
            this.buttonUpdateInternship = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonAddSupervisor = new System.Windows.Forms.Button();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudentCode
            // 
            this.labelStudentCode.AutoSize = true;
            this.labelStudentCode.Location = new System.Drawing.Point(29, 31);
            this.labelStudentCode.Name = "labelStudentCode";
            this.labelStudentCode.Size = new System.Drawing.Size(65, 20);
            this.labelStudentCode.TabIndex = 0;
            this.labelStudentCode.Text = "Студент:";
            // 
            // labelSupervisorCode
            // 
            this.labelSupervisorCode.AutoSize = true;
            this.labelSupervisorCode.Location = new System.Drawing.Point(29, 79);
            this.labelSupervisorCode.Name = "labelSupervisorCode";
            this.labelSupervisorCode.Size = new System.Drawing.Size(160, 20);
            this.labelSupervisorCode.TabIndex = 1;
            this.labelSupervisorCode.Text = "Руководитель от вуза:";
            // 
            // labelCompanyCode
            // 
            this.labelCompanyCode.AutoSize = true;
            this.labelCompanyCode.Location = new System.Drawing.Point(29, 131);
            this.labelCompanyCode.Name = "labelCompanyCode";
            this.labelCompanyCode.Size = new System.Drawing.Size(106, 20);
            this.labelCompanyCode.TabIndex = 2;
            this.labelCompanyCode.Text = "Предприятие:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(29, 184);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(176, 20);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Фамилия руководителя:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(29, 237);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(142, 20);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "Имя руководителя:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(29, 291);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(175, 20);
            this.labelSurname.TabIndex = 10;
            this.labelSurname.Text = "Отчество руководителя:";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(29, 344);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(189, 20);
            this.labelPost.TabIndex = 12;
            this.labelPost.Text = "Должность руководителя:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(29, 399);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(97, 20);
            this.labelStartDate.TabIndex = 14;
            this.labelStartDate.Text = "Дата начала:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(219, 394);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(159, 27);
            this.dateTimePickerStart.TabIndex = 15;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(398, 399);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(124, 20);
            this.labelEndDate.TabIndex = 16;
            this.labelEndDate.Text = "Дата окончания:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(528, 394);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(165, 27);
            this.dateTimePickerEnd.TabIndex = 17;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(29, 451);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(64, 20);
            this.labelGrade.TabIndex = 18;
            this.labelGrade.Text = "Оценка:";
            // 
            // labelWork
            // 
            this.labelWork.AutoSize = true;
            this.labelWork.Location = new System.Drawing.Point(29, 501);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(178, 20);
            this.labelWork.TabIndex = 19;
            this.labelWork.Text = "Работа на предприятии:";
            // 
            // comboBoxStudentCode
            // 
            this.comboBoxStudentCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentCode.FormattingEnabled = true;
            this.comboBoxStudentCode.Location = new System.Drawing.Point(219, 27);
            this.comboBoxStudentCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStudentCode.Name = "comboBoxStudentCode";
            this.comboBoxStudentCode.Size = new System.Drawing.Size(379, 28);
            this.comboBoxStudentCode.TabIndex = 20;
            // 
            // comboBoxSupervisorCode
            // 
            this.comboBoxSupervisorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupervisorCode.FormattingEnabled = true;
            this.comboBoxSupervisorCode.Location = new System.Drawing.Point(219, 75);
            this.comboBoxSupervisorCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSupervisorCode.Name = "comboBoxSupervisorCode";
            this.comboBoxSupervisorCode.Size = new System.Drawing.Size(379, 28);
            this.comboBoxSupervisorCode.TabIndex = 21;
            // 
            // comboBoxCompanyCode
            // 
            this.comboBoxCompanyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompanyCode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCompanyCode.FormattingEnabled = true;
            this.comboBoxCompanyCode.Location = new System.Drawing.Point(219, 127);
            this.comboBoxCompanyCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCompanyCode.Name = "comboBoxCompanyCode";
            this.comboBoxCompanyCode.Size = new System.Drawing.Size(379, 21);
            this.comboBoxCompanyCode.TabIndex = 22;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(219, 180);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(379, 27);
            this.textBoxLastName.TabIndex = 23;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(219, 233);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(379, 27);
            this.textBoxFirstName.TabIndex = 24;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(219, 287);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(379, 27);
            this.textBoxSurname.TabIndex = 25;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(219, 340);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(379, 27);
            this.textBoxPost.TabIndex = 26;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "Без оценки"});
            this.comboBoxGrade.Location = new System.Drawing.Point(219, 447);
            this.comboBoxGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(131, 28);
            this.comboBoxGrade.TabIndex = 27;
            // 
            // comboBoxWork
            // 
            this.comboBoxWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWork.FormattingEnabled = true;
            this.comboBoxWork.Items.AddRange(new object[] {
            "Да",
            "Нет",
            "Не знаю"});
            this.comboBoxWork.Location = new System.Drawing.Point(219, 497);
            this.comboBoxWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxWork.Name = "comboBoxWork";
            this.comboBoxWork.Size = new System.Drawing.Size(131, 28);
            this.comboBoxWork.TabIndex = 28;
            // 
            // buttonUpdateInternship
            // 
            this.buttonUpdateInternship.Location = new System.Drawing.Point(629, 495);
            this.buttonUpdateInternship.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdateInternship.Name = "buttonUpdateInternship";
            this.buttonUpdateInternship.Size = new System.Drawing.Size(184, 41);
            this.buttonUpdateInternship.TabIndex = 29;
            this.buttonUpdateInternship.Text = "Обновить практику";
            this.buttonUpdateInternship.UseVisualStyleBackColor = true;
            this.buttonUpdateInternship.Click += new System.EventHandler(this.buttonUpdateInternship_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(616, 25);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(191, 31);
            this.buttonAddStudent.TabIndex = 30;
            this.buttonAddStudent.Text = "Добавить студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonAddSupervisor
            // 
            this.buttonAddSupervisor.Location = new System.Drawing.Point(616, 73);
            this.buttonAddSupervisor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddSupervisor.Name = "buttonAddSupervisor";
            this.buttonAddSupervisor.Size = new System.Drawing.Size(191, 31);
            this.buttonAddSupervisor.TabIndex = 31;
            this.buttonAddSupervisor.Text = "Добавить руководителя";
            this.buttonAddSupervisor.UseVisualStyleBackColor = true;
            this.buttonAddSupervisor.Click += new System.EventHandler(this.buttonAddSupervisor_Click);
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Location = new System.Drawing.Point(616, 120);
            this.buttonAddCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(191, 31);
            this.buttonAddCompany.TabIndex = 32;
            this.buttonAddCompany.Text = "Добавить предприятие";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            this.buttonAddCompany.Click += new System.EventHandler(this.buttonAddCompany_Click);
            // 
            // Internship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(825, 549);
            this.Controls.Add(this.buttonAddCompany);
            this.Controls.Add(this.buttonAddSupervisor);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonUpdateInternship);
            this.Controls.Add(this.comboBoxWork);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.comboBoxCompanyCode);
            this.Controls.Add(this.comboBoxSupervisorCode);
            this.Controls.Add(this.comboBoxStudentCode);
            this.Controls.Add(this.labelWork);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelCompanyCode);
            this.Controls.Add(this.labelSupervisorCode);
            this.Controls.Add(this.labelStudentCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Internship";
            this.Text = "Прохождение практики";
            this.Activated += new System.EventHandler(this.Internship_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Internship_FormClosed);
            this.Load += new System.EventHandler(this.Internship_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelStudentCode;
        private Label labelSupervisorCode;
        private Label labelCompanyCode;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelSurname;
        private Label labelPost;
        private Label labelStartDate;
        private DateTimePicker dateTimePickerStart;
        private Label labelEndDate;
        private DateTimePicker dateTimePickerEnd;
        private Label labelGrade;
        private Label labelWork;
        private ComboBox comboBoxStudentCode;
        private ComboBox comboBoxSupervisorCode;
        private ComboBox comboBoxCompanyCode;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxSurname;
        private TextBox textBoxPost;
        private ComboBox comboBoxGrade;
        private ComboBox comboBoxWork;
        private Button buttonUpdateInternship;
        private Button buttonAddStudent;
        private Button buttonAddSupervisor;
        private Button buttonAddCompany;
    }
}