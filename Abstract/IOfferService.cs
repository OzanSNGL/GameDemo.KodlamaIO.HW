using GameDemo.KodlamaIO.HW.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.KodlamaIO.HW.Abstract
{
    interface IOfferService
    {
        void ShowOffers(List<Offer> allOffers);
        void CalculateOffer(Game game);
    }
}
