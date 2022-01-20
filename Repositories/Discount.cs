using System;
using System.Collections.Generic;
using System.Linq;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public class Discount 
    {
        public Discount()
        {
        }

        public void DiscountTenProcent(List<Goods> goods)
        {
            int MyTotPrice = 0;
            foreach (var item in goods)
            {
                MyTotPrice += item.Price;
            }
            if (MyTotPrice > 500)
            {

                MyTotPrice = MyTotPrice - (MyTotPrice / 10);
                Console.WriteLine($"The total price after a 10% discount: {MyTotPrice}kr");

            }

        }

        public void Discount3for2(List<Goods> goods)
        {
            int TotalGoods = 0;
            int MyTotPrice = 0;
            foreach (var item in goods)
            {
                TotalGoods++;

                if (TotalGoods == 3)
                {
                    Console.WriteLine($"The total price after 3 for 2 discount: {MyTotPrice}kr");
                    return;
                }
                MyTotPrice += item.Price;

            }


        }

        public void Discount6OrMoreItems(List<Goods> goods)
        {
            int TotalGoods = 0;
            int MyTotPrice = 0;
            int TheLastItemPrice = 0;

            goods = goods.OrderByDescending(item => item.Price).ToList();


            foreach (var item in goods)
            {

                TotalGoods++;
                MyTotPrice += item.Price;
                TheLastItemPrice = item.Price;
            }
            if (TotalGoods > 5) MyTotPrice = MyTotPrice - TheLastItemPrice;
            Console.WriteLine($"The total price to pay after plus 6 goods: {MyTotPrice}kr");

        }
    }
}
