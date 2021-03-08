using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstarct
{
    public interface IGamerCheckService
    {
        bool Validate(Gamer gamer);
    }
}
