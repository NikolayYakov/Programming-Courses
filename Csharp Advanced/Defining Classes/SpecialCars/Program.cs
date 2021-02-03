using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var tires = new List<Tire[]>();
            var cars = new List<Car>();
            while(command!= "No more tires")
            {
                string[] tockens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var newTire1 = new Tire(int.Parse(tockens[0]),double.Parse(tockens[1]));
                var newTire2 = new Tire(int.Parse(tockens[2]), double.Parse(tockens[3]));
                var newTire3 = new Tire(int.Parse(tockens[4]), double.Parse(tockens[5]));
                var newTire4 = new Tire(int.Parse(tockens[6]),double.Parse(tockens[7]));
                tires.Add(new Tire[] { newTire1, newTire2, newTire3, newTire4 });
                command = Console.ReadLine();
            }
            var engines = new List<Engine>();
            command = Console.ReadLine();
            while(command!= "Engines done")
            {
                string[] tockens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var newEngine = new Engine(int.Parse(tockens[0]), double.Parse(tockens[1]));
                engines.Add(newEngine);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while(command!= "Show special")
            {
                string[] tocken = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int tireIndex = int.Parse(tocken[5]);
                int engineIndex = int.Parse(tocken[6]);
                string make = tocken[0];
                string model = tocken[1];
                int year = int.Parse(tocken[2]);
                var fuelQuantity = double.Parse(tocken[3]);
                var fuelConsumption = double.Parse(tocken[4]);
                Tire[] tire = tires[tireIndex];
                Engine engine = engines[engineIndex];
                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);
                cars.Add(car);
                command = Console.ReadLine();

            }
            cars = cars.Where(c => c.Year >= 2017).Where(c => c.Engine.HorsePower > 330).Where(c => c.Tires.Sum(t => t.Pressure) >= 9).Where(c => c.Tires.Sum(t => t.Pressure) <= 10).ToList();
            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    StringBuilder builder = new StringBuilder();

                    car.Drive(20);

                    builder.AppendLine($"Make: {car.Make}");
                    builder.AppendLine($"Model: {car.Model}");
                    builder.AppendLine($"Year: {car.Year.ToString()}");
                    builder.AppendLine($"HorsePowers: {car.Engine.HorsePower.ToString()}");
                    builder.AppendLine($"FuelQuantity: {car.FuelQuantity.ToString()}");

                    Console.Write(builder);
                }
            }
        }
    }
}
