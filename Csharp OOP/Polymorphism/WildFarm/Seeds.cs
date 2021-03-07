﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Seeds:Food
    {
        public Seeds(int quantity)
            :base(quantity)
        {

        }
        public override string ToString()
        {
            return "Seeds";
        }
    }
}
