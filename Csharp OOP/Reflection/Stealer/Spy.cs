using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className,params string[] fields )
        {
            Type type = Type.GetType(className) ;
            FieldInfo[] fieldsInfon = type.GetFields(BindingFlags.Public|
                                                     BindingFlags.NonPublic|
                                                     BindingFlags.Instance|
                                                     BindingFlags.Static);
            StringBuilder sb = new StringBuilder();
            Object classInstance = Activator.CreateInstance(type, new object[] { });
            sb.AppendLine($"Class under investigation: {type.FullName}");
            
            foreach (var item in fieldsInfon)
            {
                if (fields.Contains(item.Name))
                {

                    sb.AppendLine($"{item.Name} = {item.GetValue(classInstance)}");
                }
            }
            return sb.ToString().Trim();
        }
    }
}
