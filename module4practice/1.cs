using System;

struct Student
{
    public string name;
    public string groupNum;
    public int[] grades;

    public double averagegrade
    {
        get
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }
    }
}

class info
{
    static void Main()
    {
        Student[] students = new Student[10];
        students[0] = new Student { name = "Kairbayeva А.А.", groupNum = "3", grades = new int[] { 4, 5, 5, 4, 5 } };
        students[1] = new Student { name = "Nazar Б.Б.", groupNum = "3", grades = new int[] { 5, 4, 4, 3, 5 } };
        students[2] = new Student { name = "Sainova В.В.", groupNum = "4", grades = new int[] { 4, 4, 3, 4, 3 } };
        students[3] = new Student { name = "Amangeldi Г.Г.", groupNum = "2", grades = new int[] { 5, 5, 5, 5, 5 } };
        students[4] = new Student { name = "Smailov Д.Д.", groupNum = "1", grades = new int[] { 4, 4, 4, 4, 4 } };
        students[5] = new Student { name = "Boken Е.Е.", groupNum = "1", grades = new int[] { 3, 4, 3, 4, 3 } };
        students[6] = new Student { name = "Sakenov Ж.Ж.", groupNum = "4", grades = new int[] { 4, 5, 4, 5, 5 } };
        students[7] = new Student { name = "Zhalgas И.И.", groupNum = "4", grades = new int[] { 5, 3, 3, 4, 3 } };
        students[8] = new Student { name = "Bolat К.К.", groupNum = "2",grades = new int[] { 5, 5, 4, 5, 4 } };
        students[9] = new Student { name = "Asanova Л.Л.", groupNum = "2", grades = new int[] { 4, 4, 5, 5, 4 } };

        Array.Sort(students, (s1, s2) => s1.averagegrade.CompareTo(s2.averagegrade));

        Console.WriteLine("Студенты с оценками 4 или 5:");
        foreach (var student in students)
        {
            if (Array.TrueForAll(student.grades, grade => grade == 4 || grade == 5))
            {
                Console.WriteLine($"Фамилия: {student.name}, Группа: {student.groupNum}");
            }
        }
    }
}
