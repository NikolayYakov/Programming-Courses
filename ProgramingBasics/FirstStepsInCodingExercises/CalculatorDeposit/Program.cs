
using System;

namespace CalculatorDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double increasePer = double.Parse(Console.ReadLine());
            double sum = depositSum + term * ((depositSum * increasePer / 100) / 12);
            Console.WriteLine(sum);

        }
    }
}
