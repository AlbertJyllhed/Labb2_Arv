using Labb2_Arv.Cars;

namespace Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bicycle = new Bicycle("Giant", "Escape 3", 2021);
            bicycle.Enter("Alice");
            bicycle.StartEngine();
            bicycle.Travel("Central Park");
            bicycle.Exit("Alice");
            Console.WriteLine();

            var boat = new Boat("Yamaha", "242X E-Series", 2020);
            boat.AddCargo("Life Jackets");
            boat.AddCargo("Cooler");
            boat.DisplayCargo();
            boat.Enter("Captain Jack");
            boat.StartEngine();
            Console.WriteLine();

            var car = new Car("Toyota", "Camry", 2019);
            car.Enter("Bob");
            car.StartEngine();
            car.DrunkDrive("Bob", 0.3);
            Console.WriteLine();

            var sedan = new Sedan("Honda", "Accord", 2018);
            sedan.Enter("Charlie");
            sedan.StartEngine();
            sedan.Flip();
            sedan.Exit("Charlie");
            Console.WriteLine();

            var suv = new SUV("Ford", "Explorer", 2022);
            suv.Enter("Diana");
            suv.StartEngine();
            suv.OffRoadDrive();
        }
    }
}
