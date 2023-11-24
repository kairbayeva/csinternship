using System;

namespace module13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: ");
            task1();

            Console.WriteLine("Task 2:");
            Task2();

            Console.WriteLine("Task 3: ");
            task3();

            Console.WriteLine("Task 4: ");
            List<Employee> employees = new List<Employee>
            {
                new Employee { LastName = "user", FirstName = "user", MiddleName = "user", Age = 30, Salary = 800000 },
            };

            var lowSalaryEmployees = employees.Where(e => e.Salary < 10000).ToList();
            var highSalaryEmployees = employees.Where(e => e.Salary >= 10000).ToList();

            Console.WriteLine("Сотрудники с зарплатой менее 10000:");
            PrintEmployees(lowSalaryEmployees);

            Console.WriteLine("\nСотрудники с зарплатой 10000 и выше:");
            PrintEmployees(highSalaryEmployees);

            Console.ReadKey();
        }

        static void task1() 
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    numbers.Remove(i);
                }
            }

            Console.WriteLine("Result: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void Task2()
        {
            List<double> list = new List<double>() { 1.2, 3.4, 5.5, 7.0, 1.9, 8.2 };

            double sum = 0;
            foreach (double d in list)
            {
                sum += d;
            }

            double mid = sum / 10;
            Console.WriteLine("Mid = " + mid);
            foreach (double i in list)
            {
                if (i > mid)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void task3()
        {
            List<double> nums = new List<double>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                double num = random.NextDouble();
                nums.Add(num);
            }

            Console.WriteLine("main list : ");
            foreach (double d in nums)
            {
                Console.WriteLine(d);
            }

            nums.Reverse();
            Console.WriteLine("Reversed List : ");
            foreach (double d in nums)
            {
                Console.WriteLine(d);
            }
        }

        class Employee
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public int Age { get; set; }
            public decimal Salary { get; set; }
        }

        static void PrintEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"ФИО: {employee.LastName} {employee.FirstName} {employee.MiddleName}," +
                    $" Возраст: {employee.Age}, Зарплата: {employee.Salary}");
            }
        }
    }
}

