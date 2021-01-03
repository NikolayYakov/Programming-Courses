using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int apartmentWidth = int.Parse(Console.ReadLine());
            int apartmentLength = int.Parse(Console.ReadLine());
            int apartmentHeight = int.Parse(Console.ReadLine());
            int cubicMeters = apartmentHeight * apartmentLength * apartmentWidth;
            string boxes = Console.ReadLine();
            int allBoxes = 0;
            while (boxes != "Done")
            {
                int boxesCount = int.Parse(boxes);
                allBoxes += boxesCount;
                if (allBoxes >= cubicMeters)
                {
                    int spaceNeeded = allBoxes - cubicMeters;
                    Console.WriteLine($"No more free space! You need {spaceNeeded} Cubic meters more.");
                    break;
                }
                boxes = Console.ReadLine();
            }
            if (cubicMeters > allBoxes)
            {
                int spaceLeft = cubicMeters - allBoxes;
                Console.WriteLine($"{spaceLeft} Cubic meters left.");
            }
        }
    }
}
