using System;

public class seven
{
    public static void Main(string[] args)
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        double y = 7 * x * x - 3 * x + 6;
        Console.WriteLine("y=" + y);

        Console.ReadLine();
    }
}
