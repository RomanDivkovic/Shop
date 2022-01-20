using System;
using System.Collections.Generic;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public class Discount3For2 : IDiscount
    {

        public List<Goods> UserCart = new List<Goods>();

        public Discount3For2()
        {
        }

        public void Discount(List<Goods> goods)
        {
            int ProductsPrice = 0;
            int TotalPrice = 0;
            foreach (Goods item in goods)
            {
                if (item.GetType() == typeof(Consols))
                {
                    UserCart.Add(item);

                    TotalPrice += item.Price;
                    ProductsPrice = item.Price;
                }

            }



            while (3 <= UserCart.Count)
            {

                int TotalDiscountPrice = TotalPrice -= ProductsPrice * (UserCart.Count / 3);
                Console.WriteLine($"The total price to pay after 3 for 2 discount is {UserCart.Count} items: {TotalDiscountPrice}kr");

                return;
            }
            Console.WriteLine($"The total price to pay after 3 for 2 discount is {UserCart.Count} item/s: {TotalPrice}kr");
        }
    }
}
