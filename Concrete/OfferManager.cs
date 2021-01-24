using GameDemo.KodlamaIO.HW.Abstract;
using GameDemo.KodlamaIO.HW.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.KodlamaIO.HW.Concrete
{
    class OfferManager : GameManager, IOfferService
    {
        public void ShowOffers(List<Offer> allOffers)
        {
            foreach (var item in allOffers)
            {
                Console.WriteLine("SPECIAL OFFER! \r\n" + item.GameName + " IS NOW " + item.Discount + "% OFF UNTIL " + item.OfferEnds);
            }
        }
        public void CalculateOffer(Game game)
        {
            game.GamePrice -= game.GamePrice * (0.50);
            Console.WriteLine("Buy for only $" + game.GamePrice);
        }
    }
}
