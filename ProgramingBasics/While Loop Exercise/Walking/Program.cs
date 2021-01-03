using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
            
        {
            string steps = Console.ReadLine();
            int stepsCount = 0;
            while (steps!= "Going home")
            {
                
                int stepsReal = int.Parse(steps);
                stepsCount += stepsReal;
                
                if(stepsCount>=10000)
                {
                    int stepsOver = stepsCount - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsOver} steps over the goal!");
                    break;
                }
                steps = Console.ReadLine();
            }
            if (steps == "Going home")
            {
                int futureSteps = int.Parse(Console.ReadLine());
                stepsCount +=futureSteps ;
                if (stepsCount < 10000)
                {
                    int stepsNeeded = 10000 - stepsCount;
                    Console.WriteLine($"{stepsNeeded} more steps to reach goal.");
                }
                else
                {
                    int stepsOver = stepsCount - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsOver} steps over the goal!");
                }
            }
        }
    }
}
