using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar 
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public Seat(string modle,string color)
        {
            Model = modle;
            Color = color;
        }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}
