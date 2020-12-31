using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double fishTankVolume = lengthCm * widthCm * heightCm;
            double liters = fishTankVolume / 1000;
            double finalPercent = percent / 100;
            double neededliters = liters * (1 - finalPercent);
            Console.WriteLine(neededliters);
        }
    }
}
