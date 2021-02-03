
using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Mk3";
            car.Model = "honda";
            car.Year = 2007;
            Console.WriteLine($"{car.Model} - {car.Make} - {car.Year}");
        }
    }
}
