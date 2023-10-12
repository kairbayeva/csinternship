using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Practice
{
    internal class practice4
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            Console.WriteLine($"Количество слов: {wordCount}");

            Console.ReadKey();
        }
    }
}
