using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int min;
        private int top;
        public MyRangeAttribute(int minValue,int topValue)
        {
            min = minValue;
            top = topValue;
        }
        public override bool IsValid(object obj)
        {
            if(!(obj is int))
            {
                throw new Exception("");
            }
            int valueAsInt = (int)obj;
            if (valueAsInt >= min && valueAsInt <= top)
            {
                return true;
            }
            return false;
        }
    }
}
