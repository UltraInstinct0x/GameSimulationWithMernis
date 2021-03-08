using GameSimulation.Abstarct;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public string Name { get; set; }

    }
}
