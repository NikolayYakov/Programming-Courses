using EasterRaces.Models.Drivers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository:Repository<IDriver>
    {
        public override IDriver GetByName(string name)
        {
            var driver = Models.FirstOrDefault(r => r.Name == name);
            return driver;
        }
    }
}
