using System.Reflection;

namespace Labb2_Arv
{
    internal class Car : Vehicle
    {
        protected int DoorAmount { get; set; } = 4;

        //default constructor for setting all properties
        public Car(string brand, string model, int year, double weight, double speed, int doorAmount) : 
            base(brand, model, year, weight, speed)
        {
            DoorAmount = doorAmount;
        }

        //simple constuctor for setting brand, model and year
        public Car(string brand, string model, int year) : 
            this(brand, model, year, 10, 30, 4) { }

        //simple constuctor for creating brand new vehicles
        public Car(string brand, string model) : 
            this(brand, model, DateTime.Now.Year) { }

        //empty constructor, everything uses default values
        public Car() { }

        public void DrunkDrive(string driver, double promille)
        {
            Console.WriteLine($"{driver} is driving under influence!\n" +
                $"They have {promille} promille of alcohol in their blood.");

            if (promille > 0.2)
            {
                Console.WriteLine($"{driver} is taken away by the police " +
                    $"after crashing into a family of four. :C");
            }
        }

        public override void Enter(string driver)
        {
            Console.WriteLine($"{driver} enters the car.");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Vroom vroom!");
        }

        public override void Exit(string driver)
        {
            Console.WriteLine($"{driver} exits the car.");
        }
    }
}
