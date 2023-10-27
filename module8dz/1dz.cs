using System;

class SquaredArr
{
    private double[] arr;

    public SquaredArr(int size)
    {
        arr = new double[size];
    }

    public double this[int index]
    {
        get
        {
            if (index >= 0 && index < arr.Length)
            {
                return arr[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
        set
        {
            if (index >= 0 && index < arr.Length)
            {
                arr[index] = value * value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SquaredArr squaredarr = new SquaredArr(5);
        squaredarr[0] = 1.0;
        squaredarr[1] = 2.0;
        Console.WriteLine(squaredarr[0]);
        Console.WriteLine(squaredarr[1]);
    }
}

