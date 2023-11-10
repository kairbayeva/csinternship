using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.ConsoleApp
{
    public interface ICalculatable
    {
        double Qosu(double a, double b);
        double Kobeitu(double a, double b);
        double Alu(double a, double b);
        double Bolu(double a, double b);
    }

    public class Calculator : ICalculatable
    {
        public double Qosu(double a, double b)
        {
            return a + b;
        }

        public double Alu(double a, double b)
        {
            return a - b;
        }

        public double Kobeitu(double a, double b)
        {
            return a * b;
        }

        public double Bolu(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("0-ge bolinbeidi");
            }
            return a / b;
        }
    }

    internal class Calculatable
    {
        static void Main()
        {
            ICalculatable calculatable = new Calculator();
            double result1 = calculatable.Qosu(3, 4);
            double result2 = calculatable.Alu(16, 2);
            double result3 = calculatable.Kobeitu(7, 8);
            double result4 = calculatable.Bolu(36, 6);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadKey();
        }
    }

}