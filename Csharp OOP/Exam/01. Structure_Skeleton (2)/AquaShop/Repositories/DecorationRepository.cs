using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> decoration;
        public DecorationRepository()
        {
            decoration = new List<IDecoration>();
        }
        public IReadOnlyCollection<IDecoration> Models
        {
            get
            {
                return decoration.AsReadOnly();
            }
        }

        public void Add(IDecoration model)
        {
            decoration.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            var model = Models.FirstOrDefault(m => m.GetType().Name == type);
            return model;
        }

        public bool Remove(IDecoration model)
        {
            if (Models.Contains(model))
            {
                decoration.Remove(model);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
