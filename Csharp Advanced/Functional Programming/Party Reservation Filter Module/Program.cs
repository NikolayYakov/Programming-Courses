using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();
            string[] command = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            List<string> fillters = new List<string>();
            while(command[0] != "Print")
            {
                if (command[0]== "Add filter")
                {
                    fillters.Add(command[1]+" "+command[2]);
                }
                else if(command[0]=="Remove filter")
                {
                    fillters.Remove(command[1]+" "+command[2]);
                }
                command = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in fillters)
            {
                string[] tocken = item.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(tocken[0]== "Starts")
                {
                    people = people.Where(p => !p.StartsWith(tocken[2])).ToList();
                }
                else if (tocken[0] == "Ends")
                {
                    people = people.Where(p => !p.EndsWith(tocken[2])).ToList();
                }
                else if(tocken[0]== "Length")
                {
                    people = people.Where(p => p.Length != int.Parse(tocken[1])).ToList();
                }
                else if(tocken[0]== "Contains")
                {
                    people = people.Where(p => !p.Contains(tocken[1])).ToList();
                }
            }
            if (people.Any())
            {
                Console.WriteLine(string.Join(" ", people));
            }

                                          
        }
    }
}
