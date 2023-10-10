using System;

public class twelve
{
    public static void Main(string[] args)
    {
        Console.Write("Введите (a): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите (b): ");
        int b = int.Parse(Console.ReadLine());

        double arifm = (a + b) / 2.0;
        double Geom = Math.Sqrt(a * b);

        Console.WriteLine("Среднее арифметическое значение: " + arifm);
        Console.WriteLine("Среднее геометрическое значение: " + Geom);

        Console.ReadLine();
    }
}
