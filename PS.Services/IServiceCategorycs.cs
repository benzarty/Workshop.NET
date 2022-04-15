using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Services
{
   public interface IServiceCategorycs
    {
        void Add(Category P);
        void Remove(Category P);
        IEnumerable<Category> GetAll();
    }
}
