using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfShowBalls = int.Parse(Console.ReadLine());
            BigInteger sum = 0;

            BigInteger biggestSum = 0;
            int biggestSnow = 0;
            int biggestTime = 0;
            int biggestQuality = 0;
            for(int i = 1; i <= numberOfShowBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int divided = (snowballSnow / snowballTime);

                 sum = BigInteger.Pow(divided, snowballQuality);
               
                if (sum > biggestSum)
                {
                    biggestSum = sum; 
                    biggestTime = snowballTime;
                    biggestSnow = snowballSnow;
                    biggestQuality = snowballQuality;
                }

            }
            Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestSum} ({biggestQuality})");
        }
    }
}
