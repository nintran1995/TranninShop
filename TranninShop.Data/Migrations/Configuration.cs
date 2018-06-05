namespace TranninShop.Data.Migrations
{
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;
	using Model.Models;
	using System;
	using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TranninShop.Data.TranninShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TranninShop.Data.TranninShopDbContext context)
        {
            CreateProductCategorySample(context);
			var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TranninShopDbContext()));

			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TranninShopDbContext()));

			var user = new ApplicationUser()
			{
				UserName = "nintran",
				Email = "nintran1995@gmail.com",
				EmailConfirmed = true,
				BirthDay = DateTime.Now,
				FullName = "Trannin Shop"
			};

			manager.Create(user, "123654$");

			if (!roleManager.Roles.Any())
			{
				roleManager.Create(new IdentityRole { Name = "Admin" });
				roleManager.Create(new IdentityRole { Name = "User" });
			}

			var adminUser = manager.FindByEmail("nintran1995@gmail.com");

			manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
		}

        private void CreateProductCategorySample(TranninShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> productCategorys = new List<ProductCategory>()
            {
                new ProductCategory() { Name = "Giày", Alias = "giay", Status = true},
                new ProductCategory() { Name = "Mũ bảo hiểm", Alias = "mu-bao-hiem", Status = true},
                new ProductCategory() { Name = "Quần Jean", Alias = "quan-jean", Status = true},
                new ProductCategory() { Name = "Áo", Alias = "ao", Status = true},
                new ProductCategory() { Name = "Mũ", Alias = "mu", Status = true},
                new ProductCategory() { Name = "Dép", Alias = "dep", Status = true}
            };
                context.ProductCategories.AddRange(productCategorys);
                context.SaveChanges();
            }
        }
    }
}