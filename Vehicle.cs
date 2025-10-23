namespace Labb2_Arv
{
    internal class Vehicle
    {
        protected string Brand { get; set; } = "Unknown";
        protected string Model { get; set; } = "Unknown";
        protected int Year { get; set; } = DateTime.Now.Year;
        protected double Weight { get; set; } = 10;
        protected double Speed { get; set; } = 30;

        //default constructor for setting all properties
        public Vehicle(string brand, string model, int year, double weight, double speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Weight = weight;
            Speed = speed;
        }

        //simple constuctor for setting brand, model and year
        public Vehicle(string brand, string model, int year) : 
            this(brand, model, year, 10, 30) { }

        //simple constuctor for creating brand new vehicles
        public Vehicle(string brand, string model) : 
            this(brand, model, DateTime.Now.Year) { }

        //empty constructor, everything uses default values
        public Vehicle() { }

        public virtual void Enter(string driver)
        {
            Console.WriteLine($"{driver} enters the vehicle.");
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle noise!");
        }

        public void Travel(string destination = "unknown destination")
        {
            Console.WriteLine($"{Model} is traveling to {destination}.");
        }

        public virtual void Exit(string driver)
        {
            Console.WriteLine($"{driver} exits the vehicle.");
        }
    }
}
