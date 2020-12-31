using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double swimmingRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());
            double wholeTime = distance * timeForOneMeter;
            
            double distanceDelay = distance / 15;
            distanceDelay = Math.Floor(distanceDelay);
            double delay = distanceDelay * 12.5 ;
            
            wholeTime += delay;
            bool newSwimmingRecord = swimmingRecord > wholeTime;
            if (newSwimmingRecord == true)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {wholeTime:F2} seconds.");
            }
            else
            {
                double timeNeeded = wholeTime - swimmingRecord;
                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}
