using System;
using System.Collections.Generic;
using MyShop.Entities;
using MyShop.Repositories;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Games NBA = new("NBA2k22", 600);
            Games COD = new("Call Of Duty", 500);
            Games GTA = new("Grand Theft Auto", 400);


            Consols XBOX = new("Xbox", 6000);
            Consols PLAY1 = new("Playstation 5", 6000);
            Consols PLAY2 = new("Playstation 4", 3000);
            Consols NINTENDO = new("Super Nintendo", 1000);
            Consols SWITCH = new("Nintendo Switch", 5000);
            Consols GAMEBOY = new("Gameboy Color", 1500);
            Consols PLAY3 = new("Playstation 3", 2000);



            Cart UserCart = new();
            UserCart.AddGoods(NBA);
            UserCart.AddGoods(COD);
            UserCart.AddGoods(GTA);

            UserCart.AddGoods(XBOX);
            UserCart.AddGoods(PLAY1);
            UserCart.AddGoods(PLAY2);

            UserCart.AddGoods(NINTENDO);
            UserCart.AddGoods(SWITCH);
            UserCart.AddGoods(GAMEBOY);

            UserCart.AddGoods(PLAY3);

            UserCart.DeleteGoods(PLAY3);


            Console.WriteLine("* All Goods in Cart *");
            List<Goods> CartList = UserCart.GetMyCart();
            UserCart.TotalPrice();

            Console.WriteLine("* Check for Discount *");

            CheckForDiscount Discount = new();
            Discount.GetDiscount(CartList);
        }
    }
}
