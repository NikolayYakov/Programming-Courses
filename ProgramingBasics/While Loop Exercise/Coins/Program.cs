using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            
            int coins = 0;
            while (money > 0)
            {
                money = Math.Round(money, 2);
                if (money >= 2)
                {
                    money -= 2;
                    coins += 1;
                }
                else if (money >= 1)
                {
                    money -= 1;
                    coins += 1;
                }
                else if (money >= 0.50)
                {
                    money -= 0.50;
                    coins += 1;
                }
                else if (money >= 0.20)
                {
                    money -= 0.20;
                    coins += 1;
                }
                else if (money >= 0.10)
                {
                    money -= 0.10;
                    coins += 1;
                }
                else if (money >= 0.05)
                {
                    money -= 0.05;
                    coins += 1;
                }
                else if (money >= 0.02)
                {
                    money -= 0.02;
                    coins += 1;
                }
                else
                {
                    money -= 0.01;
                    coins += 1;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
