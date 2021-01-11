using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while(command!= "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] date = command
                                    .Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string side = date[0];
                    string name = date[1];
                    if (sides.ContainsKey(side))
                    {
                        if (sides[side].Contains(name)==false)
                        {
                            sides[side].Add(name);
                        }
                    }
                    else
                    {
                        sides.Add(side, new List<string>());
                        sides[side].Add(name);
                    }
                }
                if (command.Contains("->"))
                {
                    string[] date = command
                                     .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string side = date[1];
                    string name = date[0];
                    if (sides.ContainsKey(side)==false)
                    {
                        sides.Add(side, new List<string>());
                    }
                    bool isExist = false;
                    foreach (var people in sides)
                    {
                        if (people.Value.Contains(name))
                        {
                            isExist = true;
                        }
                        if (isExist == true)
                        {
                            people.Value.Remove(name);
                            sides[side].Add(name);
                            break;
                        }
                        
                    }
                    if (isExist == false)
                    {  
                        sides[side].Add(name);                              
                    }
                    Console.WriteLine($"{name} joins the {side} side!");
                }
                command = Console.ReadLine();
                                  

            }
            foreach ( var side in sides.OrderBy(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var name in side.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {name}");
                    }
                }
                
            }
        }
    }
}
