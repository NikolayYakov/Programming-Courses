using System;
using System.Numerics;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double simpleInteres = money;
            double complexInteres = money;
            double complexInteresMoney = money;
            double simpleInteresMoney = money;
            for(int n = 1; n <= months; n++)
            {
                simpleInteres *= 0.03;
                simpleInteresMoney += simpleInteres;
                simpleInteres = money;
            }
            for(int i = 1; i <= months; i++)
            {
                complexInteres *= 0.027;
                complexInteresMoney += complexInteres;
                complexInteres = complexInteresMoney;
            }
            Console.WriteLine($"Simple interest rate: {simpleInteresMoney:F2} lv.");
            Console.WriteLine($"Complex interest rate: {complexInteresMoney:f2} lv.");
            double difference= Math.Abs(simpleInteresMoney - complexInteresMoney);
            if (simpleInteresMoney > complexInteres)
            {
                Console.WriteLine($"Choose a simple interest rate. You will win {difference:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Choose a complex interest rate. You will win {difference:f2} lv.");
                
            }
        }
    }
}
