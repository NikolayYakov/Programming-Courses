using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();
            for (int i = 0; i < count; i++)
            {
                string value = Console.ReadLine();
                Box<string> element = new Box<string>(value);
                boxes.Add(element);
            }
            Box<string> zeroElement = new Box<string>("");
            string max = Console.ReadLine();
            int result= zeroElement.Count(boxes, max);
            Console.WriteLine(result);

        }
 
    }
}
