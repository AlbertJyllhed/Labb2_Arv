namespace Labb2_Arv.Cars
{
    internal class Sedan : Car
    {
        //default constructor for setting all properties
        public Sedan(string brand, string model, int year, double weight, double speed, int doorAmount) :
            base(brand, model, year, weight, speed, doorAmount)
        { }

        //simple constuctor for setting brand, model and year
        public Sedan(string brand, string model, int year) :
            this(brand, model, year, 10, 30, 4)
        { }

        //simple constuctor for creating brand new vehicles
        public Sedan(string brand, string model) :
            this(brand, model, DateTime.Now.Year)
        { }

        //empty constructor, everything uses default values
        public Sedan() { }

        public override void StartEngine()
        {
            Console.WriteLine("Brrrr brrrr!");
        }

        public void Flip()
        {
            Console.WriteLine($"{Model} has flipped over!");
        }
    }
}
