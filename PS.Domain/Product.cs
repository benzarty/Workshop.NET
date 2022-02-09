using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
   public class Product
    {

        public int ProductId { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime DateProd { get; set; }

        public string  Description { get; set; }

        public int Quantity { get; set; }

        public Category Category { get; set; }

        public List<Provider> Providers { get; set; }

        public Product()
        {
            //ctro

        }

        public override string ToString()
        {
            return "name : " + Name + " description : "+Description + " date : " +DateProd;
        }

        public void Calculer(int a , int b ,ref int c)
        {
            c = a + b;
            Console.WriteLine(c);
        }

        public virtual void GetMyType()

        {

            Console.WriteLine("je suis un produit");
        }

    }
}
