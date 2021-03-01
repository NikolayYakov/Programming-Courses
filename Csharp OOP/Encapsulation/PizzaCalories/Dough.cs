using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
   public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private const double baseCaloriesPerGram = 2;
        public Dough(string flourType,string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }
        private string FlourType
        {
            get
            {
                return flourType;
            }
            set
            {
                if (value.ToLower() != "white"&&value.ToLower()!= "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        internal int Calories()
        {
            throw new NotImplementedException();
        }

        private string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
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
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }
        public double Colories()
        {
            double modifier = baseCaloriesPerGram;
            switch (FlourType.ToLower())
            {
                case "white":
                    modifier *= 1.5;
                    break;
                case "wholegrain":
                    modifier *= 1.0;
                    break;
            }
            switch (BakingTechnique.ToLower())
            {
                case "crispy":
                    modifier *= 0.9;
                    break;
                case "chewy":
                    modifier *= 1.1;
                    break;
                case "homemade":
                    modifier *= 1.0;
                    break;
            }
            return Weight * modifier;
        }
    }
}
