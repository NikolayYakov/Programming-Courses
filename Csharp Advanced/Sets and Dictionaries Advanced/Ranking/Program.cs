using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
            while(input!= "end of contests")
            {
                string[] contest = input.Split(":",StringSplitOptions.RemoveEmptyEntries);
                string contestName = contest[0];
                string contestPass = contest[1];
                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, contestPass);
                }
                input = Console.ReadLine();
            }
            string date = Console.ReadLine();
            while(date!= "end of submissions")
            {
                string[] info = date.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contestName = info[0];
                string contestPass = info[1];
                string name = info[2];
                int points = int.Parse(info[3]);
                if (!candidates.ContainsKey(name)&& contests.ContainsKey(contestName) && contests[contestName] == contestPass)
                {
                    candidates.Add(name,new Dictionary<string, int>());
;               }
                if (candidates.ContainsKey(name)&&candidates[name].ContainsKey(contestName) && contests[contestName] == contestPass)
                {
                    if (points > candidates[name][contestName])
                    {
                        candidates[name][contestName] = points;
                    }
                }
                else if (candidates.ContainsKey(name) && contests.ContainsKey(contestName) && contests[contestName] == contestPass&&!candidates[name].ContainsKey(contestName))
                {
                    candidates[name].Add(contestName, points);
                }
                date = Console.ReadLine();
            }
            int bestPoints = int.MinValue;
            string bestCandidate = string.Empty;
            foreach (var candidate in candidates)
            {
                int totalPoint = 0;
                foreach (var item in candidate.Value)
                {
                    totalPoint += item.Value;
                }
                if (totalPoint > bestPoints)
                {
                    bestCandidate = candidate.Key;
                    bestPoints = totalPoint;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var candidate in candidates.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{candidate.Key}");
                foreach (var points in candidate.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
    }
}
