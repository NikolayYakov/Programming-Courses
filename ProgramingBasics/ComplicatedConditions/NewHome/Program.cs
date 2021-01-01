using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowersAmount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double fullPrice = 0.0;
            double moneyLeft = 0.0;
            switch (flower)
            {
                case "Roses":
                    fullPrice = flowersAmount * 5;
                    if (flowersAmount > 80)
                    {
                        fullPrice *= 0.9;
                    }
                    break;
                case "Dahlias":
                    fullPrice = flowersAmount * 3.80;
                    if (flowersAmount > 90)
                    {
                        fullPrice *= 0.85;
                    }
                    break;
                case "Tulips":
                    fullPrice = flowersAmount * 2.80;
                    if (flowersAmount > 80)
                    {
                        fullPrice *= 0.85;
                    }
                    break;
                case "Narcissus":
                    fullPrice = flowersAmount * 3.0;
                    if (flowersAmount < 120)
                    {
                        fullPrice *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    fullPrice = flowersAmount * 2.50;
                    if (flowersAmount < 80)
                    {
                        fullPrice *= 1.20;
                    }
                    break;

            }
            moneyLeft = budget - fullPrice;
            if (budget >= fullPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersAmount} {flower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                moneyLeft *= -1;
                Console.WriteLine($"Not enough money, you need {moneyLeft:f2} leva more.");
            }
        }
    }
}
