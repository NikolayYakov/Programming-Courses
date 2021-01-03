using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeHeight = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeSize = cakeHeight * cakeWidth;
            string cakePieces = Console.ReadLine();
            int cakeNeeded = 0;
            int sum = 0;
            while (cakePieces != "STOP")
            {
                int cakeRealPieces = int.Parse(cakePieces);
                sum += cakeRealPieces;
                if (sum >= cakeSize)
                {
                    cakeNeeded = sum - cakeSize;
                    Console.WriteLine($"No more cake left! You need {cakeNeeded} pieces more.");
                    break;
                }
                cakePieces = Console.ReadLine(); 
            }
            if (cakePieces == "STOP")
            {
                cakeNeeded = cakeSize - sum;
                Console.WriteLine($"{cakeNeeded} pieces are left.");
            }
        }
    }
}
