using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x => new { x.CategoryId, x.ProductId });
            builder.HasOne(p => p.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(p => p.ProductId);
            builder.HasOne(c => c.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(c => c.CategoryId);
        }
    }
}
