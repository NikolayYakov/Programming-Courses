using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Robot
    {
        public Robot(string model,string id)
        {
            Model = model;
            Id = id;
        }
        public string Id { get; set; }
        public string Model { get; set; }
         
    }
}
