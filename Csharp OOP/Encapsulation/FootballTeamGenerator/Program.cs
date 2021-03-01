using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string command = Console.ReadLine();
            while(command!= "END")
            {
                string[] data = command.Split(";");
                if (data[0] == "Team")
                {
                    try
                    {
                        string name = data[1];
                        Team team = new Team(name);
                        teams.Add(team);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (data[0] == "Add")
                {
                    try
                    {
                        string teamName = data[1];
                        string playerName = data[2];
                        int index = -1;
                        for (int i = 0; i < teams.Count; i++)
                        {
                            if (teamName == teams[i].Name)
                            {
                                index = i;
                                break;
                            }
                        }
                        if (index == -1)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            int endurance = int.Parse(data[3]);
                            int spring = int.Parse(data[4]);
                            int dribble = int.Parse(data[5]);
                            int passing = int.Parse(data[6]);
                            int shooting = int.Parse(data[7]);
                            Player player = new Player(playerName, endurance, spring, dribble, passing, shooting);

                            teams[index].AddPlayer(player);
                        }
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                }
                else if (data[0] == "Remove")
                {
                    try
                    {
                        string teamName = data[1];
                        string name = data[2];
                        int index = -1;
                        for (int i = 0; i < teams.Count; i++)
                        {
                            if (teams[i].Name == teamName)
                            {
                                index = i;
                                break;
                            }
                        }
                        teams[index].RemovePlayer(name);
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else if (data[0] == "Rating")
                {
                    try
                    {
                        string teamName = data[1];
                        int index = -1;
                        for (int i = 0; i < teams.Count; i++)
                        {
                            if (teamName == teams[i].Name)
                            {
                                index = i;
                                break;
                            }

                        }
                        if (index == -1)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            teams[index].TeamStats();
                        }
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
