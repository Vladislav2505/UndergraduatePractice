namespace UndergraduatePractice.Directories
{
    partial class Speciality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speciality));
            this.labelFacCode = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelShortName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboFacUnCode = new System.Windows.Forms.ComboBox();
            this.toolTipUnCode = new System.Windows.Forms.ToolTip(this.components);
            this.maskedTextBoxCode = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFacCode
            // 
            this.labelFacCode.AutoSize = true;
            this.labelFacCode.Location = new System.Drawing.Point(32, 139);
            this.labelFacCode.Name = "labelFacCode";
            this.labelFacCode.Size = new System.Drawing.Size(118, 20);
            this.labelFacCode.TabIndex = 41;
            this.labelFacCode.Text = "Код факультета:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 25);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(435, 20);
            this.toolStripStatusLabelInfo.Text = "Оформление новой специальности начинается с ввода кода";
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Location = new System.Drawing.Point(197, 96);
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(447, 27);
            this.textBoxShortName.TabIndex = 33;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(197, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(447, 27);
            this.textBoxName.TabIndex = 31;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 20);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Название:";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(32, 21);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(38, 20);
            this.labelCode.TabIndex = 28;
            this.labelCode.Text = "Код:";
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(491, 184);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(152, 35);
            this.buttonEnd.TabIndex = 39;
            this.buttonEnd.Text = "В конец";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(334, 184);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(152, 35);
            this.buttonForward.TabIndex = 38;
            this.buttonForward.Text = "Вперед";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 225);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(310, 35);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "Сохранить данные";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(176, 184);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 35);
            this.buttonBack.TabIndex = 36;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(18, 184);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 35);
            this.buttonStart.TabIndex = 35;
            this.buttonStart.Text = "В начало";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelShortName
            // 
            this.labelShortName.AutoSize = true;
            this.labelShortName.Location = new System.Drawing.Point(32, 99);
            this.labelShortName.Name = "labelShortName";
            this.labelShortName.Size = new System.Drawing.Size(138, 20);
            this.labelShortName.TabIndex = 30;
            this.labelShortName.Text = "Краткое название:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(334, 225);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(310, 35);
            this.buttonDelete.TabIndex = 40;
            this.buttonDelete.Text = "Удалить данные";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboFacUnCode
            // 
            this.comboFacUnCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFacUnCode.FormattingEnabled = true;
            this.comboFacUnCode.Location = new System.Drawing.Point(197, 136);
            this.comboFacUnCode.Name = "comboFacUnCode";
            this.comboFacUnCode.Size = new System.Drawing.Size(446, 28);
            this.comboFacUnCode.TabIndex = 42;
            this.toolTipUnCode.SetToolTip(this.comboFacUnCode, "Выберите из списка");
            // 
            // maskedTextBoxCode
            // 
            this.maskedTextBoxCode.Location = new System.Drawing.Point(197, 18);
            this.maskedTextBoxCode.Mask = "00\\.00\\.00";
            this.maskedTextBoxCode.Name = "maskedTextBoxCode";
            this.maskedTextBoxCode.Size = new System.Drawing.Size(66, 27);
            this.maskedTextBoxCode.TabIndex = 43;
            // 
            // Speciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(656, 301);
            this.Controls.Add(this.comboFacUnCode);
            this.Controls.Add(this.labelFacCode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxShortName);
            this.Controls.Add(this.maskedTextBoxCode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelShortName);
            this.Controls.Add(this.buttonDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Speciality";
            this.Text = "Специальность";
            this.Load += new System.EventHandler(this.Speciality_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFacCode;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private TextBox textBoxShortName;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelCode;
        private Button buttonEnd;
        private Button buttonForward;
        private Button buttonSave;
        private Button buttonBack;
        private Button buttonStart;
        private Label labelShortName;
        private Button buttonDelete;
        private ComboBox comboFacUnCode;
        private ToolTip toolTipUnCode;
        private MaskedTextBox maskedTextBoxCode;
    }
}