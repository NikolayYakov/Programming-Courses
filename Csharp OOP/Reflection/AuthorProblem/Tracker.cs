using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var type = typeof(StartUp);
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance| BindingFlags.Static);
            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute)))
                {

                    var att = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute atr in att )
                    {
                        Console.WriteLine($"{method.Name} is written by {atr.Name}");
                    }
                    
                }
            }
        }
    }
}
