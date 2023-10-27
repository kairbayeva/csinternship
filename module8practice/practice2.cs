using System;
namespace module8practice
{
    class practice2
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в Продуктовый супермаркет!");
           var products = new Dictionary<string, decimal>
        {
            { "Молоко", 254.0M },
            { "Хлеб", 143.0M },
            { "Яйца", 593.0M },
            { "Фрукты", 434.0M },
            { "Овощи", 352.5M }
        };

           
            Console.Write("Введите текущее время (от 0 до 23): ");
            if (int.TryParse(Console.ReadLine(), out int currentTime) && currentTime >= 0 && currentTime <= 23)
            {
             
                var cart = new Dictionary<string, int>();

                while (true)
                {
                    Console.WriteLine("Выберите продукт из списка (или введите 'завершить' для завершения покупок):");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"{product.Key} - {product.Value:C}");
                    }

                    string choice = Console.ReadLine();

                    if (choice.Equals("завершить", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }

                    if (products.ContainsKey(choice))
                    {
                        Console.Write("Введите количество: ");
                        if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                        {
                            if (cart.ContainsKey(choice))
                            {
                                cart[choice] += quantity;
                            }
                            else
                            {
                                cart[choice] = quantity;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректное количество. Попробуйте еще раз.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Продукт не найден. Попробуйте еще раз.");
                    }
                }

                decimal total = 0.0M;
                foreach (var item in cart)
                {
                    total += products[item.Key] * item.Value;
                }

                if (currentTime >= 8 && currentTime <= 12)
                {
                  
                    decimal discount = total * 0.05M;
                    total -= discount;
                    Console.WriteLine("Вы получили скидку 5%!");
                }

                Console.WriteLine($"Общая сумма вашей покупки: {total:C}");
            }
            else
            {
                Console.WriteLine("Некорректное время. Попробуйте еще раз.");
            }
        }
    }

}


