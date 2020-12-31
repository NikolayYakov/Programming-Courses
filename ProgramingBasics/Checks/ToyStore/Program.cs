using System;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleOrdered = int.Parse(Console.ReadLine());
            int talkingDollsOrdered = int.Parse(Console.ReadLine());
            int teddyBearsOrdered = int.Parse(Console.ReadLine());
            int minionsOrdered = int.Parse(Console.ReadLine());
            int trucksOrdered = int.Parse(Console.ReadLine());
            double puzzleFullPrice = puzzleOrdered * 2.60;
            int talkingDollsFullPrice = talkingDollsOrdered * 3;
            double teddyBearsFullPrice = teddyBearsOrdered * 4.10;
            double minionsFullPrice = minionsOrdered * 8.20;
            int trucksFullPrice = trucksOrdered * 2;
            int ToysOrdered = puzzleOrdered + talkingDollsOrdered + teddyBearsOrdered + minionsOrdered + trucksOrdered;
            double fullPrice = puzzleFullPrice + talkingDollsFullPrice + teddyBearsFullPrice + minionsFullPrice + trucksFullPrice;
            double finalAmount = 0;
            if (ToysOrdered >= 50)
            {
                double discount = fullPrice *  25/ 100;
                double discountedPrice = fullPrice - discount;
                 finalAmount = discountedPrice * 90 / 100;
                if (finalAmount >= tripPrice)
                {
                    double moneyLeft = finalAmount - tripPrice;
                    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
                }
                else
                {
                    double moneyNeeded = tripPrice - finalAmount;
                    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
                }
            }
            else
            {
                finalAmount = fullPrice * 90 / 100;
                if (finalAmount >= tripPrice)
                {
                    
                    double moneyLeft = finalAmount-tripPrice;
                    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
                }
                else
                {
                    double moneyNeeded = tripPrice - finalAmount;
                    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
                }
            }
        }
    }
}
