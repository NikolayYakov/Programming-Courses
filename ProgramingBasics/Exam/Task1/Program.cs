using System;
using System.Threading.Channels;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double cardPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            double ramAmount = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            cpuPrice *= 1.57;
            cardPrice *= 1.57;
            ramPrice *= 1.57;
            ramPrice *= ramAmount;
            double cardDiscount = cardPrice * discount;
            cardPrice -= cardDiscount;
            double cpuDiscount = cpuPrice * discount;
            cpuPrice -= cpuDiscount;
            double fullPrice = cpuPrice + cardPrice + ramPrice;
            Console.WriteLine($"Money needed - {fullPrice:F2} leva.");
        }
    }
}
