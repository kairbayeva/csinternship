using System;

class Car
{
    public string Model { get; set; }
    public bool Remont { get; set; }

    public Car(string model, string licensePlate)
    {
        Model = model;
        Remont = false;
    }
}

class Driver
{
    public string Name { get; set; }
    public Car AssignedCar { get; set; }
    public List<Trip> Trips { get; set; }
    public bool Available { get; set; }

    public Driver(string name)
    {
        Name = name;
        Trips = new List<Trip>();
        Available = true;
    }
}

class Trip
{
    public string Destination { get; set; }
    public bool Completed { get; set; }

    public Trip(string destination)
    {
        Destination = destination;
        Completed = false;
    }
}

class Dispatcher
{
    public void AssignTripToDriver(Trip trip, Driver driver, Car car)
    {
        driver.AssignedCar = car;
        driver.Trips.Add(trip);
    }

    public void SuspendDriver(Driver driver)
    {
        driver.Available = false;
        if (driver.AssignedCar != null)
        {
            driver.AssignedCar.Remont = false;
        }
    }
}

