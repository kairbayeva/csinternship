using System;

namespace Module03
{
    internal class task5
    {
        static int ReverseNumber(int n)
        {
            string numberString = n.ToString();
            char[] charArray = numberString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            int reversedNumber = int.Parse(reversedString);

            return reversedNumber;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int reversedN = ReverseNumber(n);

            Console.WriteLine($"result: {reversedN}");
            Console.ReadKey();
        }
    }
}
