namespace School
{
    public static class Grade
    {
        public static Random rng = new Random();
        public const int GradeCount = 3;
        public const double Four = 4;
        public const double ThreeHalf = 3.5;
        public const double Three = 3;
        public const double TwoHalf = 2.5;
        public const double Two = 2;
        public const double OneHalf = 1.5;
        public const double One = 1;
        public const double ZeroHalf = 0.5;
        public const double Zero = 0;

        public static double[] Grades =
        {
            Four, ThreeHalf, Three, TwoHalf, Two, OneHalf, One, ZeroHalf, Zero,
        };

        public static List<double> GetRandomGrade()
        {
            List<double> grades = new List<double>();
            for (int i = 0; i < GradeCount; i++)
            {
                int gradeIndex = rng.Next(Grades.Length);
                grades.Add(Grades[gradeIndex]);
            }
            return grades;
        }

    }
}
