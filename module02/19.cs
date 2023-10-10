using System;

public class nineteen
{
    public static void Main(string[] args)
    {
        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }
        Console.Write("Введите b (b > 10): ");
        int b = int.Parse(Console.ReadLine());

        for (int i = 10; i <= b; i++)
        {
            int kvadrat = i * i;
            Console.WriteLine(kvadrat);
        }
        Console.Write("Введите a (a < 50): ");
        int a = int.Parse(Console.ReadLine());

        for (int i = a; i <= 50; i++)
        {
            int cube = i * i * i;
            Console.WriteLine(cube);
        }
        Console.Write("Введите значение A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите значение B: ");
        int B = int.Parse(Console.ReadLine());

        for (int i = A; i <= B; i++)
        {
            Console.WriteLine(i);
        }
    }
}
