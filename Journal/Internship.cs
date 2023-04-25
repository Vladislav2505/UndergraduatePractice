using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using UndergraduatePractice.Directories;

namespace UndergraduatePractice.Journal
{
    public partial class Internship : Form
    {
        public Internship()
        {
            InitializeComponent();
        }


        private void Internship_Load(object sender, EventArgs e)
        {
            if (!InternshipList.isAdd)
            {
                comboBoxStudentCode.Enabled = false;
                buttonAddStudent.Hide();
                isFull = true;
            }

            try
            {
                string? str = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Руководитель от предприятия"].ToString();
                string[]? fullName = { "", "", "" };

                if (str != "")
                {
                    fullName = UndergraduatePracticeForm.ds.Tables["Практика"]?.
                        Rows[InternshipList.n]["Руководитель от предприятия"].ToString()?.Split(' ');
                }

                comboBoxStudentCode.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Студент"].ToString();
                comboBoxSupervisorCode.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Руководитель от вуза"].ToString();
                comboBoxCompanyCode.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Предприятие"].ToString();
                textBoxLastName.Text = fullName[0];
                textBoxSurname.Text = fullName[1];
                textBoxFirstName.Text = fullName[2];
                textBoxPost.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Должность"].ToString();
                dateTimePickerStart.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Дата начала"].ToString();
                dateTimePickerEnd.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Дата окончания"].ToString();
                comboBoxGrade.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Оценка"].ToString();
                comboBoxWork.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Последующая работа"].ToString();

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Не указана редактируемая запись таблицы!!!", "Ошибка");
                this.Close();
            }
        }

        private void Internship_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (InternshipList.isAdd)
            {
                if (!isFull)
                {
                    isFull = false;

                    UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows.RemoveAt(InternshipList.n);
                }
                InternshipList.n = -1;
            }
            InternshipList.isAdd = false;
        }

        private void Internship_Activated(object sender, EventArgs e)
        {
            string sql = "SELECT CONCAT(rec_book_id, ': ', last_name, ' ', first_name) AS \"Студент\" from student";

            UndergraduatePracticeForm.TableFill("Номер студента", sql);

            comboBoxStudentCode.Items.Clear();
            for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Номер студента"]?.Rows.Count; i++)
            {
                comboBoxStudentCode.Items.Add(UndergraduatePracticeForm.ds.Tables["Номер студента"]?.Rows[i]["Студент"]);
            }

            sql = "SELECT CONCAT(sup_id, ': ', last_name, ' ', first_name) AS \"Руководитель\" from supervisor ORDER BY sup_id";

            UndergraduatePracticeForm.TableFill("Руководитель от вуза", sql);

            comboBoxSupervisorCode.Items.Clear();
            for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Руководитель от вуза"]?.Rows.Count; i++)
            {
                comboBoxSupervisorCode.Items.Add(UndergraduatePracticeForm.ds.Tables["Руководитель от вуза"]?.Rows[i]["Руководитель"]);
            }

            sql = "SELECT CONCAT(cmp_id, ': ', name) AS \"Предприятие\" from company ORDER BY cmp_Id";

            UndergraduatePracticeForm.TableFill("Предприятие", sql);

            comboBoxCompanyCode.Items.Clear();
            for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows.Count; i++)
            {
                comboBoxCompanyCode.Items.Add(UndergraduatePracticeForm.ds.Tables["Предприятие"]?.Rows[i]["Предприятие"]);
            }

