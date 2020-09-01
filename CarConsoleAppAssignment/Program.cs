using System;
using System.Collections.Generic;

namespace CarConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car();
            newCar.Make = "Chevy";
            newCar.Model = "Impala";
            newCar.Year = 2000;

            var abesCar = new Car("Tesla", "Model Y", 2020);

            var carList = new List<Car>() { abesCar, newCar };

            Console.WriteLine($"I have a {newCar.Make} {newCar.Model} from {newCar.Year}");
            Console.WriteLine($"My dream car is a {abesCar.Year} {abesCar.Make} {abesCar.Model}");

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");
            }
        }
    }
}

