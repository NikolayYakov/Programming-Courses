using System;
using System.Collections.Generic;
using System.Text;

namespace Listyiterator
{
    class ListyIterator<T>
    {
        public List<T> Elements { get; set; }
        public int Index { get; set; }
        public ListyIterator(params T[] elements)
        {
            Elements = new List<T>(elements);
            Index = 0;
        }
        public bool Move()
        {
            if (Index < Elements.Count - 1)
            {
                Index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if(Index == Elements.Count - 1)
            {
                return false;
            }
            return true;
        }
        public void Print()
        {
            if (Elements.Count > 0)
            {
                Console.WriteLine(Elements[Index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

    }
}
