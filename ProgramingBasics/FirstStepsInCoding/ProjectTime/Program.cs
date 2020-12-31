using System;

namespace ProjectTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int TimeNeeded = projects * 3;
            Console.WriteLine($"The architect {name} will need {TimeNeeded} hours to complete {projects} project/s.");
        }
    }
}
