using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphone
    {
        void Call(string number);
        void Brows(string url);
    }
}
