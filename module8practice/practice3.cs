using System;
namespace module8practice
{
     class practice3
	{
            static void Main(string[] args)
            {
               
                double[] monthlySales = { 100, 120, 135, 150, 165 };
                int numMonths = monthlySales.Length;
                double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

                for (int i = 0; i < numMonths; i++)
                {
                    double month = i + 1;
                    double sales = monthlySales[i];

                    sumX += month;
                    sumY += sales;
                    sumXY += month * sales;
                    sumX2 += month * month;
                }
                double a = (numMonths * sumXY - sumX * sumY) / (numMonths * sumX2 - sumX * sumX);
                double b = (sumY - a * sumX) / numMonths;

                double nextMonth = a * (numMonths + 1) + b;
                double monthAfterNext = a * (numMonths + 2) + b;
                double thirdMonth = a * (numMonths + 3) + b;

                Console.WriteLine("Прогноз продаж:");
                Console.WriteLine($"Следующий месяц: {nextMonth}");
                Console.WriteLine($"Месяц через два месяца: {monthAfterNext}");
                Console.WriteLine($"Месяц через три месяца: {thirdMonth}");
            }
        }

    }



