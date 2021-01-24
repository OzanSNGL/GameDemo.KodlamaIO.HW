using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.KodlamaIO.HW.Abstract;
using GameDemo.KodlamaIO.HW.Entities;

namespace GameDemo.KodlamaIO.HW.Concrete
{
    class GameManager : IGameService
    {
        public void AddToCart(Game game)
        {
            Console.WriteLine(game.GameName + " has been added to your cart.");
        }

        public void BuyNow(Game game)
        {
            Console.WriteLine("Buy " + game.GameName + " for only $" + game.GamePrice);
        }

        public void ListAll()
        {
            Console.WriteLine("All games are listed.");
        }

        public void ListOnSale()
        {
            Console.WriteLine("All games on sale are listed.");
        }
    }
}
