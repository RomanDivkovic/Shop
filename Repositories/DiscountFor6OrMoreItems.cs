using System;
using System.Collections.Generic;
using System.Linq;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public class DiscountFor6OrMoreItems : IDiscount
    {
        public DiscountFor6OrMoreItems()
        {
        }

        public void Discount(List<Goods> goods)
        {
            int TotalPrice = 0;
            int LastItemPrice = 0;

            goods = goods.OrderByDescending(item => item.Price).ToList();


            foreach (Goods item in goods)
            {

                TotalPrice += item.Price;
                LastItemPrice = item.Price;

            }
            if (goods.Count > 5) TotalPrice -= LastItemPrice;
            Console.WriteLine($"The total price after discount for plus 6 goods: {TotalPrice}kr");
        }
    }
}
