using System;
namespace module12homework
{ 
    public delegate void CarEventHandler(object sender, EventArgs e);

    public abstract class Car
    {
        public event CarEventHandler StartRace;
        public event CarEventHandler FinishRace;

        public string Name { get; set; }
        public double Speed { get; set; }
        public double Distance { get; set; }

        protected Car(string name, double speed)
        {
            Name = name;
            Speed = speed;
            Distance = 0;
        }

        protected virtual void OnStartRace()
        {
            StartRace?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnFinishRace()
        {
            FinishRace?.Invoke(this, EventArgs.Empty);
        }

        public void Race()
        {
            OnStartRace();

            while (Distance < 100)
            {
                Distance += Speed;
                Console.WriteLine($"{Name} is at {Distance} km");
            }

            OnFinishRace();
        }
    
