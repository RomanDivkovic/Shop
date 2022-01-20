using System;
using System.Collections.Generic;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public class Cart : ICart
    {
        public List<Goods> UserCart = new List<Goods>();

        public Cart()
        {
        }

        public void AddGoods(Goods goods)
        {
            UserCart.Add(goods);
        }

        public void DeleteGoods(Goods goods)
        {
            Goods GoodsToDelete = UserCart.Find(item => item == goods);
            UserCart.Remove(GoodsToDelete);
        }

        public List<Goods> GetMyCart()
        {
            return UserCart;
        }

        public void TotalPrice()
        {
            int TotalPrice = 0;
            foreach (Goods item in UserCart)
            {
                Console.WriteLine($"Goods: {item.Title} Price: {item.Price}kr");

                TotalPrice += item.Price;

            }
            Console.WriteLine($"- Total: { TotalPrice}kr -");
        }
    }
}
