﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
        public Engine(string model,int power)
        {
            Model = model;
            Power = power;
            Displacement = -1;
            Efficiency = string.Empty;
        }
        public Engine(string model,int power,int displacement)
            :this(model,power)
        {
            Displacement = displacement;
        }
        public Engine(string model,int power,string efficiency)
            :this(model,power)
        {
            Efficiency = efficiency;
        }
        public Engine(string model,int power,int displacement,string efficiency)
            :this(model,power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}
