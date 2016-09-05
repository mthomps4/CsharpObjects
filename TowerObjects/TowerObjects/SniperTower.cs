using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 4;
        protected override double Power { get; } = 1;

        //If Invader Range < 2 Accurace = 0; 

        protected override double Accuracy { get; } = .50; //65% hit rate 

        public SniperTower(MapLocation location) : base(location)
        { }
    }
}
