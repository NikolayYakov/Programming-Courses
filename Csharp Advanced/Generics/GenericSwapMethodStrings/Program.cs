using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();
            for(int i = 0; i < count; i++)
            {
                string value = Console.ReadLine();
                Box<string> element = new Box<string>(value);
                boxes.Add(element);
            }
            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Swap<Box<string>>(boxes, indexes[0], indexes[1]);
            foreach (var item in boxes)
            {
                Console.WriteLine(item);
            }
        }
        static void Swap<T>(List<T> boxes,int firstIndex,int secondIndex)
        {
            T element = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = element;
        }
    }
}
