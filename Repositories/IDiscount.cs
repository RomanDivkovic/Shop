using System;
using System.Collections.Generic;
using MyShop.Entities;

namespace MyShop.Repositories
{
    public interface IDiscount
    {

        void Discount(List<Goods> goods);
       
    }
}
