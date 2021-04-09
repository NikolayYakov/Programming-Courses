using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public abstract class Repository<T> : IRepository<T>
    {
        private List<T> models;
        public Repository()
        {
            this.models = new List<T>();
        }
        protected IReadOnlyCollection<T> Models
        {
            get
            {
                return models.AsReadOnly();
            }
        }
        public void Add(T model)
        {
            this.models.Add(model);
        }
        
        public IReadOnlyCollection<T> GetAll()
        {
            return Models;
        }

        public abstract T GetByName(string name);
         

        public bool Remove(T model)
        {
            if (this.models.Contains(model))
            {
               this.models.Remove(model);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
