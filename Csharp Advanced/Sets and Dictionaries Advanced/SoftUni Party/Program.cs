using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
            string command = Console.ReadLine();
            while(command!= "PARTY")
            {
                if (Char.IsDigit(command[0]))
                {
                    vip.Add(command);
                }
                else if(command.Length==8)
                {
                    guests.Add(command);
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "END")
            {
                if (vip.Contains(command))
                {
                    vip.Remove(command);
                }
                if (guests.Contains(command))
                {
                    guests.Remove(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(vip.Count + guests.Count);
            foreach (var vipG in vip)
            {
                Console.WriteLine(vipG);
            }
            foreach (var normalG in guests)
            {
                Console.WriteLine(normalG);
            }
        }
    }
}
