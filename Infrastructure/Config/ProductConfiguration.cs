using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Query;


namespace Infrastructure.Config;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Price).HasColumnType("Decimal(18,2)");

      
    }
}

