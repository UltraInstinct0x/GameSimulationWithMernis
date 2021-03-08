using GameSimulation.Abstarct;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class SalesManager : ISaleService
    {
        public void Sell(Gamer gamer, Game game)
        {
            
        }
        public void SellWithDiscount(Gamer gamer,Game game, Campaign campaign)
        {
            int discountedPrice = game.Price-((game.Price * campaign.Discount)/ 100);
            Console.WriteLine(game.Name + " isimli oyun " + gamer.FirstName + " isimli oyuncuya %"
                + campaign.Discount + " oranında indirimle " + discountedPrice + " Türk Lirası'na satıldı.");
        }
    }
}
