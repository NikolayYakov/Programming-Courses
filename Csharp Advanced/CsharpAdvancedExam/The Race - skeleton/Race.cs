using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        public Race(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }
        List<Racer> data;
        public void Add(Racer Racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(Racer);
            }
        }
        public bool Remove(string name)
        {
            var racer = data.FirstOrDefault(n => n.Name == name);
            if (racer != null)
            {
                data.Remove(racer);
                return true;
            }
            return false;
        }
        public Racer GetOldestRacer()
        {
            List<Racer> fillter = data.OrderByDescending(r => r.Age).ToList();
            var racer = fillter.FirstOrDefault(r => r.Age > 0);
            return racer;
        }
        public Racer GetRacer(string name)
        {
            var racer = data.FirstOrDefault(r => r.Name == name);
            return racer;
            
        }
        public Racer GetFastestRacer()
        {
            List<Racer> fillter = data.OrderByDescending(r => r.Car.Speed).ToList();
            var racer = fillter.FirstOrDefault(r => r.Car.Speed > 0);
            return racer;
        }
        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Racers participating at {Name}:");
            foreach (var item in data)
            {
                output.AppendLine(item.ToString());
            }
            return output.ToString().Trim();
        }
    }
}
