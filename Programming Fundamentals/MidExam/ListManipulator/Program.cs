using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine()
                                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();
            string[] command = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while(command[0]!= "Report")
            {
                switch (command[0])
                {
                    case "Blacklist":
                        string nameToBlacklist = command[1];
                        Blacklist(friends, nameToBlacklist);
                        break;
                    case "Error":
                        int indexError = int.Parse(command[1]);
                        Error(friends, indexError);
                        break;
                    case "Change":
                        int indexChange = int.Parse(command[1]);
                        string newName = command[2];
                        Change(friends, indexChange, newName);
                        break;
                }
                command = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            int blackListedCounts = 0;
            int lostNamesCount = 0;
            foreach ( string name in friends)
            {
                if(name== "Blacklisted")
                {
                    blackListedCounts++;
                }
                else if (name == "Lost")
                {
                    lostNamesCount++;
                }
            }
            Console.WriteLine($"Blacklisted names: {blackListedCounts}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(" ", friends));
            
        }
        static void Blacklist(List<string> friends,string name)
        {
            if (friends.Contains(name))
            {
                int index = friends.IndexOf(name);
                friends[index] = "Blacklisted";
                Console.WriteLine($"{name} was blacklisted.");
            }
            else
            {
                Console.WriteLine($"{name} was not found.");
            }
        }
        static void Error(List<string> friends,int index)
        {
            if(friends[index]!= "Blacklisted" && friends[index]!= "Lost")
            {
                string name = friends[index];
                friends[index] = "Lost";
                Console.WriteLine($"{name} was lost due to an error.");
            }
        }
        static void Change(List<string> friends, int index, string newName)
        {
            if (index > -1 && index < friends.Count)
            {
                string name = friends[index];
                friends[index] = newName;
                Console.WriteLine($"{name} changed his username to {newName}.");
            }
        }
    }
}
