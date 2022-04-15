using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Services
{
    public interface IServiceProduct
    {

        void Add(Product P);
        void Remove(Product P);
        IEnumerable<Product> GetAll();
        void Commit();
    }
}
