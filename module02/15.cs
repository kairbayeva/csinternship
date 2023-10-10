using System;

public class fifteen
{
    public static void Main(string[] args)
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        int ondyq = number / 10;
        int birlik = number % 10;
        int sum = ondyq + birlik;

        Console.WriteLine("Число десятков: " + ondyq);
        Console.WriteLine("Число единиц: " + birlik);
        Console.WriteLine("Сумма цифр: " + sum);


        Console.ReadLine();
    }
}
