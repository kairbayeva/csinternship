using System;

public class fourteen
{
    public static void Main(string[] args)
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите c: ");
        int c = int.Parse(Console.ReadLine());

        int temp = b;
        b = c;
        c = a;
        a = temp;

        Console.WriteLine("схема 1: ");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);

        int temp2 = b;
        b = a;
        a = c;
        c = temp2;

        Console.WriteLine("схема 2: ");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);

        Console.ReadLine();
    }
}
