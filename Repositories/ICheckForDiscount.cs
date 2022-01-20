using System;
using System.Collections.Generic;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public interface ICheckForDiscount
    {
        void GetDiscount(List<Goods> CartList);
    }
}
