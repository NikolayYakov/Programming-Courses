using System;

namespace SpiceMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int allMined = 0;
            int counter = 0;
            while (yield >= 100)
            {
                allMined += yield;
                yield -= 10;
                allMined -= 26;
                counter += 1;
            }
            if (allMined >= 26)
            {
                allMined -= 26;

            }
            else
            {
                allMined = 0;
            }
            Console.WriteLine(counter);
            Console.WriteLine(allMined);
            

        }
    }
}
