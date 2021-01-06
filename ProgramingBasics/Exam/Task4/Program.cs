using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double simpleInterestMoney = money;
            double complexInterestMoney = money;
            double simpleInterest = money;
            double complexInterest = money;
            for(int n = 1; n <= months; n++)
            {
                simpleInterest *= 0.03 ;
                simpleInterestMoney += simpleInterest;
                complexInterest *= 0.027;
                complexInterestMoney += complexInterest;
                simpleInterest
            }
        }
    }
}
