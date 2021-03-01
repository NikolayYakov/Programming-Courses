using System;
using System.Collections.Generic;

namespace PersonsInfo
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                int lines = int.Parse(Console.ReadLine());
                List<Person> people = new List<Person>();
                for (int i = 0; i < lines; i++)
                {
                    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Person person = new Person(data[0], data[1], int.Parse(data[2]));
                    people.Add(person);
                }
                Team team = new Team("dreamTeam");
                people.ForEach(p => team.AddPlayer(p));
                Console.WriteLine($"first team: {team.FirstTeam.Count}");
                Console.WriteLine($"reserve team: { team.ReserveTeam.Count}.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

        }
    }
}
