using System;

namespace module03practice
{
    class practice1
    {
        static void Main()
        {
            double[] A = new double[5];
            Console.WriteLine("массив A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
            }

            double[,] B = new double[3, 4];
            Random random = new Random();
            Console.WriteLine("Массив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.NextDouble();
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            double maxA = A[0];
            double minA = A[0];
            double maxB = B[0, 0];
            double minB = B[0, 0];

            foreach (double num in A)
            {
                if (num > maxA)
                {
                    maxA = num;
                }
                if (num < minA)
                {
                    minA = num;
                }
            }

            foreach (double num in B)
            {
                if (num > maxB)
                {
                    maxB = num;
                }
                if (num < minB)
                {
                    minB = num;
                }
            }

            double sumA = 0;
            double productA = 1;
            double sumB = 0;
            double productB = 1;

            foreach (double num in A)
            {
                sumA += num;
                productA *= num;
            }

            foreach (double num in B)
            {
                sumB += num;
                productB *= num;
            }

            double sumEvenA = 0;
            foreach (double num in A)
            {
                if (num % 2 == 0)
                {
                    sumEvenA += num;
                }
            }

            double sumOddColumnsB = 0;
            for (int j = 0; j < 4; j += 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    sumOddColumnsB += B[i, j];
                }
            }

            Console.WriteLine($"Мах элемент в массиве A: {maxA}");
            Console.WriteLine($"Мин элемент в массиве A: {minA}");
            Console.WriteLine($"Мах элемент в массиве B: {maxB}");
            Console.WriteLine($"Мин элемент в массиве B: {minB}");
            Console.WriteLine($"сумма всех элементов в массиве A: {sumA}");
            Console.WriteLine($"произведение всех элементов в массиве A: {productA}");
            Console.WriteLine($"сумма всех элементов в массиве B: {sumB}");
            Console.WriteLine($"произведение всех элементов в массиве B: {productB}");
            Console.WriteLine($"Сумма четных элементов в массиве A: {sumEvenA}");
            Console.WriteLine($"Сумма нечетных столбцов в массиве B: {sumOddColumnsB}");
            Console.ReadKey();
        }
    }
}

