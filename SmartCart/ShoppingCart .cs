using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCart
{
    public class ShoppingCart
    {
        public List<Product> items;
        public ShoppingCart()
        {

           items = new List<Product>(); 
        }
       public void Additem(Product product)
        {
           
            items.Add(product);

        }

        public void Removeitem(Product product)
        {
            items.Remove(product);

        }
        public void View()
        {
            int x = items.Count;
            Console.WriteLine(x);

            if (items.Count == 0)
            {
                
                Console.WriteLine("The cart is empty.");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------- Items in Shopping Cart -------");
            foreach (var item in items)
            {

                Console.WriteLine(item.Name);

            }

        }

        public double totalCost()
        {
            double total = 0;
            foreach (var item in items)
            {

                total = total + item.Price;
                Console.WriteLine(total);

            }
            return total;

        }

    }
}
