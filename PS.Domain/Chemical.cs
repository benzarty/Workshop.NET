using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
  public  class Chemical : Product
    {
        //public Chemical(int productId, string name, double price, DateTime dateProd, string description, int quantity, Category category, List<Provider> providers) : base(productId, name, price, dateProd, description, quantity, category, providers)
        //{

        //}

        public string City { get; set; }
        public string LabName { get; set; }
        public string StreetAdress { get; set; }

        public override void GetMyType()
 //tenajem tena7ihom ovveride wel virtual (polymorphisme)
        {
            base.GetMyType();

            Console.WriteLine(" chemical");
        }
    }
}
//interface c un contrat obligation  //classe abstraite pour appliquer polymorphisme 