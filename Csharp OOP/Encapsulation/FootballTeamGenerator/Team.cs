using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;
        public Team(string name)
        {
            players = new List<Player>();
            Name = name;
        }


        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public IReadOnlyCollection<Player> Players
        {
            get => players.AsReadOnly();
        }

        public int Count { get { return players.Count; } }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            Player player = null;
            for(int i = 0; i < Count; i++)
            {
                if(playerName == players[i].Name)
                {
                    player = players[i];
                }
            }
            if (player==null)
            {
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");
            }
            players.Remove(player);
        }
        public void TeamStats()
        {
            double rating = 0;
            foreach (var player in players)
            {
                rating += player.GetStats();
            }
            if (Count != 0)
            {
                rating /= Count;
            }
            
            Console.WriteLine($"{Name} - {rating:f0}");
        }
    }
}
