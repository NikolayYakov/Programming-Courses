using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>(teamCount);
            for(int i = 0; i < teamCount; i++)
            {
                string[] info = Console.ReadLine()
                                       .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string owner = info[0];
                string teamName = info[1];
                Team team = new Team(owner, teamName);
                bool isTeamNameExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isOwnerExist = teams.Select(x => x.Owner).Contains(owner);
                if (isTeamNameExist == false && isOwnerExist == false)
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {owner}!");
                    
                }
                if (isTeamNameExist == true)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    
                }
                if (isOwnerExist == true)
                {
                    Console.WriteLine($"{owner} cannot create another team!");
                    
                }
                
            }
            string[] members = Console.ReadLine()
                                          .Split("->", StringSplitOptions.RemoveEmptyEntries);
            while (members[0] != "end of assignment")
            {
                string member = members[0];
                string teamName = members[1];
                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isMemberExist = teams.Select(x => x.Members).Any(x => x.Contains(member));
                bool isCreatorExist = teams.Select(x => x.Owner).Contains(member);
                if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isMemberExist == true)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else if (isCreatorExist == true)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");

                }
                if (isMemberExist == false && isTeamExist == true && isCreatorExist==false)
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(member);
                }
                members = Console.ReadLine()
                                 .Split("->", StringSplitOptions.RemoveEmptyEntries);
            }
            List<Team> valid = teams.Where(x => x.Members.Count > 0).OrderByDescending(x=>x.Members.Count).ThenBy(x=>x.TeamName).ToList();
            List<Team> disbanned = teams.Where(x => x.Members.Count == 0).OrderBy(x=>x.TeamName).ToList();
            foreach (Team t in valid)
            {
                Console.WriteLine(t.TeamName);
                Console.WriteLine($"- {t.Owner}");
                t.Members.Sort();
                for(int i = 0; i < t.Members.Count; i++)
                {
                    
                    Console.WriteLine($"-- {t.Members[i]}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach  (Team t in disbanned)
            {
                 
                Console.WriteLine(t.TeamName);
            }
        }
       

    }
    class Team
    {
        public Team(string owner,string teamName)
        {
            Owner = owner;
            TeamName = teamName;
            Members = new List<string>();
        }
        public string Owner { get; set; }
        public string TeamName { get; set; }

        public List<string> Members { get; set; }
    }
}
