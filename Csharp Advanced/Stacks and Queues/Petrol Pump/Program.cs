using System;
using System.Collections.Generic;
using System.Linq;

namespace Petrol_Pump
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            int count = 0;
            int totalGas = 0;
            int currentIndex = 0;
            Queue<string> totalPumps = new Queue<string>();
            for(int i = 0; i < petrolPumps; i++)
            {
                totalPumps.Enqueue(Console.ReadLine());
            }
            while (count < petrolPumps)
            {
                string currentPump = totalPumps.Dequeue();
                int[] pumpValues = currentPump.Split().Select(int.Parse).ToArray();
                int gas = pumpValues[0];
                int distance = pumpValues[1];
                totalGas += gas;
                if (totalGas - distance >= 0)
                {
                    totalGas -= distance;
                    count++;
                    totalPumps.Enqueue(currentPump);
                }
                else
                {
                    currentIndex += count+1;
                    count = 0;
                    totalPumps.Enqueue(currentPump);
                    totalGas = 0;
                    
                }
            }
            Console.WriteLine(currentIndex);
        }
    }
}
