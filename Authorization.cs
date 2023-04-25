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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public static string user = "";

        private void Authorization_Load(object sender, EventArgs e)
        {
            string sql;

            sql = "SELECT * FROM users ORDER BY login";

            UndergraduatePracticeForm.TableFill("Пользователь", sql);

            for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Пользователь"]?.Rows.Count; i++)
            {
                comboBoxLogin.Items.Add(UndergraduatePracticeForm.ds.Tables["Пользователь"]?.Rows[i]["login"]);
            }

            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == UndergraduatePracticeForm.ds
                .Tables["Пользователь"]?.Rows[comboBoxLogin.SelectedIndex]["password"].ToString())
            {
                if (comboBoxLogin.Text == "Главный руководитель")
                    user = "Администратор";
                else if (comboBoxLogin.Text == "Сотрудник")
                    user = "Сотрудник";

                Hide();
                new UndergraduatePracticeForm().ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
