using System;
namespace MyShop.Entities
{
    public class Consols : Goods
    {
        public Consols(string title, int price) : base(title, price)
        {
        }

        public Consols(string title, int price, int id) : base(title, price, id)
        {
        }
    }
}
