using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            double waterTankCapacity = 255;
            double waterSum = 0;
            int fills = int.Parse(Console.ReadLine());
            for(int i = 1; i <= fills; i++)
            {
                double addWater = double.Parse(Console.ReadLine());
                waterSum += addWater;
                if (waterSum > waterTankCapacity)
                {
                    waterSum -= addWater;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterSum);
        }
    }
}
