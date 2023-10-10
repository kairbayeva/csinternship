using System;

public class seventeen
{
    public static void Main(string[] args)
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("a>b");
        }
        else if (a < b)
        {
            Console.WriteLine("b<a");
        }
        else
        {
            Console.WriteLine("a=b");
        }

        Console.ReadLine();
    }
}
