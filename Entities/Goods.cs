using System;
namespace MyShop.Entities
{
    public class Goods
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public Goods(string title, int price, int id)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public Goods(string title, int price)
        {
            Title = title;
            Price = price;
        }
    }
}
