namespace UndergraduatePractice
{
    partial class PasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChange));
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordConfirm = new System.Windows.Forms.Label();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 24);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(107, 20);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Пользователь";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 80);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(115, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Новый пароль:";
            // 
            // labelPasswordConfirm
            // 
            this.labelPasswordConfirm.Location = new System.Drawing.Point(12, 116);
            this.labelPasswordConfirm.Name = "labelPasswordConfirm";
            this.labelPasswordConfirm.Size = new System.Drawing.Size(137, 45);
            this.labelPasswordConfirm.TabIndex = 2;
            this.labelPasswordConfirm.Text = "Подтверждение нового пароля:";
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Location = new System.Drawing.Point(155, 21);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(170, 28);
            this.comboBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(155, 77);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(170, 27);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(155, 134);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(170, 27);
            this.textBoxPasswordConfirm.TabIndex = 5;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.LightGray;
            this.buttonChange.Location = new System.Drawing.Point(94, 184);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(156, 32);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Изменить практос";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(337, 228);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.labelPasswordConfirm);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordChange";
            this.Text = "Настройка паролей";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLogin;
        private Label labelPassword;
        private Label labelPasswordConfirm;
        private ComboBox comboBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxPasswordConfirm;
        private Button buttonChange;
    }
}