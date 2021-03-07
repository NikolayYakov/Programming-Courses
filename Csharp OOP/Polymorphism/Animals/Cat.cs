﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat:Animal
    {
        public Cat(string name,string favouriteFood)
            :base(name,favouriteFood)
        {
            
        }
        public override string ExplainSelf()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"I am {Name} and my fovourite food is {FavouriteFood}");
            builder.AppendLine("MEEOW");
            return builder.ToString().Trim();
        }
    }
}
