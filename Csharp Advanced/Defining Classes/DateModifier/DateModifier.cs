using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class DateModifier
    {
        public int Difference { get; set; }
        public int Calculator(string firstYear,string secondYear)
        {
            int[] firstDate = firstYear.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime first = new DateTime(firstDate[0], firstDate[1], firstDate[2]);
            int[] secondDate = secondYear.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime second = new DateTime(secondDate[0], secondDate[1], secondDate[2]);
            int days = Math.Abs((first - second).Days);
            return days;

        }
    }
}
