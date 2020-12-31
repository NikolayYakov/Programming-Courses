using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakeByOneCook = int.Parse(Console.ReadLine());
            int wafflesByOneCook = int.Parse(Console.ReadLine());
            int pancakeByOneCook = int.Parse(Console.ReadLine());
            double cakeSum = cakeByOneCook * 45;
            double wafflesSum = wafflesByOneCook * 5.80;
            double pancakeSum = pancakeByOneCook * 3.20;
            double amountForOneDay = (wafflesSum + pancakeSum + cakeSum) * cooks;
            double fullAmount = amountForOneDay * days;
            double expenses = fullAmount / 8;
            double finaleAmount = fullAmount - expenses;

            Console.WriteLine(finaleAmount);


        }
    }
}
