using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UndergraduatePractice.Directories
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        int n;

        private void Student_Load(object sender, EventArgs e)
        {
            string sql = "SELECT student.rec_book_id AS \"Код\", student.first_Name AS \"Имя\", " +
                "student.surname AS \"Отчество\", student.last_name AS \"Фамилия\"," +
                " student.gp_Id AS \"Код группы\" FROM student";

            UndergraduatePracticeForm.TableFill("Студент", sql);

            sql = "SELECT un_Group.gp_id AS \"Код\" FROM un_Group";
            UndergraduatePracticeForm.TableFill("Код группы", sql);

            if (UndergraduatePracticeForm.ds.Tables["Код группы"]?.Rows.Count > 0)
            {
                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Код группы"]?.Rows.Count; i++)
                {
                    comboBoxGroup.Items.
                        Add(UndergraduatePracticeForm.ds.Tables["Код группы"]?.Rows[i]["Код"]);
                }
            }

            if (UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void FieldsFormClear()
        {
            maskedTextBoxCode.Text = "";
            textBoxFirstName.Text = "";
            textBoxSurname.Text = "";
            textBoxLastName.Text = "";
            comboBoxGroup.SelectedIndex = -1;
            maskedTextBoxCode.Focus();
            maskedTextBoxCode.Enabled = true;
        }

        private void FieldsFormFill()
        {
            maskedTextBoxCode.Text = UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows[n]["Код"].ToString();
            textBoxFirstName.Text = UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows[n]["Имя"].ToString();
            textBoxSurname.Text = UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows[n]["Отчество"].ToString();
            textBoxLastName.Text = UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows[n]["Фамилия"].ToString();
            comboBoxGroup.Text = UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows[n]["Код группы"].ToString();
            maskedTextBoxCode.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (n < UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.Count)
                n++;
            if (UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            n = UndergraduatePracticeForm.ds.Tables["Студент"]!.Rows.Count;
            FieldsFormClear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n--;
                FieldsFormFill();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (n == UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.Count)
            {
                sql = "INSERT INTO student values " +
                    "(" + "'" + maskedTextBoxCode.Text + "','" + textBoxFirstName.Text + "','" + textBoxSurname.Text + "','" + textBoxLastName.Text + "', " +
                    "'" + comboBoxGroup.Text + "')";

                if (maskedTextBoxCode.Text == "" || textBoxFirstName.Text == "" || textBoxSurname.Text == ""
                    || textBoxLastName.Text == "" || comboBoxGroup.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить все поля!", "Внимание!");
                    return;
                }

                if (maskedTextBoxCode.Text.Length != 7)
                {
                    MessageBox.Show("Неправильный формат номера зачетной книжки!!!", "Внимание!");
                    return;
                }

                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.Count; i++)
                {
                    if (maskedTextBoxCode.Text == UndergraduatePracticeForm.ds.Tables["Студент"]!.Rows[i]["Код"].ToString())
                    {
                        MessageBox.Show("Студент с таким номером уже существует!!!", "Внимание!");
                        return;
                    }
                }

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.Add(new object[] { maskedTextBoxCode.Text,
                textBoxFirstName.Text, textBoxSurname.Text, textBoxLastName.Text, comboBoxGroup.Text, });
                MessageBox.Show("Вы успешно добавили новую запись!!!", "Внимание!");
            }
            else
            {
                sql = "UPDATE student SET rec_book_id='" + maskedTextBoxCode.Text + "', first_name='" + textBoxFirstName.Text +
                    "', surname='" + textBoxSurname.Text + "', last_name='" + textBoxLastName.Text + "', " +
                    "gp_id='" + comboBoxGroup.Text + "' WHERE rec_book_id='" + maskedTextBoxCode.Text + "'";

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Студент"]!.Rows[n].ItemArray = new object[]
                {
                    maskedTextBoxCode.Text,
                    textBoxFirstName.Text,
                    textBoxSurname.Text,
                    textBoxLastName.Text,
                    comboBoxGroup.Text,
                };
                MessageBox.Show("Вы успешно обновили запись!!!", "Внимание!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить запись из базы данных с кодом " + maskedTextBoxCode.Text + "?",
                "Удаление записи", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            string sql = "DELETE FROM student WHERE rec_book_id='" + maskedTextBoxCode.Text + "'";

            if (UndergraduatePracticeForm.ModificationExecute(sql))
            {
                try
                {
                    UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.RemoveAt(n);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!!!", "Ошибка");
                    return;
                }
            }
            if (UndergraduatePracticeForm.ds.Tables["Студент"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }
    }
}
