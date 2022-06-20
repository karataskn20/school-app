using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Subject
    {
        private string subjectName;
        private readonly Teacher teacher;
        private List<Student> students;
        private double average = 0;
        private double average2d = 0;
        
        public Subject(string _subjectname, Teacher _teacher)
        {
            this.subjectName = _subjectname;
            this.teacher = _teacher;
        }

        public void AddStudents(List<Student> _students)
        {
            this.students = _students;
        }

        public void CalculateAverage(List<double> _grades)
        {
            average = _grades.Sum() / _grades.Count;
            average2d = Math.Round((Double)average, 2);
        }

        public void PrintSubjects()
        {
            Console.WriteLine($"{this.subjectName} - {this.average2d}");
        }
    }
}