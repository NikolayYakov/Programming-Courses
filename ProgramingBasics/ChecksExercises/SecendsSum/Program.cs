using System;

namespace SecendsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirdTime;
            if (totalTime < 60)
            {
                if (totalTime >= 10)
                {

                    Console.WriteLine($"0:{totalTime}");

                }
                else
                {
                    Console.WriteLine($"0:0{totalTime}");
                }
            }
            else
            {
                int minutes = totalTime / 60;
                int seconds = totalTime % 60;
                if (seconds < 10)
                {
                    Console.WriteLine($"{minutes}:0{seconds:f0}");
                }
                else
                {
                    Console.WriteLine($"{minutes}:{seconds}");
                }
            }
        }
    }
}
