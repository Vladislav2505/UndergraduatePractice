using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndergraduatePractice
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
            radioButton4.Checked = true;
            string sql;

            sql = "SELECT CONCAT(student.rec_book_id, ': ', student.last_name, ' ', student.first_name) AS Студент, speciality.name AS Специальность, " +
                "un_Group.stream AS Поток, company.short_name AS Предприятие, company.address AS Адрес, internship.start_date AS Начало, " +
                "internship.end_date AS Конец, internship.grade AS Оценка FROM internship " +
                "JOIN student ON internship.rec_book_id = student.rec_book_id JOIN company ON internship.cmp_id = company.cmp_id " +
                "JOIN un_Group ON student.gp_id = un_group.gp_id JOIN speciality ON un_Group.spec_id = speciality.spec_id";

            UndergraduatePracticeForm.TableFill("Выборка", sql);

            sql = "SELECT short_name AS Название FROM company";
            UndergraduatePracticeForm.TableFill("Предприятия", sql);

            for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Предприятия"]?.Rows.Count; i++)
            {
                comboBox1.Items.Add(UndergraduatePracticeForm.ds.Tables["Предприятия"]?.Rows[i]["Название"]);
            }

            sql = "SELECT name AS Название FROM speciality";
            UndergraduatePracticeForm.TableFill("Специальность", sql);

            for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows.Count; i++)
            {
                comboBox2.Items.Add(UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows[i]["Название"]);
                comboBox3.Items.Add(UndergraduatePracticeForm.ds.Tables["Специальность"]?.Rows[i]["Название"]);
            }

            dataGridViewSelection.DataSource = UndergraduatePracticeForm.ds.Tables["Выборка"];
            dataGridViewSelection.BackgroundColor = SystemColors.Control;
            dataGridViewSelection.BorderStyle = BorderStyle.None;
            dataGridViewSelection.RowHeadersVisible = false;
            dataGridViewSelection.AllowUserToAddRows = false;
            dataGridViewSelection.AutoResizeColumns();
            dataGridViewSelection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            for (int i = 0; i < dataGridViewSelection.Columns.Count; i++)
            {
                dataGridViewSelection.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void radioButton4_Click(object sender, EventArgs e)
        {
            dataGridViewSelection.DataSource = UndergraduatePracticeForm.ds.Tables["Выборка"];
            dataGridViewSelection.CurrentCell = null;
            dataGridViewSelection.AutoResizeColumns();
            listBox1.Hide();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы должны выбрать предприятие!!!", "Внимание");
                radioButton4.Checked = true;
                return;
            }

            listBox1.Items.Clear();
            string sql = $"SELECT Студент FROM test WHERE Предприятие = '{comboBox1.Text}' and ('{dateTimePicker1.Value:dd.MM.yyyy}' >= Начало AND '{dateTimePicker2.Value:dd.MM.yyyy}' <= Конец)";
            //DataView view = new DataView(UndergraduatePracticeForm.ds.Tables["Выборка"]);
            //view.RowFilter = $"[Предприятие] = '{comboBox1.Text}' and ('{dateTimePicker1.Value:dd.MM.yyyy}' >= [Начало] AND '{dateTimePicker2.Value:dd.MM.yyyy}' <= [Конец])";
            UndergraduatePracticeForm.TableFill("Выборка студентов 1", sql);

            dataGridViewSelection.DataSource = UndergraduatePracticeForm.ds.Tables["Выборка студентов 1"];
            dataGridViewSelection.CurrentCell = null;
            listBox1.Items.Add($"Кол-во студентов: {UndergraduatePracticeForm.ds.Tables["Выборка студентов 1"]?.Rows.Count}");
            listBox1.Show();
            dataGridViewSelection.AutoResizeColumns();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Вы должны выбрать специальность!!!", "Внимание");
                radioButton4.Checked = true;
                return;
            }

            string sql = $"select DISTINCT Предприятие AS Предприятия from test where Специальность = '{comboBox2.Text}' AND " +
                $"('{dateTimePicker3.Value:dd.MM.yyyy}' >= Начало AND '{dateTimePicker4.Value:dd.MM.yyyy}' <= Конец) ORDER BY Предприятие";

            UndergraduatePracticeForm.TableFill("Выборка предприятий", sql);

            dataGridViewSelection.DataSource = UndergraduatePracticeForm.ds.Tables["Выборка предприятий"];
            dataGridViewSelection.AutoResizeColumns();
            dataGridViewSelection.CurrentCell = null;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Вы должны выбрать специальность и поток!!!", "Внимание");
                radioButton4.Checked = true;
                return;
            }

            string sql = $"SELECT Студент AS Студенты FROM test WHERE Специальность = '{comboBox3.Text}' AND Поток = '{comboBox4.Text}' AND Оценка = 'Без оценки'";

            UndergraduatePracticeForm.TableFill("Выборка студентов 2", sql);

            dataGridViewSelection.DataSource = UndergraduatePracticeForm.ds.Tables["Выборка студентов 2"];
            dataGridViewSelection.AutoResizeColumns();
            dataGridViewSelection.CurrentCell = null;
        }
    }
}
