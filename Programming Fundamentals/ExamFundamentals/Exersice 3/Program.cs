using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> people = new Dictionary<string, List<int>>();
            string[] command = Console.ReadLine()
                                      .Split("=", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Statistics")
            {
                switch (command[0])
                {
                    case "Add":
                        string name = command[1];
                        int sent = int.Parse(command[2]);
                        int recived = int.Parse(command[3]);
                        Add(people, name, sent, recived);
                        break;
                    case "Message":
                        string sender = command[1];
                        string reciever = command[2];
                        Message(people, sender, reciever, capacity);
                        break;
                    case "Empty":
                        string username = command[1];
                        Empty(people, username);
                        break;
                }
                command = Console.ReadLine()
                                  .Split("=", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Users count: {people.Count}");
            foreach (var item in people.OrderByDescending(x=>x.Value[1]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[2]}");
            }

        }
        static void Add(Dictionary<string,List<int>> people,string name,int sent,int recieve)
        {
            if (people.ContainsKey(name) == false)
            {
                people.Add(name, new List<int>());
                people[name].Add(sent);
                people[name].Add(recieve);
                int full = sent + recieve;
                people[name].Add(full);
                
            }
        }
        static void Message(Dictionary<string, List<int>> people, string sender,string reciever,int capacity)
        {
            if (people.ContainsKey(sender) && people.ContainsKey(reciever))
            {
                people[sender][0]++;
                people[sender][2]++;
                if (people[sender][2]>= capacity)
                {
                    people.Remove(sender);
                    Console.WriteLine($"{sender} reached the capacity!");
                }
                people[reciever][1]++;
                people[reciever][2]++;
                if (people[reciever][2]>= capacity)
                {
                    people.Remove(reciever);
                    Console.WriteLine($"{reciever} reached the capacity!");

                }
            }
        }
        static void Empty(Dictionary<string, List<int>> people, string username)
        {
            if (username == "All")
            {
                people.Clear();
            }
            else if (people.ContainsKey(username))
            {
                people.Remove(username);
            }
        }
    }
}
