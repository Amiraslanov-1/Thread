using System;

namespace Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(2, 40);
            Order order1 = new Order(3, 50);
            Order order2 = new Order(4, 60);
            Order order3 = new Order(5, 71);

            Shop shop= new Shop();
            shop.AddOrder(order);
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);

            Console.WriteLine(shop.GetOrdersAvg());


            foreach (var item in shop.FilterOrderByPrice(20,50))
            {
                Console.WriteLine(item.ProductCount);
            }
            shop.RemoveOrderByNo(null);

            



        }




    }
}
