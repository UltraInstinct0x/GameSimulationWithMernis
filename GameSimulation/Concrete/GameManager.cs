using GameSimulation.Abstarct;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " named game is added to the db.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " named game is deleted from the db.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " named game is updated on the db.");
        }
    }
}
