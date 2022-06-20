using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Clazz
    {
        private int classID;
        private Teacher primaryTeacher;
        private List<Student> students;
        private double average = 0;
        private double average2d = 0;
        private int gradeCount = 0;

        public Clazz(Teacher _primaryTeacher, List<Student> _students, int classID)
        {
            this.primaryTeacher = _primaryTeacher;
            this.students = _students;
            this.classID = classID;
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students[i].grades.Count; j++)
                {
                    this.average += _students[i].grades[j];
                    gradeCount++;
                }
            }
            this.average /= gradeCount;
            average2d = Math.Round((Double)average, 2);
        }

        public void PrintStudents()
        {
            Console.WriteLine($"Class {this.classID} Students, their ids and average grades:\n");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Student 1 : {students[i].name}, {students[i].id} -> {students[i].average2d}");
            }
            Console.WriteLine("\n");
        }

        public void PrintClass()
        {
            Console.WriteLine($"Class {this.classID} average - {this.average2d}");
        }
    }
}
