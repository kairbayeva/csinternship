using System;

namespace module8practice
{
    public class practice1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());

            RangeOfArray customArrRange = new RangeOfArray();
            int[] result = customArrRange.GetRange(start, end);

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class RangeOfArray
    {
        private int[] arr = new int[5] { 9, 12, 13, 14, 15 };

        public int[] GetRange(int start, int end)
        {
            if (start > end)
            {
                Console.WriteLine("Error: Start is greater than end.");
                return new int[0];
            }

            int length = end - start + 1;
            int[] result = new int[length];

            for (int i = 0, j = start; i < length; i++, j++)
            {
                result[i] = arr[j];
            }

            return result;
        }
    }
}



