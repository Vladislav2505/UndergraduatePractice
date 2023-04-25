namespace UndergraduatePractice.Directories
{
    partial class Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Company));
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelShortName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStudentCode = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(488, 20);
            this.toolStripStatusLabelInfo.Text = "Оформление нового предприятия начинается с ввода его названия";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(239, 24);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(149, 27);
            this.textBoxCode.TabIndex = 67;
            this.toolTipInfo.SetToolTip(this.textBoxCode, "Код задается автоматически");
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(239, 141);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(405, 27);
            this.textBoxAddress.TabIndex = 79;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(27, 144);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(54, 20);
            this.labelAddress.TabIndex = 76;
            this.labelAddress.Text = "Адрес:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(663, 25);
            this.statusStrip1.TabIndex = 69;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Location = new System.Drawing.Point(239, 101);
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(405, 27);
            this.textBoxShortName.TabIndex = 68;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(239, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(405, 27);
            this.textBoxName.TabIndex = 66;
            // 
            // labelShortName
            // 
            this.labelShortName.AutoSize = true;
            this.labelShortName.Location = new System.Drawing.Point(27, 104);
            this.labelShortName.Name = "labelShortName";
            this.labelShortName.Size = new System.Drawing.Size(138, 20);
            this.labelShortName.TabIndex = 65;
            this.labelShortName.Text = "Краткое название:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(27, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 20);
            this.labelName.TabIndex = 64;
            this.labelName.Text = "Название:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(334, 232);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(310, 35);
            this.buttonDelete.TabIndex = 75;
            this.buttonDelete.Text = "Удалить данные";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(492, 191);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(152, 35);
            this.buttonEnd.TabIndex = 74;
            this.buttonEnd.Text = "В конец";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(334, 191);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(152, 35);
            this.buttonForward.TabIndex = 73;
            this.buttonForward.Text = "Вперед";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 232);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(310, 35);
            this.buttonSave.TabIndex = 72;
            this.buttonSave.Text = "Сохранить данные";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(176, 191);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 35);
            this.buttonBack.TabIndex = 71;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(18, 191);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 35);
            this.buttonStart.TabIndex = 70;
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
            this.labelStudentCode.TabIndex = 63;
            this.labelStudentCode.Text = "Код:";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(663, 308);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxShortName);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelShortName);
            this.Controls.Add(this.labelName);
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
            this.Name = "Company";
            this.Text = "Предприятие";
            this.Load += new System.EventHandler(this.Company_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private ToolTip toolTipInfo;
        private TextBox textBoxCode;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private StatusStrip statusStrip1;
        private TextBox textBoxShortName;
        private TextBox textBoxName;
        private Label labelShortName;
        private Label labelName;
        private Button buttonDelete;
        private Button buttonEnd;
        private Button buttonForward;
        private Button buttonSave;
        private Button buttonBack;
        private Button buttonStart;
        private Label labelStudentCode;
    }
}