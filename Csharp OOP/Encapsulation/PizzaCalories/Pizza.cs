using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza(string name,Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if ((value.Length < 1 || value.Length > 15)||string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public Dough Dough
        {
            private get
            {
                return this.dough;
            }

            set
            {
                this.dough = value;
            }
        }
        public int GetNumberOfToppins()
        {
            return toppings.Count;
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
        public double Callories()
        {
            double callories = 0;
            callories += dough.Colories();
            foreach (Topping topping in this.toppings)
            {
                callories += topping.Calories();
            }
            return callories;
        }
    }
}
