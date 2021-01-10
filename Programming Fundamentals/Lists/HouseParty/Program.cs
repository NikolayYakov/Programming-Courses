using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int listCount = int.Parse(Console.ReadLine());
            List<string> partyList = new List<string>(listCount);
            for(int i = 0; i < listCount; i++)
            {
                List<string> peopleGoing = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .ToList();
                if(peopleGoing[2] == "not")
                {
                    if (partyList.Contains(peopleGoing[0]))
                    {
                        partyList.Remove(peopleGoing[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{peopleGoing[0]} is not in the list!");
                    }
                    
                }
                else
                {
                    if (partyList.Contains(peopleGoing[0]))
                    {
                        Console.WriteLine($"{peopleGoing[0]} is already in the list!");
                    }
                    else
                    {
                        partyList.Add(peopleGoing[0]);
                    }
                    
                }
                
            }
           for(int i = 0; i < partyList.Count; i++)
            {
                Console.WriteLine(partyList[i]);
            }
        }
    }
}
