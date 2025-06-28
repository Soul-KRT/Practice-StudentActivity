using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentActivity
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Student> Students = new Dictionary<string, Student>();

        private const string delimeter = "|";
        private const string filePath = "students.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден.");
                return;
            }

            Записи.Items.Clear();

            foreach (Student student in Students.Values)
            {
                Записи.Items.Add(student.ToString(delimeter).Replace(delimeter, " "));
            }
        }

        private void ReadAllFromFile()
        {
            Students.Clear();

            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Student student = Student.FromString(line, delimeter);
                Students.Add(student.Name, student);
            }
        }

        private void WriteAllToFile()
        {
            var lines = new List<String>(Students.Count);

            foreach (Student student in Students.Values)
            {
                string line = student.ToString(delimeter);
                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = cmbGender.Text;
            DateTime birthday = dtpBirth.Value;
            int numberOfVisits = ((int)nudEvents.Value);
            int numberOfOffers = ((int)nudProposals.Value);
            string faculty = txtFaculty.Text;

            Student student = new Student(name, gender, birthday, numberOfVisits, numberOfOffers, faculty);
            Students.Add(student.Name, student);

            WriteAllToFile();
            Draw();

            MessageBox.Show("Запись добавлена.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            bool isRemoved = Students.Remove(name);
            
            if (!isRemoved)
            {
                MessageBox.Show("Студент с таким ФИО не найден.");
                return;
            }

            WriteAllToFile();
            Draw();

            MessageBox.Show("Запись удалена.");
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            ReadAllFromFile();
            Draw();
        }

        private void btnTopProposal_Click(object sender, EventArgs e)
        {
            if (Students.Count == 0)
            {
                MessageBox.Show("Пока нет записей");
                return;
            }

            int max = Students.Values.Max(student => student.NumberOfProposals);
            var topStudents = Students.Values.Where(student => student.NumberOfProposals == max).Select(student => student.Name).ToList();

            MessageBox.Show($"Макс. число предложений: {max}\nЛидеры:\n{string.Join("\n", topStudents)}");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadAllFromFile();
            Draw();
        }
    }
}