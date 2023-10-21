using System;

class task4
{
    static void Main()
    {
        Console.WriteLine("Введите символы , чтобы подсчитать пробелы:");

        int count = 0;

        while (true)
        {
            char inputChar = Console.ReadKey().KeyChar;

            if (inputChar == '.')
            {
                break;
            }
            else if (inputChar == ' ')
            {
                count++;
            }
        }

        Console.WriteLine($"\nКоличество пробелов: {count}");
        Console.ReadKey();
    }
}
