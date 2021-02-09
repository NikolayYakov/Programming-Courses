using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    class Program
    {
        static void Main(string[] args)
        {
                int count = int.Parse(Console.ReadLine());
                List<Box<int>> boxes = new List<Box<int>>();
                for (int i = 0; i < count; i++)
                {
                    int value = int.Parse(Console.ReadLine());
                    Box<int> element = new Box<int>(value);
                    boxes.Add(element);
                }
                int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Swap(boxes, indexes[0], indexes[1]);
                foreach (var item in boxes)
                {
                    Console.WriteLine(item);
                }
        }
        static void Swap<T>(List<T> boxes, int firstIndex, int secondIndex)
        {
            T element = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = element;
        }
    }

}
