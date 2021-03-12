using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IBorn
    {
        public string BirthDate { get; set; }
        void BirthYear(string year);
    }
}
