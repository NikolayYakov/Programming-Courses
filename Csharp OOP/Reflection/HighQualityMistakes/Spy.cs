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
        public string AnalyzeAccessModifiers(string className)
        {
            Type type = Type.GetType(className);
            FieldInfo[] fiildInfo = type.GetFields(BindingFlags.Public|BindingFlags.Static|BindingFlags.Instance);
            MethodInfo[] methodInfoPublic = type.GetMethods(BindingFlags.NonPublic|BindingFlags.Instance);
            MethodInfo[] methodInfoPrivet = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (var item in fiildInfo)
            {
                sb.AppendLine($"{item.Name} must be private!");
            }
            foreach (var item in methodInfoPublic.Where(m=>m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} have to be private!");
            }
            foreach (var item in methodInfoPrivet.Where(m => m.Name.StartsWith("get"))) 
            {
                sb.AppendLine($"{item.Name} to be public!");
            }
            return sb.ToString().Trim();
        }
    }
}
