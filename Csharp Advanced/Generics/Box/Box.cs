using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
     
    public class Box<T>
    {
        public int Count { get { return box.Count; } }
        Stack<T> box;
        public Box()
        {
            box = new Stack<T>();
        }
        public void Add(T element)
        {
            box.Push(element);
        }
        public T Remove()
        {
           T element =  box.Pop();
            return element;
        }

    }
}
