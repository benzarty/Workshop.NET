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

            //intialiseur d'objet : 
            Product p2 = new Product
            {
                //bech direct te5dem bihom w te7ot 9ad ma te7eb fi 3outh ma constructeur yorbetek 

                Name = "fraise",
                Price = 1.5
                

            };
            

            Provider provider = new Provider
            {
                Password = "adcead",
                ConfirmPassword = "adcead",
                UserName="user1",
                Email="user1@gmail.com"
                //get w set yede5mou min 8ir ma te9olehom
            };

          // Console.WriteLine(provider.IsApproved);
            //passage par reference
          //  Provider.SetIsApproved(provider);
            //passage par valeur
          //  Provider.SetIsApproved(provider.Password, provider.ConfirmPassword, provider.IsApproved);
          //  Console.WriteLine(provider.IsApproved);
            //cw tab tab

            //forcer le passage par ref
            int i = 3;
            int j = 2;
            int k = 1;

            // p2.Calculer(i, j,ref k);
            // Console.WriteLine("k : "+k);

            //   Console.WriteLine("la methode login avec 2 params");
            //  Console.WriteLine(provider.Login("user1", "adcead"));

            //  Console.WriteLine("la methode login avec 3 params");
            //  Console.WriteLine(provider.Login("user1","adcead","user1@gmail.com"));


            //tester method getmytype
            Product product = new Product();
            Chemical chemical = new Chemical();
            Biological biological = new Biological();

            product.GetMyType();
            chemical.GetMyType();
            biological.GetMyType();

           // provider.Products = new List<Product>() { p1};
            provider.Products.Add(p1);

            provider.Products.Add(p2);
            provider.getDetails();

           provider.GetProdcuts("Name", "Pomme");
            provider.GetProdcuts("DateProd", "2021/11/23");

            Console.WriteLine("DisplayUsernameAndEmail");
            ManageProvider mp = new ManageProvider();
            mp.providers.Add(provider);
            mp.DisplayUsernameAndEmail("user1");

        }
    }
}
