using System;

namespace module03practice
{
    class Practice2
    {
        static void Main()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 3, 4, 5, 6, 7 };

            int[] c = new int[Math.Min(a.Length, b.Length)];

            int resultIndex = 0;

            foreach (int element in a)
            {
                if (Array.Exists(b, e => e == element) && !Array.Exists(c, e => e == element))
                {
                    c[resultIndex] = element;
                    resultIndex++;
                }
            }

            int[] result = new int[resultIndex];
            Array.Copy(c, result, resultIndex);

            Console.WriteLine("Общие элементы двух массивов без повторений:");
            foreach (int element in result)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
