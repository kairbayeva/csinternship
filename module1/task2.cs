using System;
using Internal;

public class task2
{
    public static void Main(string[] args)
    {
        Console.Write("Enter i:");
        string stri = Console.ReadLine();
        int i = 0;
        i = Convert.ToInt32(stri);
        Console.Write("Enter j:");
        string strj = Console.ReadLine();
        int j = 0;
        j = Convert.ToInt32(strj);
        int Sum = i + j;
        Console.WriteLine("Sum = " + Sum);

        Console.ReadLine();
    }
}
