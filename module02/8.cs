using System;

public class eight
{
    public static void Main(string[] args)
    {
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        double x = 12 * a * 2 + 7 * a - 16;
        Console.WriteLine("x=" + x);

        Console.ReadLine();
    }
}
