using System;
using System.Xml.Linq;

namespace StudentActivity
{
    internal class Student
    {
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public DateTime Birthday { get; private set; }
        public int NumberOfVisits { get; private set; }
        public int NumberOfProposals { get; private set; }
        public string Faculty { get; private set; }

        public Student(string name, string gender, DateTime birthday, int numberOfVisits, int numberOfProposals, string faculty)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
            NumberOfVisits = numberOfVisits;
            NumberOfProposals = numberOfProposals;
            Faculty = faculty;
        }

        public string ToString(string delimeter)
        {
            return $"{Name}{delimeter}{Gender}{delimeter}{Birthday.ToShortDateString()}{delimeter}{NumberOfVisits}{delimeter}{NumberOfProposals}{delimeter}{Faculty}";
        }

        public static Student FromString(string line, string delimeter)
        {
            string[] values = line.Split(delimeter);

            string name = values[0];
            string gender = values[1];
            DateTime birthday = DateTime.Parse(values[2]);
            int numberOfVisits = int.Parse(values[3]);
            int numberOfProposals = int.Parse(values[4]);
            string faculty = values[5];

            return new Student(name, gender, birthday, numberOfVisits, numberOfProposals, faculty);
        }
    }
}
