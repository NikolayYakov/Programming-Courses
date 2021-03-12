using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public Robot(string model,string id)
        {
            Model = model;
            Id = id;
        }
        public string Id { get; set; }
        public string Model { get; set; }
        public void Fake(string fakeDigit)
        {
            string last = Id.Substring(Id.Length - fakeDigit.Length);

            if (last == fakeDigit)
            {
                Console.WriteLine(Id);
            }
        }
    }
}
