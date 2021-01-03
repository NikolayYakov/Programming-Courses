using System;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            double moneyOwned = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int spendingCounter = 0;
            string lastDay = "spend";
            while (spendingCounter < 5 && moneyOwned < holidayPrice)
            {
                string activity = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayCounter++;
                if(activity== "spend")
                {
                    moneyOwned -= money;
                    
                    if (activity != lastDay)
                    {
                        spendingCounter=0;
                        spendingCounter++;
                    }
                   
                    else
                    {
                        spendingCounter++;
                    }
                    
                    if (moneyOwned < 0)
                    {
                        moneyOwned = 0.0;
                    }
                }
                else if (activity == "save")
                {
                    moneyOwned += money;
                }
                 lastDay = activity;
            }
            if (moneyOwned >= holidayPrice)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
                
            }
            else if (spendingCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayCounter);
            }
        }
    }
}
