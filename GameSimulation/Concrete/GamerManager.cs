using GameSimulation.Abstarct;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer))
            {
                Console.WriteLine("New Gamer " + gamer.FirstName + " Added To Db.");
            }
            else
            {
                throw new Exception("Gerçek bir kişi değil.");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Gamer Removed From Db.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Info Updated.");
        }
    }
}
