using PS.data;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Services
{
    public class ServiceProduct : IServiceProduct
    {

        PSContext ctx = new PSContext();
        public void Add(Product P)
        {
            ctx.Products.Add(P);
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
return ctx.Products;
                }

        public void Remove(Product P)
        {
            ctx.Products.Remove(P);
        }
    }
}
