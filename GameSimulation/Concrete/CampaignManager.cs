using GameSimulation.Abstarct;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " named campaign is added to db. \n Discount rate is " + campaign.Discount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " named campaign is deleted \n");
        }

        public void Edit(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " named campaign is edited. \n" + " New discount rate is " + campaign.Discount);
        }
    }
}
