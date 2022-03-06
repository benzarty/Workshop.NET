using Microsoft.EntityFrameworkCore;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.data
{
    public class PSContext:DbContext
        //id wala nomclassesuivi id : bech ye5ouha id meta3 classe héthika
    {
        public DbSet<Product> Products { get; set; } //esm table le meme nom ama lezem tezid s fil le5er (regle)

        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }

        //dbset : type bech gedou biha crud ...

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ProductStoreDB;Integrated Security=true;MultipleActiveResultSets=true");  //usemysql  //ProductStoreDB esm base //par
            base.OnConfiguring(optionsBuilder);
        }  

             //Integrated Security : manich bech 7ot passwod w login
        //usesqlserver ,....
        //OnConfiguring bech configuri base biha 

        //migration : va faire une comparaison entre code wel bd bech generi un code ki va upgrade notre base
        
        //fil .net dima bidirectionnel

        //Microsoft.EntityFrameworkCore.Tools  data 
        //Microsoft.EntityFrameworkCore.desgin 3la gui

        //Add-migration   te7athereha 
        //Update-Database   tegedeha
        //wera be3athehom dima

    }
}
        