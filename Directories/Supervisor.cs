using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndergraduatePractice.Directories
{
    public partial class Supervisor : Form
    {
        public Supervisor()
        {
            InitializeComponent();
        }

        private static string name = "Руководитель";
        private static string sql = $"select last_value AS {name} from supervisor_sup_id_seq";

        int n;
        private static int count = int.Parse(UndergraduatePracticeForm.GetNextVal(name, sql)) + 1;

        private void Supervisor_Load(object sender, EventArgs e)
        {
            string sql = "SELECT supervisor.sup_id AS \"Код\", supervisor.first_name AS \"Имя\", " +
                "supervisor.surname AS \"Отчество\", supervisor.last_name AS \"Фамилия\", supervisor.post AS \"Должность\" FROM supervisor ORDER BY sup_id";

            UndergraduatePracticeForm.TableFill("Руководитель", sql);

            if (UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void FieldsFormClear()
        {
            textBoxCode.Text = count.ToString();
            textBoxFirstName.Text = "";
            textBoxSurname.Text = "";
            textBoxLastName.Text = "";
            comboBoxPost.SelectedIndex = -1;
            textBoxLastName.Focus();
        }

        private void FieldsFormFill()
        {
            textBoxCode.Text = UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows[n]["Код"].ToString();
            textBoxFirstName.Text = UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows[n]["Имя"].ToString();
            textBoxSurname.Text = UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows[n]["Отчество"].ToString();
            textBoxLastName.Text = UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows[n]["Фамилия"].ToString();
            comboBoxPost.Text = UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows[n]["Должность"].ToString();
            textBoxCode.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (n < UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows.Count)
                n++;
            if (UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            n = UndergraduatePracticeForm.ds.Tables["Руководитель"]!.Rows.Count;
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
            if (UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (n == UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows.Count)
            {
                sql = "INSERT INTO supervisor (first_name, surname, last_name, post) values " +
                    "(" + "'" + textBoxFirstName.Text + "','" + textBoxSurname.Text + "','" + textBoxLastName + "','" + comboBoxPost.Text + "')";

                if (textBoxFirstName.Text == "" || textBoxSurname.Text == "" || textBoxLastName.Text == ""
                    || comboBoxPost.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить все поля!", "Внимание");
                    return;
                }

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows.Add(new object[] { textBoxCode.Text,
                textBoxFirstName.Text, textBoxSurname.Text, textBoxLastName.Text, comboBoxPost.Text,});
                count++;
                MessageBox.Show("Вы успешно добавили новую запись!!!", "Внимание!");
            }
            else
            {
                sql = "UPDATE supervisor SET first_name='" + textBoxFirstName.Text + "', surname='" + textBoxSurname.Text +
                    "', last_name='" + textBoxLastName.Text + "', post='" + comboBoxPost.Text + "' WHERE sup_id=" + textBoxCode.Text;

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Руководитель"]!.Rows[n].ItemArray = new object[]
                {
                    textBoxCode.Text,
                    textBoxFirstName.Text,
                    textBoxSurname.Text,
                    textBoxLastName.Text,
                    comboBoxPost.Text,
                };
                MessageBox.Show("Вы успешно обновили запись!!!", "Внимание!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить запись из базы данных с кодом " + textBoxCode.Text + "?",
                "Удаление записи", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            string sql = "DELETE FROM supervisor WHERE sup_id=" + textBoxCode.Text;

            if (UndergraduatePracticeForm.ModificationExecute(sql))
            {
                try
                {
                    UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows.RemoveAt(n);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!!!", "Ошибка");
                    return;
                }
            }
            if (UndergraduatePracticeForm.ds.Tables["Руководитель"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }
    }
}
