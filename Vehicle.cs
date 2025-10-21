namespace Labb2_Arv
{
    internal class Vehicle
    {
        string _brand = "Unknown";
        string _model = "Unknown";
        int _year = DateTime.Now.Year;
        double _weight = 10;
        double _speed = 30;

        protected string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        protected string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        protected int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        protected double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        protected double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

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
