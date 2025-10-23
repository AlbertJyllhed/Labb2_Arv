namespace Labb2_Arv.Cars
{
    internal class SUV : Car
    {
        //default constructor for setting all properties
        public SUV(string brand, string model, int year, double weight, double speed, int doorAmount) :
            base(brand, model, year, weight, speed, doorAmount) { }

        //simple constuctor for setting brand, model and year
        public SUV(string brand, string model, int year) :
            this(brand, model, year, 10, 30, 4) { }

        //simple constuctor for creating brand new vehicles
        public SUV(string brand, string model) :
            this(brand, model, DateTime.Now.Year) { }

        //empty constructor, everything uses default values
        public SUV() { }

        public override void StartEngine()
        {
            Console.WriteLine("VROOOM VROOOM!");
        }

        public void OffRoadDrive()
        {
            Console.WriteLine($"{Model} is now off-roading!");
        }
    }
}
