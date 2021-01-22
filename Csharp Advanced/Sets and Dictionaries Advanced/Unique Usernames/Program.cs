using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                usernames.Add(name);
            }
            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
