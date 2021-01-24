using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.KodlamaIO.HW.Abstract;
using GameDemo.KodlamaIO.HW.Entities;
using GameDemo.KodlamaIO.HW;

namespace GameDemo.KodlamaIO.HW.Concrete
{
    public class GameManager : IGameService
    {
        public void AddToCart(Game game)
        {
            Console.WriteLine(game.GameName + " has been added to your cart.");
        }

        public void BuyNow(Game game)
        {
            Console.WriteLine("Buy " + game.GameName + " for only $" + game.GamePrice + "\r\n");
        }

        public void ListAll(List<Game> lstGames)
        {
            foreach (var item in lstGames)
            {
                Console.WriteLine("Game ID: " + item.GameID + " / " + item.GameName + " - " + "$" + item.GamePrice + " / " + item.GameStock + " are in stock.");
            }
        }

        public void ListOnSale(List<Game> lstGames)
        {
            for (int i = 0; i < lstGames.Count; i++)
            {
                if (lstGames[i].IsOnSale == true)
                {
                    Console.WriteLine("Game ID: " + lstGames[i].GameID + " / " + lstGames[i].GameName + " - " + "$" + lstGames[i].GamePrice + " / " + lstGames[i].GameStock + " are in stock.");
                }
            }
        }
    }
}
