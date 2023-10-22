using System;

namespace Module03
{
    internal class task14
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            int count = 0;

            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество цифр: {count}");
            Console.ReadKey();
        }

    }
}
