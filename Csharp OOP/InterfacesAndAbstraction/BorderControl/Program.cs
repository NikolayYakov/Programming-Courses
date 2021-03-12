using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<IIdentifiable> citizens = new List<IIdentifiable>();
            while(command!= "End")
            {
                IIdentifiable citizen;
                string[] tocken = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tocken.Length == 2)
                {
                     citizen = new Robot(tocken[0], tocken[1]);
                }
                else
                {
                    citizen = new Human(tocken[0], int.Parse(tocken[1]), tocken[2]);
                }
                citizens.Add(citizen);
                command = Console.ReadLine();
            }
            string fakeNumbers = Console.ReadLine();
            foreach (var citizen in citizens)
            {
                citizen.Fake(fakeNumbers);
            }
        }
    }
}
