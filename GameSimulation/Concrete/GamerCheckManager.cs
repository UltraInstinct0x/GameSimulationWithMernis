using GameSimulation.Abstarct;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
