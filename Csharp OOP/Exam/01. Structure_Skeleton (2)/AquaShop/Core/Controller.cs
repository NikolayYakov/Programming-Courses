using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decoration;
        private List<IAquarium> aquariums;
        public Controller()
        {
            decoration = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium;
            if(aquariumType== "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if(aquariumType== "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }
            aquariums.Add(aquarium);
            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decor;
            if (decorationType == "Ornament")
            {
                decor = new Ornament();
            }
            else if(decorationType== "Plant")
            {
                decor = new Plant();
            }
            else
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }
            decoration.Add(decor);
            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            Fish fish;
            if(fishType== "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if(fishType== "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);

            }
            else
            {
                throw new InvalidOperationException("Invalid fish type.");
            }
            var aqua = aquariums.FirstOrDefault(f => f.Name == aquariumName);
            if(((fish is FreshwaterFish)&&(aqua is SaltwaterAquarium))||((fish is SaltwaterFish)&&(aqua is FreshwaterAquarium)))
            {
                return "Water not suitable.";
            }
            else
            {
                aqua.AddFish(fish);
                return $"Successfully added {fishType} to {aquariumName}.";
            }
        }

        public string CalculateValue(string aquariumName)
        {
            var aqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            decimal value = 0;
            foreach (var item in aqua.Fish)
            {
                value += item.Price;
            }
            foreach (var item in aqua.Decorations)
            {
                value += item.Price;
            }
            return $"The value of Aquarium {aquariumName} is {value:f2}.";
        }

        public string FeedFish(string aquariumName)
        {
            var aqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            aqua.Feed();
            return $"Fish fed: {aqua.Fish.Count}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var aqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            var decor = decoration.FindByType(decorationType);
            if (decor == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }
            else
            {
                aqua.AddDecoration(decor);
                decoration.Remove(decor);
                return $"Successfully added {decorationType} to {aquariumName}.";
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in aquariums)
            {
                sb.AppendLine(item.GetInfo());
                
            }
            return sb.ToString().Trim();
        }
    }
}
