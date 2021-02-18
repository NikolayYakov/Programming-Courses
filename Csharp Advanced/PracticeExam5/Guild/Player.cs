using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public Player(string name,string clas)
        {
            Name = name;
            Class = clas;
            Rank = "Trial";
            Description = "n/a";
        }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Player {Name}: {Class}");
            output.AppendLine($"Rank: {Rank}");
            output.AppendLine($"Description: {Description}");
            return output.ToString().Trim();
        }

    }
}
