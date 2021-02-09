using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T>
        where T: IComparable<T>
    {
        public T Value { get; set; }
        public Box(T value)
        {
            Value = value;
        }
       
        public int Count(List<Box<T>> boxes, T element)
        {
            int count = 0;
            foreach (var item in boxes)
            {
                
                if (element.CompareTo(item.Value) <  0)
                {
                    count++;
                }

            }
            return count;
        }

    }
}
