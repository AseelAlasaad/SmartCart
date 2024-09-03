using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCart
{
    public  class ProductGenerator
    {
        private static Random random = new Random();

        public static Product GenerateProduct()
        {
            String[] names= { "banana", "T-shirt", "labtop", "TV" };
            ProductCategory[] categories = { ProductCategory.Food, ProductCategory.Clothing, ProductCategory.Electronics, ProductCategory.Others };
            double price = Math.Round(random.NextDouble()*100,2);
            String name = names[random.Next(names.Length)];

            ProductCategory category = categories[random.Next(categories.Length)];
            return new Product { Name = name, Price = price, Category = category };

        }
    }
}
