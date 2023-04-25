using System.Text.RegularExpressions;

namespace UndergraduatePractice.Directories
{
    public partial class Speciality : Form
    {
        public Speciality()
        {
            InitializeComponent();
        }

        int n;

        private void Speciality_Load(object sender, EventArgs e)
        {
            string sql = "SELECT speciality.spec_Id AS \"Код\", speciality.name AS \"Название\", " +
               "speciality.short_Name AS \"Краткое название\", CONCAT(faculty.fac_id, ': ', faculty.name) AS \"Код факультета\" FROM speciality " +
               "JOIN faculty ON speciality.fac_id = faculty.fac_id";

            UndergraduatePracticeForm.TableFill("Специальность", sql);

            sql = "SELECT CONCAT(faculty.fac_id, ': ', faculty.name) AS \"Код\" FROM faculty";

            UndergraduatePracticeForm.TableFill("Код факультета", sql);

            if (UndergraduatePracticeForm.ds.Tables["Код факультета"]?.Rows.Count > 0)
            {
                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Код факультета"]?.Rows.Count; i++)
                {
                    comboFacUnCode.Items.Add(UndergraduatePracticeForm.ds.Tables["Код факультета"]?.Rows[i]["Код"]);
                }
            }

            if (UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Count > 0)
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
            comboFacUnCode.SelectedIndex = -1;
            maskedTextBoxCode.Focus();
            maskedTextBoxCode.Enabled = true;
        }

        private void FieldsFormFill()
        {
            maskedTextBoxCode.Text = UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows[n]["Код"].ToString();
            textBoxName.Text = UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows[n]["Название"].ToString();
            textBoxShortName.Text = UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows[n]["Краткое название"].ToString();
            comboFacUnCode.Text = UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows[n]["Код факультета"].ToString();
            maskedTextBoxCode.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (n < UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Count)
                n++;
            if (UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            n = UndergraduatePracticeForm.ds.Tables["Специальность"]!.Rows.Count;
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
            if (UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            string pattern = @"\w+";

            Match facCode = Regex.Match(comboFacUnCode.Text, pattern, RegexOptions.IgnoreCase);
            if (n == UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Count)
            {
                sql = "INSERT INTO speciality values " +
                    "(" + "'" + maskedTextBoxCode.Text + "','" + textBoxName.Text + "','" + textBoxShortName.Text + "'," + facCode.Value + ")";

                if (textBoxName.Text == "" || textBoxShortName.Text == "" || maskedTextBoxCode.Text == ""
                    || comboFacUnCode.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить все поля!", "Внимание");
                    return;
                }

                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Count; i++)
                {
                    if (maskedTextBoxCode.Text == UndergraduatePracticeForm.ds.Tables["Специальность"]!.Rows[i]["Код"].ToString())
                    {
                        MessageBox.Show("Специальность с таким кодом уже существует!!!", "Внимание");
                        return;
                    }
                }

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Add(new object[] { maskedTextBoxCode.Text,
                textBoxName.Text, textBoxShortName.Text, comboFacUnCode.Text, });
                MessageBox.Show("Вы успешно добавили новую запись!!!", "Внимание!");
            }
            else
            {
                sql = "UPDATE speciality SET spec_Id='" + maskedTextBoxCode.Text + "', Name='" + textBoxName.Text +
                    "', short_Name='" + textBoxShortName.Text + "', fac_Id=" + facCode.Value + " WHERE spec_Id='" + maskedTextBoxCode.Text + "'";

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Специальность"]!.Rows[n].ItemArray = new object[]
                {
                    maskedTextBoxCode.Text,
                    textBoxName.Text,
                    textBoxShortName.Text,
                    comboFacUnCode.Text,
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

            string sql = "DELETE FROM speciality WHERE spec_Id='" + maskedTextBoxCode.Text + "'";

            if (UndergraduatePracticeForm.ModificationExecute(sql))
            {
                try
                {
                    UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.RemoveAt(n);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!!!", "Ошибка");
                    return;
                }
            }
            if (UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }
    }
}
