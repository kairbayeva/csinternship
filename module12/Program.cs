using System;

namespace module12
{
    public delegate double MathOperation(double x, double y);

    class Program
    {
        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("Error: Division by zero!");
                return 0;
            }
        }

        static void PerformOperation(double x, double y, MathOperation operation)
        {
            double result = operation(x, y);
            Console.WriteLine($"Result: {result}");
        }

        static void Main()
        {
            MathOperation addOperation = new MathOperation(Add);
            MathOperation subtractOperation = new MathOperation(Subtract);
            MathOperation multiplyOperation = new MathOperation(Multiply);
            MathOperation divideOperation = new MathOperation(Divide);

            double operand1 = 10;
            double operand2 = 5;

            PerformOperation(operand1, operand2, addOperation);
            PerformOperation(operand1, operand2, subtractOperation);
            PerformOperation(operand1, operand2, multiplyOperation);
            PerformOperation(operand1, operand2, divideOperation);

            Console.ReadKey();
        }
    }
}
