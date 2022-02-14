using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Services
{
    public class ManageProduct //zidou public bech tekoun visible fi kol


    {

        public List<Product> lsProduct { get; set; }

        //ye5ou int yeraja3 list product
        public Func<char,List<Product>> FindProduct;
        public Action<Category> ScanProduct;


        public List<Product> Methode1(char c)
        {
            var req=from p in lsProduct
                     where p.Name.StartsWith(c)
                     select p;
            return req.ToList();
        }
     
        public List<Product> Methode2(char c)
        {
            var req = from p in lsProduct
                      where p.Name.EndsWith(c)
                      select p;
            return req.ToList();
        }
        public ManageProduct()
        {
            FindProduct = Methode1; //5ater 3andou nafes sugnature
            FindProduct = Methode2;
            FindProduct = c =>
            {
                var req = from p in lsProduct
                          where p.Name.StartsWith(c)
                          select p;
                return req.ToList();
            };  //mthode sans nom

            ScanProduct = cat =>
            {
                var req = from p in lsProduct
                          where p.Category.CategoryId == cat.CategoryId
                          select p;
                foreach (Product p in req)
                {
                    Console.WriteLine(p);
                }

            };

          
        }

        public IEnumerable<Chemical> GetChemicals(double price)
        {
            var req = from p in lsProduct.OfType<Chemical>()
                      where p.Price>=price
                      select p;
            var req2 = lsProduct.Where(p => p.Price > price).OfType<Chemical>();
            return req2.Take(5); //bech te5ou 5 preomer
            //ignorer 2 
          //  return req2.Skip(2);
        }

        public double GetAveragePrice()
        {
            return lsProduct.Average(p => p.Price); //ken bil mapda exression héthouma 
        }
        public double GetMaxPrice()
        {
            return lsProduct.Max(p => p.Price); //ken bil mapda exression héthouma 
        }

        public Product GetMaxProductPrice()
        {
            var maxprice = lsProduct.Max(p => p.Price);
            return lsProduct.Where(p => p.Price == maxprice).First();
        }





        public double GetCountProduct(string city)
        {
            var req1 = from p in lsProduct.OfType<Chemical>()
                       where p.City.Equals(city)
                       select p;

            return req1.Count();
        }

        public IEnumerable<Chemical> GetChemicals()
        {
            var req1 = from p in lsProduct.OfType<Chemical>()
                       orderby p.City descending
                       select p;
            return req1;
        }

        public IEnumerable<IGrouping<String,Chemical>> GetChemicalGroupByCity()
        {
            var req1 = from p in lsProduct.OfType<Chemical>()
                       orderby p.City  //ordre mouhem 
                       group p by p.City ;
              foreach(var g in req1)
            {
                Console.WriteLine(g.Key);     //min 3and profa
                foreach (var v in g)
                {
                    Console.WriteLine(v);
                }

            }
            return req1;
        }
    }
}
