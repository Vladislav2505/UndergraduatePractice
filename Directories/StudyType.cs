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
    public partial class StudyType : Form
    {
        public StudyType()
        {
            InitializeComponent();
        }

        private static string name = "Обучение";
        private static string sql = $"select last_value AS {name} from study_type_st_id_seq";

        int n;
        private static int count = int.Parse(UndergraduatePracticeForm.GetNextVal(name, sql)) + 1;

        private void StudyType_Load(object sender, EventArgs e)
        {
            string sql = "SELECT study_type.st_Id AS \"Код\", study_type.name AS \"Название\", " +
                "study_type.short_Name AS \"Краткое название\" FROM study_type ORDER BY st_Id";

            UndergraduatePracticeForm.TableFill("Тип обучения", sql);

            if (UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void FieldsFormClear()
        {
            textBoxCode.Text = count.ToString();
            textBoxName.Text = "";
            textBoxShortName.Text = "";
            textBoxName.Focus();
        }

        private void FieldsFormFill()
        {
            textBoxCode.Text = UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows[n]["Код"].ToString();
            textBoxName.Text = UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows[n]["Название"].ToString();
            textBoxShortName.Text = UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows[n]["Краткое название"].ToString();
            textBoxCode.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (n < UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows.Count)
                n++;
            if (UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            n = UndergraduatePracticeForm.ds.Tables["Тип обучения"]!.Rows.Count;
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
            if (UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (n == UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows.Count)
            {
                sql = "INSERT INTO study_type (name, short_Name) values " +
                    "(" + "'" + textBoxName.Text + "','" + textBoxShortName.Text + "')";

                if (textBoxName.Text == "" || textBoxShortName.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить все поля!", "Внимание");
                    return;
                }

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows.Add(new object[] { textBoxCode.Text,
                textBoxName.Text, textBoxShortName.Text });
                count++;
                MessageBox.Show("Вы успешно добавили новую запись!!!", "Внимание!");
            }
            else
            {
                sql = "UPDATE study_type SET name='" + textBoxName.Text + "', short_Name='" + textBoxShortName.Text +
                    "' WHERE st_Id=" + textBoxCode.Text;

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Тип обучения"]!.Rows[n].ItemArray = new object[]
                {
                    textBoxCode.Text,
                    textBoxName.Text,
                    textBoxShortName.Text,
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

            string sql = "DELETE FROM study_type WHERE st_id=" + textBoxCode.Text;

            if (UndergraduatePracticeForm.ModificationExecute(sql))
            {
                try
                {
                    UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows.RemoveAt(n);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!!!", "Ошибка");
                    return;
                }
            }
            if (UndergraduatePracticeForm.ds.Tables["Тип обучения"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }
    }
}
