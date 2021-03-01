using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private const double caloriesPerGram = 2;
        private int weight;
        public Topping(string type,int weight)
        {
            Type = type;
            Weight = weight;
        }
        private string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "sauce" && value.ToLower() != "cheese")
                {
                    throw new ArgumentException(string.Format("Cannot place {0} on top of your pizza.", value));
                }
                this.type = value;
            }
        }
        private int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(String.Format("{0} weight should be in the range [1..50].", this.Type));
                }
                this.weight = value;
            }
        }
        public double Calories()
        {
            double modifier = caloriesPerGram;
            switch (this.Type.ToLower())
            {
                case "meat": modifier *= 1.2; break;
                case "veggies": modifier *= 0.8; break;
                case "cheese": modifier *= 1.1; break;
                case "sauce": modifier *= 0.9; break;
            }
            return modifier * weight;
        }
    }
}
