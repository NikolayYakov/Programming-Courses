using EasterRaces.Models.Races.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository:Repository<IRace>
    {
        public override IRace GetByName(string name)
        {
            var race = Models.FirstOrDefault(r => r.Name == name);
            return race;
        }
    }
}
