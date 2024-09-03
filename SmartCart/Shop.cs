using SmartCart;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace SmartCart
{
    public abstract class Shop
    {
        public abstract void Display();
        public abstract Product Selectproduct(ShoppingCart cart);
    }


    public class ClothingStore : Shop
    {

        public override void Display()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("------- Clothing Store -------");
                Product product = ProductGenerator.GenerateProduct();
                if (product.Category == ProductCategory.Clothing)
                {
                    string[] sizes = { "S", "M", "L", "XL" };
                    Random random = new Random();
                    product.Name = string.Concat(product.Name, " (Size: ", sizes[random.Next(sizes.Length)], ")");
                }

                Console.WriteLine($" {product.Name} - ${product.Price}");
                Console.WriteLine("----------------------------");
            }
        }

        public override Product Selectproduct(ShoppingCart cart)
        {
           
            Console.WriteLine("Enter product number to add to cart");
            int productNum = int.Parse(Console.ReadLine());
            if (productNum > 0 && productNum <= 4)
            {
                Product product = ProductGenerator.GenerateProduct();
                Console.WriteLine($"Selected Product: {product.Name}");
                
                cart.Additem(product);
                return product;
            }
            else
            {
            
                Console.WriteLine("Invalid selection.");

                return null;
            }
        }


    }
   
}



