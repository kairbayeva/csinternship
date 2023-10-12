using System;

namespace module03practice
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
