using System;

class Train
{
    public int TrainNumber { get; set; }
    public string StartStation { get; set; }
    public string EndStation { get; set; }
    public decimal Price { get; set; }

    public Train(int trainNumber, string startStation, string endStation, decimal price)
    {
        TrainNumber = trainNumber;
        StartStation = startStation;
        EndStation = endStation;
        Price = price;
    }
}

class Ticket
{
    public Train SelectedTrain { get; set; }
    public DateTime SendingDateTime { get; set; }
    public decimal Price { get; set; }

    public Ticket(Train train, DateTime departureDateTime)
    {
        SelectedTrain = train;
        SendingDateTime = departureDateTime;
        Price = train.Price;
    }
}

class Passenger
{
    public string Name { get; set; }
    public List<Ticket> Tickets { get; set; }

    public Passenger(string name)
    {
        Name = name;
        Tickets = new List<Ticket>();
    }

    public void Reservation(Train train, DateTime departureDateTime)
    {
        Ticket ticket = new Ticket(train, departureDateTime);
        Tickets.Add(ticket);
    }
}

class Cashier
{
    public Train CreateTrain(int trainNumber, string startStation, string endStation, decimal price)
    {
        return new Train(trainNumber, startStation, endStation, price);
    }
}
