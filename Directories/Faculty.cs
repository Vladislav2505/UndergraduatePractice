using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndergraduatePractice.Directories
{
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        int n;

        private void Faculty_Load(object sender, EventArgs e)
        {
            string sql = "select faculty.fac_id AS \"Код\", faculty.name AS \"Название\", faculty.short_name \"Краткое название\", " +
                "CONCAT(university.un_Code, ': ', university.short_name) AS \"Код вуза\" " +
                "FROM faculty JOIN university ON faculty.un_Code = university.un_Code;";



            UndergraduatePracticeForm.TableFill("Факультет", sql);

            sql = "SELECT CONCAT(university.un_Code, ': ', university.short_name) AS \"Код\" FROM university ORDER BY un_Code";

            UndergraduatePracticeForm.TableFill("Код вуза", sql);

            if (UndergraduatePracticeForm.ds.Tables["Код вуза"]?.Rows.Count > 0)
            {
                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Код вуза"]?.Rows.Count; i++)
                {
                    comboBoxUnCode.Items.Add(UndergraduatePracticeForm.ds.Tables["Код вуза"]?.Rows[i]["Код"]);
                }
            }

            if (UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void FieldsFormClear()
        {
            maskedTextBoxCode.Text = "";
            textBoxName.Text = "";
            textBoxShortName.Text = "";
            comboBoxUnCode.SelectedIndex = -1;
            maskedTextBoxCode.Focus();
            maskedTextBoxCode.Enabled = true;
        }

        private void FieldsFormFill()
        {
            maskedTextBoxCode.Text = UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows[n]["Код"].ToString();
            textBoxName.Text = UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows[n]["Название"].ToString();
            textBoxShortName.Text = UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows[n]["Краткое название"].ToString();
            comboBoxUnCode.Text = UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows[n]["Код вуза"].ToString();
            maskedTextBoxCode.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (n < UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.Count)
                n++;
            if (UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            n = UndergraduatePracticeForm.ds.Tables["Факультет"]!.Rows.Count;
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
            if (UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            string pattern = @"\w+";

            Match unCode = Regex.Match(comboBoxUnCode.Text, pattern, RegexOptions.IgnoreCase);

            if (n == UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.Count)
            {
                sql = "INSERT INTO faculty values " +
                    "(" + "" + maskedTextBoxCode.Text + ",'" + textBoxName.Text + "','" + textBoxShortName.Text + "'," + unCode.Value + ")";

                if (textBoxName.Text == "" || textBoxShortName.Text == "" || maskedTextBoxCode.Text == ""
                    || comboBoxUnCode.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить все поля!", "Внимание");
                    return;
                }

                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.Count; i++)
                {
                    if (maskedTextBoxCode.Text == UndergraduatePracticeForm.ds.Tables["Факультет"]!.Rows[i]["Код"].ToString())
                    {
                        MessageBox.Show("Факультет с таким кодом уже существует!!!", "Внимание");
                        return;
                    }
                }

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.Add(new object[] { maskedTextBoxCode.Text,
                textBoxName.Text, textBoxShortName.Text, comboBoxUnCode.Text });
                MessageBox.Show("Вы успешно добавили новую запись!!!", "Внимание!");
            }
            else
            {
                sql = "UPDATE faculty SET fac_Id='" + maskedTextBoxCode.Text + "', Name='" + textBoxName.Text +
                    "', short_Name='" + textBoxShortName.Text + "', un_Code='" + unCode.Value + "' WHERE fac_Id=" + maskedTextBoxCode.Text;

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Факультет"]!.Rows[n].ItemArray = new object[]
                {
                    maskedTextBoxCode.Text,
                    textBoxName.Text,
                    textBoxShortName.Text,
                    comboBoxUnCode.Text,
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

            string sql = "DELETE FROM faculty WHERE fac_Id=" + maskedTextBoxCode.Text;

            if (UndergraduatePracticeForm.ModificationExecute(sql))
            {
                try
                {
                    UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.RemoveAt(n);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!!!", "Ошибка");
                    return;
                }
            }
            if (UndergraduatePracticeForm.ds.Tables["Факультет"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }
    }
}
