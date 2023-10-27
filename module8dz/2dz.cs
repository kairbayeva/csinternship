using System;

class programm
{
    static void Main(string[] args)
    {
        Console.Write("Площадь (м2): ");
        double area = double.Parse(Console.ReadLine());
        Console.Write("Количество жильцов: ");
        int residents = int.Parse(Console.ReadLine());
        Console.Write("Сезон (осень/зима/весна/лето): ");
        string season = Console.ReadLine().ToLower();
        Console.Write("Льготы (да/нет): ");
        bool hasDiscount = Console.ReadLine().ToLower() == "да";

        double heatingRate = (season == "осень" || season == "зима") ? 12 : 10;
        double waterRate = 5;
        double gasRate = 7;
        double repairRate = 15;

        double heatingPayment = area * heatingRate;
        double waterPayment = residents * waterRate;
        double gasPayment = residents * gasRate;
        double repairPayment = area * repairRate;

        double totalPayment = heatingPayment + waterPayment + gasPayment + repairPayment;

        double discount = hasDiscount ? 0.5 : 0.3;
        double discountedHeating = heatingPayment * discount;
        double discountedWater = waterPayment * discount;
        double discountedGas = gasPayment * discount;
        double discountedRepair = repairPayment * discount;

        Console.WriteLine("\nТаблица сумм коммунальных платежей:");
        Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
        Console.WriteLine($"Отопление\t{heatingPayment}\t{discountedHeating}\t{heatingPayment - discountedHeating}");
        Console.WriteLine($"Вода\t\t{waterPayment}\t{discountedWater}\t{waterPayment - discountedWater}");
        Console.WriteLine($"Газ\t\t{gasPayment}\t{discountedGas}\t{gasPayment - discountedGas}");
        Console.WriteLine($"Текущий ремонт\t{repairPayment}\t{discountedRepair}\t{repairPayment - discountedRepair}");
        Console.WriteLine($"Итого\t\t{totalPayment}\t{discount * (heatingPayment + waterPayment + gasPayment + repairPayment)}\t{totalPayment - discount * (heatingPayment + waterPayment + gasPayment + repairPayment)}");
    }
}

