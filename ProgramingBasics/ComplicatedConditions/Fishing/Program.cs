using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double boatPrice = 0.0;
            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                    boatPrice = 4200;
                    break;
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
                    
            }
            
            
                if (fishers <= 6)
                {
                    boatPrice *= 0.90;
                }
                else if (fishers >= 12)
                {
                    boatPrice *= 0.75;
                }
                else
                {
                    boatPrice *= 0.85;
                }
            if (season != "Autumn")
            {
                if (fishers % 2 == 0)
                {
                    boatPrice *= 0.95;
                }
            }
            
            if (budget >= boatPrice)
            {
                double moneyLeft = budget - boatPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = boatPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
                
                


            
            



        }
    }
}
