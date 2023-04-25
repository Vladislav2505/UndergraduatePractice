using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndergraduatePractice
{
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            string sql;

            sql = "SELECT * FROM users ORDER BY login";

            UndergraduatePracticeForm.TableFill("Пользователь", sql);

            for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Пользователь"]?.Rows.Count; i++)
            {
                comboBoxLogin.Items.Add(UndergraduatePracticeForm.ds.Tables["Пользователь"]?.Rows[i]["login"]);
            }

            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPasswordConfirm.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxPasswordConfirm.Text)
            {
                string sql = $"UPDATE users SET password = '{textBoxPassword.Text}' WHERE login = '{comboBoxLogin.Text}'";
                UndergraduatePracticeForm.ModificationExecute(sql);
                Close();
            }
            else
                MessageBox.Show("Неверное подтверждение пароля");
        }
    }
}
