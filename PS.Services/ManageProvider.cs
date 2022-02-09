using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Services
{
    public class ManageProvider
    {


        public List<Provider> providers { get; set; } = new List<Provider>();
       public List<Provider> GetProviderByName(string name)
        {//bech ne5demou bil link
            List<Provider> req= (from p in providers
                                where p.UserName.Contains(name)
                                select p).ToList();
            return req;
        }


        public List<String> GetProviderEmailByName(string name)
        {//bech ne5demou bil link
            List<String> req = (from p in providers
                                  where p.UserName.Contains(name)
                                  select p.UserName).ToList();
            return req;
        }

        public void DisplayUsernameAndEmail(String name)
        {
            var req = (from p in providers
                                where p.UserName.Contains(name)
                                select (p.UserName,p.Email)).ToList();
            foreach(var p in req)
                Console.WriteLine(p);

        }
    }
}
