using System.Diagnostics;

class Program
{
    static void Main()
    {
        var sportsCar = new SportsCar("Спортивная машина");
        var sedanCar = new SedanCar("Легковая машина");
        var truck = new Truck("Грузовик");
        var bus = new Bus("Автобус");

        var raceGame = new RaceGame();
        raceGame.RaceFinished += RaceGame_RaceFinished;

        var cars = new Car[] { sportsCar, sedanCar, truck, bus };
        raceGame.StartRace(cars);

        Console.ReadKey();
    }

    private static void RaceGame_RaceFinished(object sender, EventArgs e)
    {
        Console.WriteLine("Гонка завершена!");
    }
}

