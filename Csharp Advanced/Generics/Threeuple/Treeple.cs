using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    class Treeple<T1,T2,T3>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
        public T3 Third { get; set; }
        public Treeple(T1 firts,T2 second,T3 third)
        {
            First = firts;
            Second = second;
            Third = third;
        }
        public override string ToString()
        {
            return $"{First} -> {Second} -> {Third}";
        }
    }
}
