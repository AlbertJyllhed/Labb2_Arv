namespace Labb2_Arv
{
    internal class Boat : Vehicle
    {
        List<string> _cargo = [];

        protected List<string> Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        //default constructor for setting all properties
        public Boat(string brand, string model, int year, double weight, double speed) : 
            base(brand, model, year, weight, speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Weight = weight;
            Speed = speed;
            Cargo = [];
        }

        //simple constuctor for setting brand, model and year
        public Boat(string brand, string model, int year) :
            this(brand, model, year, 10, 30) { }

        //simple constuctor for creating brand new vehicles
        public Boat(string brand, string model) :
            this(brand, model, DateTime.Now.Year) { }

        //empty constructor, everything uses default values
        public Boat() { }

        public void AddCargo(string cargo)
        {
            Console.WriteLine($"{cargo} is added to the boat cargo hold.");
            Cargo.Add(cargo);
        }

        public override void Enter(string driver)
        {
            Console.WriteLine($"{driver} boards the boat.");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Chug chug putter putter!");
        }

        public override void Exit(string driver)
        {
            Console.WriteLine($"{driver} leaves the boat.");
        }
    }
}
