using System;

public class one
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        int conversely = Conversely(number);

        Console.WriteLine("полученное Число: " + conversely);

        Console.ReadLine();
    }

    static int Conversely(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }
        return reversed;
    }
}
