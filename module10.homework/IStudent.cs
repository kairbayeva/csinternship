using System;
using System.Linq;

namespace module10.homework
{
    interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }
        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }

    class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, string fullName, int[] grades)
        {
            Name = name;
            FullName = fullName;
            Grades = grades;
        }

        public string GetName() => Name;

        public string GetFullName() => FullName;

        public double GetAvgGrade() => Grades.Length == 0 ? 0 : Grades.Average();
    }

    internal class StudentProgram
    {
        static void Main()
        {
            int[] grades = { 88, 87, 92, 98, 90 };
            IStudent student = new Student("Dilnaz", "Dilnaz Kairbayeva", grades);

            Console.WriteLine("Name: " + student.GetName());
            Console.WriteLine("Full Name: " + student.GetFullName());
            Console.WriteLine("Average Grade: " + student.GetAvgGrade());

            Console.ReadKey();
        }
    }
}
