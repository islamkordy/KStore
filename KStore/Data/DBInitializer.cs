using KStore.Data;
using KStore.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KStore.Models
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();

            try
            {
                if (!context.ProductBrands.Any())
                {
                    var productBrands = new ProductBrand[]
                       {
                        new ProductBrand{Name="Alexander",CreatedAt=DateTime.Now},
                        new  ProductBrand{Name="Justice",CreatedAt=DateTime.Now},
                        new  ProductBrand{Name="Norman",CreatedAt=DateTime.Now},
                        new  ProductBrand{Name="Olivetto",CreatedAt=DateTime.Now}
                       };
                    foreach (var q in productBrands)
                    {
                        context.ProductBrands.Add(q);
                    }
                }
                if (!context.ProductTypes.Any())
                {
                    var productTypes = new ProductType[]
                       {
                        new ProductType{Name="Alexander",CreatedAt=DateTime.Now},
                        new  ProductType{Name="Justice",CreatedAt=DateTime.Now},
                        new  ProductType{Name="Norman",CreatedAt=DateTime.Now},
                        new  ProductType{Name="Olivetto",CreatedAt=DateTime.Now}
                       };
                    foreach (var q in productTypes)
                    {
                        context.ProductTypes.Add(q);
                    }
                }
                if (!context.Products.Any())
                {
                    var products = new Product[]
                       {
                        new Product{Name="Product 1", Description="desc", Price=150.00M , ProductBrandId=1, ProductTypeId=1, CreatedAt=DateTime.Now},
                        new  Product{Name="Product 2", Description="desc" , Price=350.00M, ProductBrandId=1,ProductTypeId=1,CreatedAt=DateTime.Now},
                        new  Product{Name="Product 3", Description="desc" ,Price=100.00M, ProductBrandId=2,ProductTypeId=2,CreatedAt=DateTime.Now},
                        new  Product{Name="Product 4", Description="desc" ,Price=250.00M , ProductBrandId=2,ProductTypeId=2,CreatedAt=DateTime.Now}
                       };
                    foreach (var p in products)
                    {
                        context.Products.Add(p);
                    }
                }
            }
            catch(Exception ex)
            {
                //logger.LogError(ex, "An error occurred while seeding the database.");
            }
           
            context.SaveChanges();
        }
    }
}
