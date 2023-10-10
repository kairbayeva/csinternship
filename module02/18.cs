using System;

public class eighteen
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Число является четным");
        }
        else
        {
            Console.WriteLine("Число не является четным.");
        }
        if (number % 10 == 7)
        {
            Console.WriteLine("Число оканчивается на 7.");
        }
        else
        {
            Console.WriteLine("Число не оканчивается на 7.");
        }

        Console.ReadLine();
    }
}
