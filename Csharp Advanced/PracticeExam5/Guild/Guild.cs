using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public Guild(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            roaster = new List<Player>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return roaster.Count; } }
        List<Player> roaster;
        public void AddPlayer(Player player)
        {
            if (roaster.Count < Capacity)
            {
                roaster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            var player = roaster.FirstOrDefault(n => n.Name == name);
            if (player != null)
            {
                roaster.Remove(player);
                return true;
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            var player = roaster.FirstOrDefault(n => n.Name == name);
            if(player!=null&&player.Rank!= "Member")
            {
                player.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            var player = roaster.FirstOrDefault(n => n.Name == name);
            if (player != null && player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string clas)
        {
            Player[] kicked = roaster.Where(n => n.Class == clas).ToArray();
            roaster = roaster.Where(n => n.Class != clas).ToList();
            return kicked;
        }
        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Players in the guild: {Name}");
            foreach (var item in roaster)
            {
                output.AppendLine(item.ToString());
            }
            return output.ToString().Trim();
        }
    }
}
