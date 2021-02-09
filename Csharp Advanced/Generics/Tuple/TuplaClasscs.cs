using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class TuplaClasscs<T1,T2>
    {
        public T1 FirstItem { get; set; }
        public T2 SecondItem { get; set; }
        public TuplaClasscs(T1 first,T2 second)
        {
            FirstItem = first;
            SecondItem = second;
        }
        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem}";
        }
    }
}
