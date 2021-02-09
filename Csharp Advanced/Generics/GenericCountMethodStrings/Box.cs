using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T>
        where T: IComparable
    {
        public T Value { get; set; }
        public Box(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }
        public int Count(List<Box<T>> boxes, T element)
        {
            int count = 0;
            foreach (var item in boxes)
            {
                string test = item.ToString();
                if (element.CompareTo(test) < 0)
                {
                    count++;
                }

            }
            return count;
        }

    }
}
