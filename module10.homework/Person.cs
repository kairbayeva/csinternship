using System;
using System.Collections.Generic;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Full name: {FirstName} {LastName}");
    }

    public override string ToString() => $"{FirstName} {LastName}";

    public override bool Equals(object obj)
    {
        if (obj is Person other)
        {
            return FirstName == other.FirstName && LastName == other.LastName;
        }
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(FirstName, LastName);
}

public class Student : Person
{
    public List<Teacher> Teachers { get; } = new List<Teacher>();

    public Student(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }

    public override void Print()
    {
        Console.WriteLine($"Student name:{FirstName} {LastName}");
        Console.WriteLine("Teachers : ");
        foreach (var teacher in Teachers)
        {
            Console.WriteLine(teacher);
        }
    }
}

public class Teacher : Person
{
    public List<Student> Students { get; } = new List<Student>();

    public Teacher(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
        student.AddTeacher(this);
    }

    public override void Print()
    {
        Console.WriteLine($"Teacher: {FirstName} {LastName}");
        Console.WriteLine("Students:");
        foreach (var student in Students)
        {
            Console.WriteLine($"  {student}");
        }
    }
}

internal class Program
{
    static void Main()
    {
        Person person1 = new Person("Dilnaz", "Kairbayeva");
        Student student1 = new Student("Asan", "Alievich");
        Teacher teacher1 = new Teacher("Roza", "Nuralievna");

        student1.AddTeacher(teacher1);
        teacher1.AddStudent(student1);

        List<Person> people = new List<Person> { person1, student1, teacher1 };

        foreach (var person in people)
        {
            person.Print();
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
