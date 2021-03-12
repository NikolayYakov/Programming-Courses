using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<IBorn> creatures = new List<IBorn>();
            while (command != "End")
            {
                
                string[] tocken = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tocken[0] == "Pet")
                {
                    IBorn Pet = new Pet(tocken[1], tocken[2]);
                    creatures.Add(Pet);
                }
                else if(tocken[0]== "Citizen")
                {
                    IBorn citizen = new Human(tocken[1], int.Parse(tocken[2]), tocken[3], tocken[4]);
                    creatures.Add(citizen);
                }
                else
                {
                    Robot robot = new Robot(tocken[1], tocken[2]);
                }
                command = Console.ReadLine();
            }
            string year = Console.ReadLine();
            foreach (var item in creatures)
            {
                item.BirthYear(year);
            }
        }
    }
}
