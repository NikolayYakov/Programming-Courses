using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var item in properties)
            {
                IEnumerable<MyValidationAttribute> customAttribute = item.GetCustomAttributes().Where(x=>x is MyValidationAttribute).Cast<MyValidationAttribute>();
                foreach (var att in customAttribute)
                {
                    bool result = att.IsValid(item.GetValue(obj));
                    if (!result)
                    {
                        return false;
                    }
                    
                }
            }
            return true;

        }
    }
}
