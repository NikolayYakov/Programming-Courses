using System;
using System.Dynamic;

namespace SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());
            int toysAmount = 0;
            double money = 0.0;
            double brothersMoney = 1;
            double toysFullPrice = 0.0;
            double moneyLeft = 0.0;
            double moneyScale = 10.0;
            for(int i = 1; i <= liliAge; i++)
            {
                if (i % 2 != 0)
                {
                    toysAmount += 1;
                }
                if (i == 2)
                {
                    money = 10.00-brothersMoney;
                    
                }
                else if (i % 2 == 0)
                {
                    moneyScale += 10;
                    money = money + moneyScale - brothersMoney;
                }
                 
            }
            toysFullPrice = toysAmount * toysPrice;
            money += toysFullPrice;
            if (money >= washingMachine)
            {
                moneyLeft = money-washingMachine;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                moneyLeft = washingMachine - money;
                Console.WriteLine($"No! {moneyLeft:f2}");
            }
        }
    }
}
