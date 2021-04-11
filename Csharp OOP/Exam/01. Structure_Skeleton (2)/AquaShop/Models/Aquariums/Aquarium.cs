using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private List<IDecoration> decorations;
        private List<IFish> fishes;
        public Aquarium(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            fishes = new List<IFish>();
            decorations = new List<IDecoration>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort
        {
            get
            {
                int comfort = 0;
                foreach (var item in decorations)
                {
                    comfort += item.Comfort;
                }
                return comfort;
            }
        }


        public ICollection<IDecoration> Decorations => decorations.AsReadOnly();

        public ICollection<IFish> Fish => fishes.AsReadOnly();

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (Capacity == Fish.Count)
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
            fishes.Add(fish);
        }

        public void Feed()
        {
            foreach (var item in Fish)
            {
                item.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} ({this.GetType().Name}):");
            if (Fish.Count == 0)
            {
                sb.AppendLine("Fish: none");
            }
            else
            {
                sb.AppendLine($"Fish: {string.Join(", ", Fish.Select(f => f.Name))}");
            }
            sb.AppendLine($"Decorations: {Decorations.Count}");
            sb.AppendLine($"Comfort: {Comfort}");
            return sb.ToString().Trim();
            
        }

        public bool RemoveFish(IFish fish)
        {
            if (Fish.Contains(fish))
            {
                Fish.Remove(fish);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
