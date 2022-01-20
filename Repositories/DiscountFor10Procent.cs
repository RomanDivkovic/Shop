using System;
using System.Collections.Generic;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public class DiscountFor10Procent : IDiscount 
    {
        public DiscountFor10Procent()
        {
        }

        public void Discount(List<Goods> goods)
        {
            int TotalPrice = 0;
            foreach (Goods item in goods)
            {
                TotalPrice += item.Price;
            }
            if (TotalPrice > 500)
            {

                TotalPrice -= TotalPrice / 10;
                Console.WriteLine($"The total price with 10% discount: {TotalPrice}kr");

            }
        }
    }
}