            comboBoxStudentCode.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Студент"].ToString();
            comboBoxSupervisorCode.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Руководитель от вуза"].ToString();
            comboBoxCompanyCode.Text = UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[InternshipList.n]["Предприятие"].ToString();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            new Student().Show();
        }

        private void buttonAddSupervisor_Click(object sender, EventArgs e)
        {
            new Supervisor().Show();
        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            new Company().Show();
        }

        bool isFull = false;

        private void buttonUpdateInternship_Click(object sender, EventArgs e)
        {
            string pattern = @"\w+";

            if (comboBoxStudentCode.Text == "" || comboBoxSupervisorCode.Text == "" ||
                comboBoxCompanyCode.Text == "" || textBoxFirstName.Text == "" ||
                textBoxSurname.Text == "" || textBoxLastName.Text == "" ||
                textBoxPost.Text == "" || dateTimePickerStart.Text == "" ||
                dateTimePickerEnd.Text == "" || comboBoxGrade.Text == "" ||
                comboBoxWork.Text == "")
            {
                MessageBox.Show("Вы должны заполнить все поля!", "Внимание");
                return;
            }

            Match matchSt = Regex.Match(comboBoxStudentCode.Text, pattern, RegexOptions.IgnoreCase);
            Match matchSup = Regex.Match(comboBoxSupervisorCode.Text, pattern, RegexOptions.IgnoreCase);
            Match matchCmp = Regex.Match(comboBoxCompanyCode.Text, pattern, RegexOptions.IgnoreCase);


            if (InternshipList.isAdd)
            {
                for (int i = 0; i < UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows.Count; i++)
                {
                    if (comboBoxStudentCode.Text == UndergraduatePracticeForm.ds.Tables["Практика"]?.Rows[i]["Студент"].ToString())
                    {
                        MessageBox.Show("Этот студент уже прошел или проходит практику!!!", "Внимание");
                        return;
                    }
                }

                string sql = $"INSERT INTO internship values ('{matchSt.Value}', {matchSup.Value}, {matchCmp.Value}, " +
                    $"'{textBoxFirstName.Text}', '{textBoxSurname.Text}', '{textBoxLastName.Text}', '{textBoxPost.Text}', " +
                    $"'{dateTimePickerStart.Value:dd.MM.yyyy}', '{dateTimePickerEnd.Value:dd.MM.yyyy}', '{comboBoxGrade.Text}', '{comboBoxWork.Text}')";

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Практика"]!.Rows[InternshipList.n].ItemArray = new object[]
                {
                    comboBoxStudentCode.Text, comboBoxSupervisorCode.Text, comboBoxCompanyCode.Text,
                    textBoxLastName.Text + " " + textBoxSurname.Text + " " + textBoxFirstName.Text,
                    textBoxPost.Text, dateTimePickerStart.Value.ToString("dd.MM.yyyy"), dateTimePickerEnd.Value.ToString("dd.MM.yyyy"),
                    comboBoxGrade.Text, comboBoxWork.Text
                };

                InternshipList.isAdd = false;
            }
            else
            {
                string sql = $"UPDATE internship SET sup_id={matchSup.Value}, cmp_id={matchCmp.Value}, " +
                    $"first_name='{textBoxFirstName.Text}', surname='{textBoxSurname.Text}', last_name='{textBoxLastName.Text}', " +
                    $"post='{textBoxPost.Text}', start_date='{dateTimePickerStart.Text}', end_date='{dateTimePickerEnd.Text}', " +
                    $"grade='{comboBoxGrade.Text}', enterprise_work='{comboBoxWork.Text}' WHERE rec_book_id='{matchSt.Value}'";

                if (!UndergraduatePracticeForm.ModificationExecute(sql))
                    return;

                UndergraduatePracticeForm.ds.Tables["Практика"]!.Rows[InternshipList.n].ItemArray = new object[]
                {
                    comboBoxStudentCode.Text, comboBoxSupervisorCode.Text, comboBoxCompanyCode.Text,
                    textBoxLastName.Text + " " + textBoxSurname.Text + " " + textBoxFirstName.Text,
                    textBoxPost.Text, dateTimePickerStart.Value.ToString("dd.MM.yyyy"), dateTimePickerEnd.Value.ToString("dd.MM.yyyy"),
                    comboBoxGrade.Text, comboBoxWork.Text
                };
            }

            isFull = true;
            this.Close();
        }
    }
}
