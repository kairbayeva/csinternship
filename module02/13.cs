using System;

public class thirteen
{
    public static void Main(string[] args)
    {
        Console.Write("Введите массу : ");
        double mass = double.Parse(Console.ReadLine());
        Console.Write("Введите объем : ");
        double volume = double.Parse(Console.ReadLine());
        double plotnost = mass / volume;

        Console.WriteLine("плотность: " + plotnost);
        Console.ReadLine();
    }
}
