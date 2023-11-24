using System;
using System.Runtime.ConstrainedExecution;

namespace module12homework
{
    public class SportsCar : Car
    {
        public SportsCar(string name) : base(name, 10) { }
    }

    public class SedanCar : Car
    {
        public SedanCar(string name) : base(name, 8) { }
    }

    public class Truck : Car
    {
        public Truck(string name) : base(name, 5) { }
    }

    public class Bus : Car
    {
        public Bus(string name) : base(name, 7) { }
    }
}