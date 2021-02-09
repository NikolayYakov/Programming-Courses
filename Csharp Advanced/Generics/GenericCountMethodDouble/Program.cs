using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();
            for (int i = 0; i < count; i++)
            {
                double value = double.Parse(Console.ReadLine());
                Box<double> element = new Box<double>(value);
                boxes.Add(element);
            }
            Box<double> zeroElement = new Box<double>(0);
            double max = double.Parse(Console.ReadLine());
            int result = zeroElement.Count(boxes, max);
            Console.WriteLine(result);
        }
    }
}
