using System;

namespace safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double gas = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double moneyNeeded = 0.0;
            gas *= 2.10;
            moneyNeeded += gas;
            moneyNeeded += 100;
            switch (day)
            {
                case "Saturday":
                    moneyNeeded *= 0.90;
                    break;
                case "Sunday":
                    moneyNeeded *= 0.80;
                    break;
            }
           double moneyLeft = Math.Abs(budget - moneyNeeded);
            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
              



            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {moneyLeft:f2} lv. ");
                
            }
        }
    }
}
