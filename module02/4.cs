using System;

public class fourth
{
    public static void Main(string[] args)
    {
        Console.Write("расстояние в сантиметрах: ");
        int cm = int.Parse(Console.ReadLine());

        int Meters = cm / 100;

        Console.WriteLine("Число полных метров: " + Meters);

        Console.ReadLine();
    }
}
