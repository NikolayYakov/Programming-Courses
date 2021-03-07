using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]),double.Parse(carInfo[3]));
            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]),double.Parse(truckInfo[3]));
            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                double amount = double.Parse(command[2]);
                if(command[0]== "Drive")
                {
                    if(command[1]=="Car")
                    {
                        car.Drive(amount);
                    }
                    else if(command[1]=="Truck")
                    {
                        truck.Drive(amount);
                    }
                    else
                    {
                        bus.Drive(amount);
                    }
                }
                else if(command[0]== "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(amount);
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(amount);
                    }
                    else
                    {
                        bus.Refuel(amount);
                    }
                }
                else
                {
                    ((Bus)bus).EmtyDriving(amount);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
