using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int counter = 0;
            double fullPrice = 0.0;
            while (true)
            {
                string item = Console.ReadLine();
                if (item == "Stop")
                {
                    Console.WriteLine($"You bought {counter} products for {fullPrice:f2} leva.");
                    break;
                }
                double price = double.Parse(Console.ReadLine());
                counter++;
                if (counter % 3 == 0)
                {
                    price *= 0.50;
                }
                
                fullPrice += price;
                
                
                if (budget<fullPrice)
                {
                    fullPrice -= budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {fullPrice:f2} leva!");
                    break;
                }

            }
        }
    }
}
