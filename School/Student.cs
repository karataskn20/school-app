using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        public readonly int id;
        public readonly string name;

        private List<Subject> subjects;
        public readonly List<double> grades;

        private double average = 0;
        public readonly double average2d = 0;
        public Student(string name, int id, List<Subject> _subjects, List<double> _grades)
        {
            this.name = name;
            this.id = id;
            if (_subjects.Count == 3)
            {
                this.subjects = _subjects;
            }
            else
            {
                Console.WriteLine("Each student must take 3 subjects");
            }
            if (_grades.Count == 3)
            {
                this.grades = _grades;
            }
            else
            {
                Console.WriteLine("Each student must take 3 subjects");
            }

            for (int i = 0; i < grades.Count; i++)
            {
                average += grades[i];
            }
            average /= grades.Count;
            average2d = Math.Round((Double)average, 2);
        }
    }
}
