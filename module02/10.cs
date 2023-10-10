using System;

public class ten
{
    public static void Main(string[] args)
    {
        Console.Write("Введите радиус : ");
        double radius = double.Parse(Console.ReadLine());
        double diameter = 2 * radius;

        Console.WriteLine("Диаметр : " + diameter);

        Console.ReadLine();
    }
}
