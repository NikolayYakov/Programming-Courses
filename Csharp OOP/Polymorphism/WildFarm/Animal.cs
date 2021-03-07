using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        public Animal(string name,double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }
        public string Name { get;protected set; }
        public double Weight { get; set; }
        public int FoodEaten { get;protected set; }
        public abstract void Eat(Food food);
    }
}
