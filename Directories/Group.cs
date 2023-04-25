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
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        int n;

        private void Group_Load(object sender, EventArgs e)
        {
            string sql = "SELECT un_group.gp_Id AS \"Код\", un_group.stream AS \"Поток\", " +
                "un_group.term_protection AS \"Срок\", CONCAT(study_type.st_id, ': ', study_type.name) AS \"Тип обучения\"," +
                " CONCAT(speciality.spec_Id, ': ', speciality.name) AS \"Код специальности\" FROM un_group " +
                "JOIN study_type ON un_group.st_id = study_type.st_id " +
                "JOIN speciality ON un_group.spec_Id = speciality.spec_Id";

            UndergraduatePracticeForm.TableFill("Группа", sql);

            sql = "SELECT CONCAT(study_type.st_id, ': ', study_type.name) AS \"Тип обучения\" FROM study_type ORDER BY st_Id";
            UndergraduatePracticeForm.TableFill("Название обучения", sql);

            if (UndergraduatePracticeForm.ds.Tables["Название обучения"]?.Rows.Count > 0)
            {
                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Название обучения"]?.Rows.Count; i++)
                {
                    comboBoxStName.Items.
                        Add(UndergraduatePracticeForm.ds.Tables["Название обучения"]?.Rows[i]["Тип обучения"]);
                }
            }

            sql = "SELECT CONCAT(speciality.spec_Id, ': ', speciality.name) AS \"Код специальности\" FROM speciality";
            UndergraduatePracticeForm.TableFill("Код специальности", sql);

            if (UndergraduatePracticeForm.ds.Tables["Код специальности"]?.Rows.Count > 0)
            {
                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Код специальности"]?.Rows.Count; i++)
                {
                    comboBoxSpecCode.Items.
                        Add(UndergraduatePracticeForm.ds.Tables["Код специальности"]?.Rows[i]["Код специальности"]);
                }
            }

            if (UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void FieldsFormClear()
        {
            textBoxCode.Text = "0";
            comboBoxStream.SelectedIndex = -1;
            dateTimePickerTermProtection.Value = DateTime.Now;
            comboBoxStName.SelectedIndex = -1;
            comboBoxSpecCode.SelectedIndex = -1;
            textBoxCode.Focus();
            textBoxCode.Enabled = true;
        }

        private void FieldsFormFill()
        {
            textBoxCode.Text = UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows[n]["Код"].ToString();
            comboBoxStream.Text = UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows[n]["Поток"].ToString();
            dateTimePickerTermProtection.Text = UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows[n]["Срок"].ToString();
            comboBoxStName.Text = UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows[n]["Тип обучения"].ToString();
            comboBoxSpecCode.Text = UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows[n]["Код специальности"].ToString();
            textBoxCode.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (n < UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.Count)
                n++;
            if (UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            n = UndergraduatePracticeForm.ds.Tables["Группа"]!.Rows.Count;
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
            if (UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            string pattern1 = @"[0-9.]+";

            Match stTypeCode = Regex.Match(comboBoxStName.Text, pattern1, RegexOptions.IgnoreCase);
            Match specCode = Regex.Match(comboBoxSpecCode.Text, pattern1, RegexOptions.IgnoreCase);

            if (n == UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.Count)
            {
                sql = "INSERT INTO un_Group values " +
                    "(" + "'" + textBoxCode.Text + "','" + comboBoxStream.Text + "','" + dateTimePickerTermProtection.Text + "'," + stTypeCode.Value + ", " +
                    "'" + specCode.Value + "')";

                if (textBoxCode.Text == "" || comboBoxStream.Text == "" || dateTimePickerTermProtection.Text == ""
                    || comboBoxStName.Text == "" || comboBoxSpecCode.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить все поля!", "Внимание");
                    return;
                }

                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.Count; i++)
                {
                    if (textBoxCode.Text == UndergraduatePracticeForm.ds.Tables["Группа"]!.Rows[i]["Код"].ToString())
                    {
                        MessageBox.Show("Группа с таким номером уже существует!!!", "Внимание");
                        return;
                    }
                }

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.Add(new object[] { textBoxCode.Text,
                comboBoxStream.Text, dateTimePickerTermProtection.Text, comboBoxStName.Text, comboBoxSpecCode.Text, });
                MessageBox.Show("Вы успешно добавили новую запись!!!", "Внимание!");
            }
            else
            {
                sql = "UPDATE un_Group SET gp_Id='" + textBoxCode.Text + "', stream='" + comboBoxStream.Text +
                    "', term_protection='" + dateTimePickerTermProtection.Text + "', st_Id=" + stTypeCode.Value + ", " +
                    "spec_Id='" + specCode.Value + "' WHERE gp_Id='" + textBoxCode.Text + "'";

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Группа"]!.Rows[n].ItemArray = new object[]
                {
                    textBoxCode.Text,
                    comboBoxStream.Text,
                    dateTimePickerTermProtection.Text,
                    comboBoxStName.Text,
                    comboBoxSpecCode.Text,
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

            string sql = "DELETE FROM un_Group WHERE gp_Id='" + textBoxCode.Text + "'";

            if (UndergraduatePracticeForm.ModificationExecute(sql))
            {
                try
                {
                    UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.RemoveAt(n);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!!!", "Ошибка");
                    return;
                }
            }
            if (UndergraduatePracticeForm.ds.Tables["Группа"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }
    }
}
