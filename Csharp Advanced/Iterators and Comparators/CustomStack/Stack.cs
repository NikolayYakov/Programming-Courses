using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    class Stack<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int index;
        public Stack()
        {
            elements = new List<T>();
            index = -1;
        }
        public void Push(params T[] elements)
        {
            foreach (var item in elements)
            {
                index++;
                this.elements.Insert(index, item);
            }
        }
        public void Pop()
        {
            if (elements.Count > 0)
            {
                elements.RemoveAt(index);
                index--;
            }
            else
            {
                throw new InvalidOperationException("No elements");
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
             for(int i = index; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
