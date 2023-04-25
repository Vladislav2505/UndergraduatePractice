using Npgsql;
using System.Data;
using UndergraduatePractice.Directories;
using UndergraduatePractice.Journal;

namespace UndergraduatePractice
{
    public partial class UndergraduatePracticeForm : Form
    {
        public UndergraduatePracticeForm()
        {
            InitializeComponent();
        }

        public static NpgsqlConnection connection =
            new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; Password=postgres;Database=practice");

        public static DataSet ds = new DataSet();
        public static DataSet nextValue = new DataSet();

        public static void TableFill(string name, string sql)
        {
            if (ds.Tables[name] != null)
                ds.Tables[name]?.Clear();
            NpgsqlDataAdapter dat;
            dat = new NpgsqlDataAdapter(sql, connection);
            dat.Fill(ds, name);
            connection.Close();
        }

        public static bool ModificationExecute(string sql)
        {
            NpgsqlCommand com;
            com = new NpgsqlCommand(sql, connection);
            connection.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Обновление базы данных не было выполнено из-за не указания обновляемых данных, " +
                    "несоответствия их типов или невозможности их удаления!!!", "Ошибка");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }

        public static string GetNextVal(string name, string sql)
        {
            if (nextValue.Tables[name] != null)
                nextValue.Tables[name]?.Clear();

            NpgsqlDataAdapter dat;
            dat = new NpgsqlDataAdapter(sql, connection);
            dat.Fill(nextValue, name);
            connection.Close();

            return nextValue.Tables[name].Rows[0][name].ToString();
        }

        private void вузToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University university = new University();
            university.Show();
        }

        private void факультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            faculty.Show();
        }

        private void специальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Speciality speciality = new Speciality();
            speciality.Show();
        }

        private void формаОбученияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudyType studyType = new StudyType();
            studyType.Show();
        }

        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Show();
        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void предприятиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Show();
        }

        private void руководительОтВузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supervisor supervisor = new Supervisor();
            supervisor.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void прохождениеПрактикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternshipList list = new InternshipList();
            list.Show();
        }

        private void поискСтудентовИПредприятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Requests requests = new Requests();
            requests.Show();
        }

        private void UndergraduatePracticeForm_Load(object sender, EventArgs e)
        {
            if (Authorization.user != "Администратор" && Authorization.user != "Сотрудник")
            {
                вузToolStripMenuItem.Enabled = false;
                специальностьToolStripMenuItem.Enabled = false;
                факультетToolStripMenuItem.Enabled = false;
                формаОбученияToolStripMenuItem.Enabled = false;
                группаToolStripMenuItem.Enabled = false;
                предприятиеToolStripMenuItem.Enabled = false;
                руководительОтВузаToolStripMenuItem.Enabled = false;
                студентToolStripMenuItem.Enabled = false;
                настройкаПаролейToolStripMenuItem.Enabled = false;
            }
            else if (Authorization.user == "Сотрудник")
            {
                вузToolStripMenuItem.Enabled = false;
                специальностьToolStripMenuItem.Enabled = false;
                факультетToolStripMenuItem.Enabled = false;
                формаОбученияToolStripMenuItem.Enabled = false;
                группаToolStripMenuItem.Enabled = false;
                предприятиеToolStripMenuItem.Enabled = false;
                руководительОтВузаToolStripMenuItem.Enabled = false;
                настройкаПаролейToolStripMenuItem.Enabled = false;
            }
        }

        private void настройкаПаролейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PasswordChange().Show();
        }

        private void просмотрСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "MyProject.chm");
        }
    }
}
