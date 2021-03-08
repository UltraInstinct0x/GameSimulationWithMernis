using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstarct
{
    public interface ISaleService
    {
        void Sell(Gamer gamer, Game game);
        void SellWithDiscount(Gamer gamer, Game game, Campaign campaign);
    }
}
