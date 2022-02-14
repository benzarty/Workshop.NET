using PS.Domain;
using PS.Services;
using System;
using System.Collections.Generic;

namespace PS.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Name = "Pomme";
            p1.DateProd = new DateTime(2012, 11, 23);
           //   Console.WriteLine(p1.ToString());

           // Console.WriteLine(p1.Name.ToString());

            //intialiseur d'objet : 
            Product p2 = new Product
            {
                //bech direct te5dem bihom w te7ot 9ad ma te7eb fi 3outh ma constructeur yorbetek 

                Name = "fraise",
                Price = 1.5,
                Description = " mal à l'aise",
                DateProd = DateTime.Now


            };



          


            Provider provider = new Provider
            {
                Password = "adcead",
                ConfirmPassword = "adcead",
                UserName="user1",
                Email="user1@gmail.com",
                IsApproved=false
                //get w set yede5mou min 8ir ma te9olehom
            };
            Provider provider2 = new Provider
            {
                Password = "adcead",
                ConfirmPassword = "adcead",
                UserName = "user1",
                Email = "bbbbb@gmail.com",
                IsApproved = false
                //get w set yede5mou min 8ir ma te9olehom
            };


            //  Console.WriteLine(provider.IsApproved);
            //passage par reference
            Provider.SetIsApproved(provider);
           // Console.WriteLine(provider.IsApproved);


            //passage par valeur
             Provider.SetIsApproved(provider.Password, provider.ConfirmPassword, provider.IsApproved);
           // Console.WriteLine(provider.IsApproved);
            //cw tab tab

            //forcer le passage par ref
            int i = 3;
            int j = 2;
            int k = 1;

            // p2.Calculer(i, j,ref k);
            // Console.WriteLine("k : "+k);

            //   Console.WriteLine("la methode login avec 2 params");
            //  Console.WriteLine(provider.Login("user1", "adcead"));   //yemchi ye5dem 3la instance provider kol

            //  Console.WriteLine("la methode login avec 3 params");
            //  Console.WriteLine(provider.Login("user1","adcead","user1@gmail.com"));


            //tester method getmytype
            Product product = new Product();
            Chemical chemical = new Chemical();
            Biological biological = new Biological();

           // product.GetMyType();
           // chemical.GetMyType();
           // biological.GetMyType();

           // provider.Products = new List<Product>() { p1};
            provider.Products.Add(p1);

            provider.Products.Add(p2);
         // provider.getDetails();   //name user1 ??????????????????????????????

        // provider.GetProdcuts("Name", "Pomme");
      //   provider.GetProdcuts("DateProd", "2012/11/23");

          //  Console.WriteLine("DisplayUsernameAndEmail");
           ManageProvider mp = new ManageProvider();
           mp.providers.Add(provider);
            mp.providers.Add(provider2);

          //  mp.DisplayUsernameAndEmail("user1");

            //delegue test
            ManageProduct mprod = new ManageProduct();
            mprod.lsProduct = new List<Product> { p1, p2 };
            foreach(Product prr in mprod.FindProduct('P'))

            {
                Console.WriteLine(prr);

            }
        }
    }
}
