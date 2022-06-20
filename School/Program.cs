using School;

    public static class Program
    {

    static void Main()
    {
        Teacher teacherMat = new Teacher("Math Teacher");
        Teacher teacherPhy = new Teacher("Physichs Teacher");
        Teacher teacherChe = new Teacher("Chemistry Teacher");
        Teacher teacherBio = new Teacher("Biology Teacher");
        Teacher teacherEng = new Teacher("English Teacher");

        Subject subjectMat = new Subject("Math", teacherMat);
        Subject subjectPhy = new Subject("Physics", teacherPhy);
        Subject subjectChe = new Subject("Chemistry", teacherChe);
        Subject subjectBio = new Subject("Biology", teacherBio);
        Subject subjectEng = new Subject("English", teacherEng);

        List<Subject> student1Subjects = new List<Subject>() { subjectMat, subjectPhy, subjectChe };
        List<Subject> student2Subjects = new List<Subject>() { subjectPhy, subjectChe, subjectBio };
        List<Subject> student3Subjects = new List<Subject>() { subjectChe, subjectBio, subjectEng };
        List<Subject> student4Subjects = new List<Subject>() { subjectMat, subjectBio, subjectEng };
        List<Subject> student5Subjects = new List<Subject>() { subjectMat, subjectChe, subjectBio };
        List<Subject> student6Subjects = new List<Subject>() { subjectPhy, subjectBio, subjectEng };

        Student student1 = new Student("K", 150200081, student1Subjects, Grade.GetRandomGrade());
        Student student2 = new Student("L", 150200070, student2Subjects, Grade.GetRandomGrade());
        Student student3 = new Student("O", 150200077, student3Subjects, Grade.GetRandomGrade());
        Student student4 = new Student("Z", 150200040, student4Subjects, Grade.GetRandomGrade());
        Student student5 = new Student("A", 150200012, student5Subjects, Grade.GetRandomGrade());
        Student student6 = new Student("M", 150200055, student6Subjects, Grade.GetRandomGrade());

        List<Student> matStudents = new List<Student> { student1, student4, student5 };
        List<Student> phyStudents = new List<Student> { student1, student2, student6 };
        List<Student> cheStudents = new List<Student> { student1, student2, student3, student5 };
        List<Student> bioStudents = new List<Student> { student2, student3, student4, student5 };
        List<Student> engStudents = new List<Student> { student3, student4, student6 };

        subjectMat.AddStudents(matStudents);
        subjectPhy.AddStudents(phyStudents);
        subjectChe.AddStudents(cheStudents);
        subjectBio.AddStudents(bioStudents);
        subjectEng.AddStudents(engStudents);

        List<double> matGrades = new List<double> { student1.grades[0], student4.grades[0], student5.grades[0] };
        List<double> phyGrades = new List<double> { student1.grades[1], student2.grades[0], student6.grades[0] };
        List<double> cheGrades = new List<double> { student1.grades[2], student2.grades[1], student3.grades[0], student5.grades[1] };
        List<double> bioGrades = new List<double> { student2.grades[2], student3.grades[1], student4.grades[1], student5.grades[2] };
        List<double> engGrades = new List<double> { student3.grades[2], student4.grades[2], student6.grades[2] };

        subjectMat.CalculateAverage(matGrades);
        subjectPhy.CalculateAverage(phyGrades);
        subjectChe.CalculateAverage(cheGrades);
        subjectBio.CalculateAverage(bioGrades);
        subjectEng.CalculateAverage(engGrades);

        List<Student> clazz1Students = new List<Student>()
        {
            student1, student2, student3
        };

        List<Student> clazz2Students = new List<Student>()
        {
            student4, student5, student6
        };

        Clazz clazz1 = new Clazz(teacherMat, clazz1Students, 1);
        Clazz clazz2 = new Clazz(teacherBio, clazz2Students, 2);

        clazz1.PrintStudents();
        clazz2.PrintStudents();

        Console.WriteLine($"Average of grades given to students:\n");
        subjectMat.PrintSubjects();
        subjectPhy.PrintSubjects();
        subjectChe.PrintSubjects();
        subjectBio.PrintSubjects();
        subjectEng.PrintSubjects();

        Console.WriteLine($"\nAverage of grades by class:\n");
        clazz1.PrintClass();
        clazz2.PrintClass();

    }
}