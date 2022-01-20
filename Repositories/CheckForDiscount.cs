using System;
using System.Collections.Generic;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public class CheckForDiscount : ICheckForDiscount
    {
        public CheckForDiscount()
        {
        }

        public void GetDiscount(List<Goods> CartList)
        {
            Discount3For2 discount3For2 = new();
            DiscountFor10Procent discountTenProcent = new();
            DiscountFor6OrMoreItems discountForMoreThen6Items = new();

            discount3For2.Discount(CartList);
            discountTenProcent.Discount(CartList);
            discountForMoreThen6Items.Discount(CartList);
        }
    }
}
