using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page solution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is Keyword page solution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is Description page solution" });

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active

                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active

                }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },

                new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }

                );

            modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = 1,
                DateCreated = DateTime.Now,
                OriginalPrice = 100000,
                Price = 200000,
                Stock = 0,
                ViewCount = 0,

            }
            );

            modelBuilder.Entity<ProductTranslation>().HasData(

                new ProductTranslation() { Id = 1, ProductId = 1, Name = "Áo sơ mi nam trắng Việt Tiến", LanguageId = "vi-VN", SeoAlias = "ao-so-mi-nam-trang-viet-tien", SeoDescription = "Áo sơ mi nam trắng Việt Tiến", SeoTitle = "Áo sơ mi nam trắng Việt Tiến", Details = "Áo sơ mi nam trắng Việt Tiến", Description = "Áo sơ mi nam trắng Việt Tiến" },
                    new ProductTranslation() { Id = 2, ProductId = 1, Name = "Viet Tien Men T-shirt", LanguageId = "en-US", SeoAlias = "viet-tien-men-t-shirt", SeoDescription = "Viet Tien Men T-shirt", SeoTitle = "Viet Tien Men T-shirt", Details = "Viet Tien Men T-shirt", Description = "Viet Tien Men T-shirt" }
                );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1}
                );

            var roleID = new Guid("872E6D3B-071B-44AE-A907-A336AFB19AAC");
            var adminID = new Guid("4E2DF197-539C-469F-89BA-29003F984868");
            // any guid, but nothing is against to use the same one
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "hoangit94bg@gmail.com",
                NormalizedEmail = "hoangit94bg@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd123$%"),
                SecurityStamp = string.Empty,
                FirstName = "Ngo",
                LastName = "Hoang",
                Dob = new DateTime(1994, 03, 07)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleID,
                UserId = adminID
            });
        }
    }
}
