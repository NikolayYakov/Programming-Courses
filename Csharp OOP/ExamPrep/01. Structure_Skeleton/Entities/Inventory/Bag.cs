using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private List<Item> Collection;
        public Bag(int capacity)
        {
            Capacity = capacity;
            Collection = new List<Item>();
        }
        public int Capacity { get; set; } = 100;

        public int Load
        {
            get
            {
                int weight = 0;
                foreach (var item in Items)
                {
                    weight += item.Weight;
                }
                return weight;
            }
        }

        public IReadOnlyCollection<Item> Items
        {
            get
            {
                return Collection.AsReadOnly();
            }
        }
             

        public void AddItem(Item item)
        {
            if (Load + item.Weight > Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }
            Collection.Add(item);
        }

        public Item GetItem(string name)
        {
            if (Items.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }
            Item item = Items.FirstOrDefault(i => i.GetType().Name == name);
            if (item == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }
            Collection.Remove(item);
            return item;
            
        }
    }
}
