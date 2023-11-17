using System;
using System.Linq;

namespace module_11_practice
{
    internal class Program
    {
        public record Employee(string Name, int Id, decimal Salary, DateTime HireDate, string Position, char Gender)
        {
            public override string ToString() =>
                $"Имя: {Name}, Id: {Id}, Зарплата: {Salary:C}, Должность: {Position}, Пол: {Gender}, Дата приема: {HireDate.ToShortDateString()}";
        }

        static void Main(string[] args)
        {
            Console.Write("количество сотрудников: ");
            int n = int.Parse(Console.ReadLine());

            var employees = Enumerable.Range(1, n).Select(_ =>
            {
                Console.WriteLine($"инфо о сотруднике #{_}:");
                return ReadEmployeeData();
            }).ToArray();

            PrintAllEmployees(employees);

            Console.Write("должность для вывода информации: ");
            string selectedPosition = Console.ReadLine();
            PrintEmployeesByPosition(employees, selectedPosition);

            CheckSalary(employees);

            Console.Write("дата (гггг-мм-дд) для фильтрации сотрудников: ");
            DateTime filterDate = DateTime.Parse(Console.ReadLine());
            PrintHiredAfterDate(employees, filterDate);

            Console.Write("Введите пол (М/Ж), либо оставьте пустым для вывода всех: ");
            char genderFilter = char.TryParse(Console.ReadLine(), out char gender) ? gender : '\0';
            PrintEmployeesByGender(employees, genderFilter);

            Console.ReadKey();
        }

        static Employee ReadEmployeeData()
        {
            return new Employee
            {
                Name = ReadInput("Имя"),
                Id = int.Parse(ReadInput("ID")),
                Salary = decimal.Parse(ReadInput("Зарплата")),
                HireDate = DateTime.Parse(ReadInput("Дата приема на работу (гггг-мм-дд)")),
                Position = ReadInput("Должность"),
                Gender = char.Parse(ReadInput("Пол (М/Ж)"))
            };
        }

        static string ReadInput(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine();
        }

        static void PrintAllEmployees(Employee[] employees)
        {
            Console.WriteLine("\nПолная инфо:");
            Array.ForEach(employees, Console.WriteLine);
            Console.WriteLine();
        }

        static void PrintEmployeesByPosition(Employee[] employees, string position)
        {
            Console.WriteLine($"\nСотрудники на должности {position}:");
            Array.ForEach(employees, e =>
            {
                if (string.Equals(e.Position, position, StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine(e);
            });
            Console.WriteLine();
        }

        static void CheckSalary(Employee[] employees)
        {
            decimal averageSalary = employees.Where(e => e.Position.Equals("Менеджер", StringComparison.OrdinalIgnoreCase)).Average(e => e.Salary);
            Console.WriteLine($"\nМенеджеры с зарплатой выше средней зарплаты  ({averageSalary:C}):");
            Array.ForEach(employees.Where(e => e.Position.Equals("Менеджер", StringComparison.OrdinalIgnoreCase) && e.Salary > averageSalary).OrderBy(e => e.Name), Console.WriteLine);
            Console.WriteLine();
        }

        static void PrintHiredAfterDate(Employee[] employees, DateTime hireDate)
        {
            Console.WriteLine($"\nСотрудники, принятые на работу после {hireDate.ToShortDateString()}, отсортированные по фамилии:");
            Array.ForEach(employees.Where(e => e.HireDate > hireDate).OrderBy(e => e.Name), Console.WriteLine);
            Console.WriteLine();
        }

        static void PrintEmployeesByGender(Employee[] employees, char genderFilter)
        {
            string genderString = genderFilter == 'М' ? "мужчины" : (genderFilter == 'Ж' ? "женщины" : "все");
            Console.WriteLine($"\nИнформация о сотрудниках {genderString}:");
            Array.ForEach(employees.Where(e => genderFilter == '\0' || e.Gender == genderFilter).OrderBy(e => e.Name), Console.WriteLine);
            Console.WriteLine();
        }
    }
}
