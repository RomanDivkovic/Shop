using System;
using System.Collections.Generic;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public interface ICart
    {
        void AddGoods(Goods goods);
        void DeleteGoods(Goods goods);
        void TotalPrice();
        List<Goods> GetMyCart();
    }
}
