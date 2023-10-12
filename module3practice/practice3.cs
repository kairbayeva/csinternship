using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Practice
{
    internal class practice3
    {
        static void Main()
        {
            string input = Console.ReadLine();

            input = input.Replace(" ", "").ToLower();

            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - 1 - i])
                {
                    Console.WriteLine("строка не является палиндромом.");
                }
                else
                {
                    Console.WriteLine("строка является палиндромом.");
                }
            }
            Console.ReadKey();
        }

    }
}
