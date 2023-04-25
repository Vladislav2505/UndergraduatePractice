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

namespace UndergraduatePractice.Journal
{
    public partial class InternshipList : Form
    {
        public InternshipList()
        {
            InitializeComponent();
        }

        public static int n = -1;

        private void InternshipList_Load(object sender, EventArgs e)
        {
            if (Authorization.user == "")
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
            }

            string sql = "select CONCAT(student.rec_book_id, ': ', student.last_name, ' ', student.first_name) AS \"Студент\", " +
                "CONCAT(supervisor.sup_id, ': ', supervisor.last_name, ' ', supervisor.first_name) AS \"Руководитель от вуза\"," +
                " CONCAT(company.cmp_id, ': ', company.name) AS \"Предприятие\", CONCAT_WS(' ', internship.last_name, internship.surname, internship.first_name) AS \"Руководитель от предприятия\", " +
                "internship.post AS \"Должность\", internship.start_date AS \"Дата начала\", internship.end_date AS \"Дата окончания\", " +
                "internship.grade AS Оценка, internship.enterprise_work AS \"Последующая работа\" " +
                "FROM internship JOIN student ON internship.rec_book_id = student.rec_book_id " +
                "JOIN supervisor ON internship.sup_id = supervisor.sup_id JOIN company ON internship.cmp_id = company.cmp_id";

            UndergraduatePracticeForm.TableFill("Практика", sql);

            dataGridViewInList.DataSource = UndergraduatePracticeForm.ds.Tables["Практика"];
            dataGridViewInList.BackgroundColor = SystemColors.Control;
            dataGridViewInList.BorderStyle = BorderStyle.None;
            dataGridViewInList.RowHeadersVisible = false;
            dataGridViewInList.AllowUserToAddRows = false;
            dataGridViewInList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            for (int i = 0; i < dataGridViewInList.Columns.Count; i++)
            {
                dataGridViewInList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void InternshipList_Activated(object sender, EventArgs e)
        {
            dataGridViewInList.AutoResizeColumns();
            dataGridViewInList.CurrentCell = null;
        }

        public static bool isAdd = false;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            n = dataGridViewInList.Rows.Count;

            UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows.Add(new object[] { null, null, null, null, null, null, null, null });
            dataGridViewInList.CurrentCell = null;

            Internship internship = new Internship();
            internship.Show();
        }

        private void dataGridViewInList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = dataGridViewInList.CurrentRow.Index;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            new Internship().Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string msg;

            try
            {
                msg = $"Вы точно хотите удалить запись о практике студента {dataGridViewInList.Rows[n].Cells["Студент"].Value}?";
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не указана удаляемая запись таблицы!!!", "Ошибка");
                return;
            }

            DialogResult result = MessageBox.Show(msg, "Удаление записи", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            string pattern = @"\w+";
            Match matchSt = Regex.Match(dataGridViewInList.Rows[n].Cells["Студент"].Value.ToString(), pattern, RegexOptions.IgnoreCase);

            string sql = "DELETE FROM internship WHERE rec_book_id='" + matchSt.Value + "'";

            if (UndergraduatePracticeForm.ModificationExecute(sql))
                UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows.RemoveAt(n);
            dataGridViewInList.AutoResizeColumns();
            dataGridViewInList.CurrentCell = null;
            n = -1;
        }
    }
}
