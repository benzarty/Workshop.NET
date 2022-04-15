using PS.data;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Services
{
    public class ServiceCategory : IServiceCategorycs
    {
        PSContext ctx = new PSContext();

        public void Add(Category P)
        {
            ctx.Categories.Add(P);
        }

        public IEnumerable<Category> GetAll()
        {
            return ctx.Categories;
        }

        public void Remove(Category P)
        {
            ctx.Categories.Remove(P);
        }
    }
}
