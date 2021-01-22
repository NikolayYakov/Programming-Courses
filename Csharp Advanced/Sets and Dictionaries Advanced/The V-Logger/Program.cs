using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> datebase = new Dictionary<string, Dictionary<string, List<string>>>();
            string[] input = Console.ReadLine().Split();
            while(input[0]!= "Statistics")
            {
                string vlogerName = input[0];
                string command = input[1];
                if(command== "joined")
                {
                    if (!datebase.ContainsKey(vlogerName))
                    {
                        datebase.Add(vlogerName, new Dictionary<string, List<string>>());
                        datebase[vlogerName].Add("followers", new List<string>());
                        datebase[vlogerName].Add("following", new List<string>());
                    }
                   

                }
                else if(command== "followed")
                {
                    string followingName = input[2];
                    if (vlogerName != followingName && datebase.ContainsKey(vlogerName) && datebase.ContainsKey(followingName)&&!datebase[followingName]["followers"].Contains(vlogerName))
                    {
                        datebase[vlogerName]["following"].Add(followingName);
                        datebase[followingName]["followers"].Add(vlogerName);
                    }
                }
                input = Console.ReadLine().Split();

            }
            Console.WriteLine($"The V-Logger has a total of {datebase.Count} vloggers in its logs.");
            int count = 1;
            foreach (var item in datebase.OrderByDescending(x=>x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (count == 1)
                {
                    foreach (var follower in item.Value["followers"].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            } 

            
            
             
            

        }
    }
}
