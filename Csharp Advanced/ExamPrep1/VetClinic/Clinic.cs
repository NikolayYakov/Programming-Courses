using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public int Capacity { get; set; }
        public int Count { get { return date.Count; } }
        private List<Pet> date;
        public Clinic(int capacity)
        {
            Capacity = capacity;
            date = new List<Pet>();
        }
        public void Add(Pet pet)
        {
            if (date.Count < Capacity)
            {
                date.Add(pet);
            }
            
        }
        public bool Remove(string name)
        {
            Pet pet = date.FirstOrDefault(p => p.Name == name);
            if (pet == null)
            {
                return false;
            }
            date.Remove(pet);
            return true;
            
        }
        public Pet GetPet(string name,string owner)
        {
            Pet pet = date.FirstOrDefault(p => p.Name == name && p.Owner == owner);
            return pet;
        }
        public Pet GetOldestPet()
        {
            return date.OrderByDescending(p => p.Age).FirstOrDefault();
        }
        public string GetStatistics()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"The clinic has the following patients:");
            foreach (var item in date)
            {

                output.AppendLine($"Pet {item.Name} with owner: {item.Owner}");

            }
            return output.ToString();
        }

    }
}
