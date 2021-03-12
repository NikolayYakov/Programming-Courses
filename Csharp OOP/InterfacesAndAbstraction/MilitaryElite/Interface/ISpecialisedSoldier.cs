using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
   public interface ISpecialisedSoldier:IPrivate
    {

        string Corps { get; }
    }
}
