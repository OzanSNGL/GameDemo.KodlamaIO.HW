using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.KodlamaIO.HW.Entities;
using GameDemo.KodlamaIO.HW.Concrete;

namespace GameDemo.KodlamaIO.HW.Abstract
{
   public interface IGameService
    {
        void AddToCart(Game game);
        void BuyNow(Game game);
        void ListAll(List<Game> lstGames);
        void ListOnSale(List<Game> lstGames);
    }
}
