using System;

public class Product
{
    private string name;
    private double price;
    private int quantity;

    public static int ProductCount { get; private set; }
    public static double TotalPrice { get; private set; }

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
        quantity = 0;
        ProductCount++;
        TotalPrice += price;
    }

    public void IncreaseQuantity(ref int amount)
    {
        quantity += amount;
        amount = quantity;
        TotalPrice += price * amount;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {name}, Price: ${price}, Quantity: {quantity}");
    }
}

class Program
{
    static void Main()
    {
        int amountToAdd = 5;
        Product product1 = new Product("Laptop", 800);
        Product product2 = new Product("Smartphone", 400);

        product1.IncreaseQuantity(ref amountToAdd);
        product2.IncreaseQuantity(ref amountToAdd);

        product1.DisplayProductInfo();
        product2.DisplayProductInfo();

        Console.WriteLine($"Total Products: {Product.ProductCount}");
        Console.WriteLine($"Total Price: ${Product.TotalPrice}");
    }
}
