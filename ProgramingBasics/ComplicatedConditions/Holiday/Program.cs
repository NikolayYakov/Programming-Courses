using System;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string distination = "";
            double expenses = 0.0;
            string holidayType = "";
            if (budget <= 100)
            {
                distination = "Bulgaria";
                if (season == "summer")
                {
                    expenses = 0.30 * budget;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    expenses = 0.70 * budget;
                    holidayType="Hotel";
                }
            }
            else if (budget <= 1000)
            {
                distination = "Balkans";
                if (season == "summer")
                {
                    expenses = 0.40 * budget;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    expenses = 0.80 * budget;
                    holidayType = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                distination = "Europe";
                expenses = 0.90 * budget;
                holidayType = "Hotel";
            }
              
            Console.WriteLine($"Somewhere in {distination}");
            Console.WriteLine($"{holidayType} - {expenses:f2}");
        }
    }
}
