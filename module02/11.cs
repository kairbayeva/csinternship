using System;

public class eleven
{
    public static void Main(string[] args)
    {
        Console.Write("Введите  x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите y: ");
        double y = double.Parse(Console.ReadLine());

        double z = Math.Pow(x, 3) - 2.5 * x * y + 1.78 * Math.Pow(x, 2) - 2.5 * y + 1;

        Console.WriteLine("z= " + z);
        Console.ReadLine();
    }
}
