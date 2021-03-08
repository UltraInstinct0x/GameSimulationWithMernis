using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstarct
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Edit(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
