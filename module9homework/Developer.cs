using System;

namespace module9homework
{
    class Developer : Employee
    {
        public int LinesOfCodePerDay { get; set; }
        public Developer(string name, int age, int Salary, int linesOfCodePerDay)
            : base(name, age, Salary)
        {
            LinesOfCodePerDay = linesOfCodePerDay;
        }

        public override decimal CalculateAnnualSalary()
        {
            decimal baseAnnualSalary = base.CalculateAnnualSalary();

            decimal additionalSalary = LinesOfCodePerDay * 0.03m;

            return baseAnnualSalary + additionalSalary;
        }
    }
}

