﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopSolution.Data.Entities;
using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Extentions
{
    public static class ModelBuiderExtention
    {
        //https://www.learnentityframeworkcore.com/migrations/seeding

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage ShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is key word ShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description ShopSolution" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Code="vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = 2, Code = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                });


            modelBuilder.Entity<CategoryTranslation>().HasData(
                 new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = 1, SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                 new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = 2, SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                 new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = 1, SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang women" },
                 new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = 2, SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                   );

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0
               });

            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Áo sơ mi nam trắng Việt Tiến",
                     LanguageId = 1,
                     SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                     SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                     SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                     Details = "Áo sơ mi nam trắng Việt Tiến",
                     Description = "Áo sơ mi nam trắng Việt Tiến"
                 },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Tien Men T-Shirt",
                    LanguageId = 2,
                    SeoAlias = "viet-tien-men-t-shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    Details = "Viet Tien Men T-Shirt",
                    Description = "Viet Tien Men T-Shirt"
                });

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );


            var ADMIN_ID = new Guid("6B502DD8-71DE-41D5-9F8D-BD0924527C4E");
            var ROLE_ID = new Guid("2AC8608B-747C-4A92-9372-A7AB59720611");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = new Guid("2AC8608B-747C-4A92-9372-A7AB59720611"),
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            }) ;

            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = new Guid("6B502DD8-71DE-41D5-9F8D-BD0924527C4E"),
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "longnguyen13th1d.pou@gmail.com",
                NormalizedEmail = "longnguyen13th1d.pou@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admin18"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyễn",
                LastName = "Long",
                DateOfBirth = new DateTime(1995, 09, 10)
            }) ;

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
