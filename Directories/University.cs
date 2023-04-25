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
    public partial class University : Form
    {
        public University()
        {
            InitializeComponent();
        }

        private static string name = "Вуз";
        private static string sql = $"select last_value AS {name} from university_un_code_seq";

        int n;
        private static int count = int.Parse(UndergraduatePracticeForm.GetNextVal(name, sql)) + 1;
        private void University_Load(object sender, EventArgs e)
        {

            string sql = "SELECT university.un_Code AS \"Код\", university.name AS \"Название\", " +
                "university.short_Name AS \"Краткое название\" FROM university ORDER BY un_Code";

            UndergraduatePracticeForm.TableFill("Вуз", sql);

            if (UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows.Count > 0)
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
            textBoxCode.Text = UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows[n]["Код"].ToString();
            textBoxName.Text = UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows[n]["Название"].ToString();
            textBoxShortName.Text = UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows[n]["Краткое название"].ToString();
            textBoxCode.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (n < UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows.Count)
                n++;
            if (UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            n = UndergraduatePracticeForm.ds.Tables["Вуз"]!.Rows.Count;
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
            if (UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (n == UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows.Count)
            {
                sql = "INSERT INTO university (name, short_Name) values " +
                    "(" + "'" + textBoxName.Text + "','" + textBoxShortName.Text + "')";

                if (textBoxName.Text == "" || textBoxShortName.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить все поля!", "Внимание");
                    return;
                }

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows.Add(new object[] { textBoxCode.Text,
                textBoxName.Text, textBoxShortName.Text });
                count++;
                MessageBox.Show("Вы успешно добавили новую запись!!!", "Внимание!");
            }
            else
            {
                sql = "UPDATE university SET name='" + textBoxName.Text + "', short_Name='" + textBoxShortName.Text +
                    "' WHERE un_Code=" + textBoxCode.Text;

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Вуз"]!.Rows[n].ItemArray = new object[]
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

            string sql = "DELETE FROM university WHERE un_Code=" + textBoxCode.Text;

            if (UndergraduatePracticeForm.ModificationExecute(sql))
            {
                try
                {
                    UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows.RemoveAt(n);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!!!", "Ошибка");
                    return;
                }
            }
            if (UndergraduatePracticeForm.ds.Tables["Вуз"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }
    }
}
