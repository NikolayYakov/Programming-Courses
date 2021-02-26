using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee:HotBeverage
    {
        public Coffee(string name,double caffeine)
            :base(name,0,0)
        {
            Caffeine = caffeine;
            Milliliters = 50;
            Price = 3.50m;
        }
    
        public double Caffeine { get; set; }
    }
}
