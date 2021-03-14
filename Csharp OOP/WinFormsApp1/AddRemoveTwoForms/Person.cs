using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddRemoveTwoForms
{
    public class Person
    {
        
        public string PersonName { get; set; }
        public string PersonNumber { get; set; }
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(PersonName) && !string.IsNullOrEmpty(PersonNumber))
            {
                return $"Person {PersonName} with {PersonNumber}";
            }
            
            return "Invalid Info";
            
        }
    }
}
