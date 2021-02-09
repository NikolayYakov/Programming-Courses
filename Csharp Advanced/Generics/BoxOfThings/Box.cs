using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        
        public Stack<T> elements { get; set; }
        public BoxOfT()
        {
            elements = new Stack<T>();
        }
        public void Add(T element)
        {
            elements.Push(element);
        }
        public T Remove()
        {
            T element = elements.Pop();
            return element;
        }
        public int Count { get { return elements.Count; } }
    }
}
