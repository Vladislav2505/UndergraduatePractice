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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private static string name = "Компания";
        private static string sql = $"select last_value AS {name} from company_cmp_id_seq";

        int n;
        private static int count = int.Parse(UndergraduatePracticeForm.GetNextVal(name, sql)) + 1;

        private void Company_Load(object sender, EventArgs e)
        {
            string sql = "SELECT company.cmp_id AS \"Код\", company.name AS \"Название\", " +
                "company.short_Name AS \"Краткое название\", company.address AS \"Адрес\" FROM company ORDER BY cmp_id";

            UndergraduatePracticeForm.TableFill("Предприятие", sql);

            if (UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.Count > 0)
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
            textBoxAddress.Text = "";
            textBoxName.Focus();
        }

        private void FieldsFormFill()
        {
            textBoxCode.Text = UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows[n]["Код"].ToString();
            textBoxName.Text = UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows[n]["Название"].ToString();
            textBoxShortName.Text = UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows[n]["Краткое название"].ToString();
            textBoxAddress.Text = UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows[n]["Адрес"].ToString();
            textBoxCode.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (n < UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.Count)
                n++;
            if (UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            n = UndergraduatePracticeForm.ds.Tables["Предприятие"]!.Rows.Count;
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
            if (UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.Count > 0)
            {
                n = 0;
                FieldsFormFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (n == UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.Count)
            {
                sql = "INSERT INTO company (name, short_Name, address) values " +
                    "(" + "'" + textBoxName.Text + "','" + textBoxShortName.Text + "','" + textBoxAddress + "')";

                if (textBoxName.Text == "" || textBoxShortName.Text == "" || textBoxAddress.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить все поля!", "Внимание");
                    return;
                }

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.Add(new object[] { textBoxCode.Text,
                textBoxName.Text, textBoxShortName.Text, textBoxAddress.Text, });
                count++;
                MessageBox.Show("Вы успешно добавили новую запись!!!", "Внимание!");
            }
            else
            {
                sql = "UPDATE company SET name='" + textBoxName.Text + "', short_Name='" + textBoxShortName.Text +
                    "', address='" + textBoxAddress.Text + "' WHERE cmp_Id=" + textBoxCode.Text;

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Предприятие"]!.Rows[n].ItemArray = new object[]
                {
                    textBoxCode.Text,
                    textBoxName.Text,
                    textBoxShortName.Text,
                    textBoxAddress.Text,
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

            string sql = "DELETE FROM company WHERE cmp_Id=" + textBoxCode.Text;

            if (UndergraduatePracticeForm.ModificationExecute(sql))
            {
                try
                {
                    UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.RemoveAt(n);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!!!", "Ошибка");
                    return;
                }
            }
            if (UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.Count > n)
                FieldsFormFill();
            else
                FieldsFormClear();
        }
    }
}
