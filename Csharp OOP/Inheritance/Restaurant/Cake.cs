using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
   public class Cake:Dessert
    {
        public Cake(string name)
            :base(name,0,0,0)
        {
            Grams = 250;
            Calories = 1000;
            Price = 5;
        }
    }
}
