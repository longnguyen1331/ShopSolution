using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCategories");

            builder.HasOne(t => t.Product).WithMany(x => x.ProductInCategories)
                            .HasForeignKey(x => x.ProductId);

            builder.HasOne(t => t.Category).WithMany(x => x.ProductInCategories)
                            .HasForeignKey(x => x.CategoryId);
        }
    }
}
