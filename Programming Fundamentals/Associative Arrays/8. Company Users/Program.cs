using System;
using System.Collections.Generic;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();
            string[] command = Console.ReadLine()
                                      .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "End")
            {
                string company = command[0];
                string id = command[1];
                if (companies.ContainsKey(company))
                {
                    bool isIdContained = companies[company].Contains(id);
                    if (isIdContained == false)
                    {
                        companies[company].Add(id);
                    }
                }
                else
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(id);
                }

                command = Console.ReadLine()
                                  .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                for(int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }
        }
    }
}
