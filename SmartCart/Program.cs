using System;
namespace SmartCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smart Shop!");
            ShoppingCart cart = new ShoppingCart();
            List<Shop> shops = new() { new ClothingStore() };
            int Num;
            do 
            {
                Num = int.Parse(Console.ReadLine());

                if (Num == 1)
                {
                    shops[Num - 1].Display();
                    cart.View();

                    Product selectedProduct = shops[Num - 1].Selectproduct(cart);
                    if (selectedProduct != null)
                    {

                        Console.WriteLine("Item added to cart!");
                    }
                }


                else if (Num == 2)
                {
                    cart.View();

                }
                else if (Num == 3)

                {
                    double totalcost = cart.totalCost();
                    Console.WriteLine($"Total Cost: ${totalcost}");


                }
                else if (Num == 4)
                {
                    cart.View();
                }
                else if (Num == 5)
                {
                    cart.View();
                    Console.WriteLine("Enter item number to remove");
                    int removeChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine(cart.items.Count);
                    if (removeChoice > 0 && removeChoice <= cart.items.Count)
                    {
                        cart.Removeitem(cart.items[removeChoice - 1]);
                        Console.WriteLine("Item removed from cart.");
                    }
                    else
                    {

                        Console.WriteLine("Invalid selection.");
                    }

                }

                else if (Num == 6)
                {
                    Console.WriteLine("Exiting Smart Cart...");
                }



                

            } while (Num != 6);

        }

    }
}
