﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.data.MyConfiguration
{
    //fluent api
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //bech badelou biha esm table association 
            builder.HasMany(p => p.Providers).WithMany(p => p.Products).UsingEntity(p=>p.ToTable("Providing"));  //tenajem min ay sens tegedeha //table association
            //configuring 0*many relation
            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryFK).OnDelete(DeleteBehavior.Cascade);
            //configuring 1*many relation

            //  builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryFK).IsRequired().OnDelete(DeleteBehavior.Cascade);
            //configuring inhirence table per hierchy 

            //inihirence table per hierchy 
           // builder.HasDiscriminator<int>("isBiological").HasValue<Product>(0).HasValue<Chemical>(2).HasValue<Biological>(1);

           

        }
    }
}
//is required 1-1 relation fil catefory product