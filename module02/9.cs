using System;

public class nine
{
    public static void Main(string[] args)
    {
        Console.Write("Введите длину стороны квадрата: ");
        double cm = double.Parse(Console.ReadLine());

        double perimeter = 4 * cm;

        Console.WriteLine("Периметр " + perimeter);

        Console.ReadLine();
    }
}
