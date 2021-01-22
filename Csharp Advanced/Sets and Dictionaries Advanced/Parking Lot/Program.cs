using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> car = new HashSet<string>();
            string[] command = Console.ReadLine().Split(", ");
            while(command[0]!= "END")
            {
                string com = command[0];
                string carNumber = command[1];
                if (com == "IN")
                {
                    car.Add(carNumber);
                }
                if (com == "OUT")
                {
                    if (car.Contains(carNumber))
                    {
                        car.Remove(carNumber);
                    }
                }
                command = Console.ReadLine().Split(", ");
            }
            if (car.Count > 0)
            {
                foreach (var remainedCar in car)
                {
                    Console.WriteLine(remainedCar);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
