namespace Labb2_Arv
{
    internal class Bicycle : Vehicle
    {
        int _wheelAmount = 2;

        protected int WheelAmount
        {
            get { return _wheelAmount; }
            set { _wheelAmount = value; }
        }

        //default constructor for setting all properties
        public Bicycle(string brand, string model, int year, double weight, double speed, int wheelAmount) : 
            base(brand, model, year, weight, speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Weight = weight;
            Speed = speed;
            WheelAmount = wheelAmount;
        }

        //simple constuctor for setting brand, model and year
        public Bicycle(string brand, string model, int year) :
            this(brand, model, year, 10, 30, 2) { }

        //simple constuctor for creating brand new vehicles
        public Bicycle(string brand, string model) :
            this(brand, model, DateTime.Now.Year) { }

        //empty constructor, everything uses default values
        public Bicycle() { }

        public string GetBicycleType()
        {
            string type = "";

            switch (WheelAmount)
            {
                case 0:
                    type = "Hoverbike";
                    break;
                case 1:
                    type = "Unicycle";
                    break;
                case 2:
                    type = "Bicycle";
                    break;
                case 3:
                    type = "Tricycle";
                    break;
                case 4:
                    type = "Quadcycle";
                    break;
                default:
                    type = "Monstrosity";
                    break;
            }

            return type;
        }

        public override void Enter(string driver)
        {
            Console.WriteLine($"{driver} gets on the {GetBicycleType()}.");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Woosh swoosh ding ding!");
        }

        public override void Exit(string driver)
        {
            Console.WriteLine($"{driver} hops off the {GetBicycleType()}.");
        }
    }
}
