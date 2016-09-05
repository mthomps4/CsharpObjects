using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class PowerTower : Tower
    {
        protected override double Power { get; } = 3;

        public PowerTower(MapLocation location) : base(location)
        { }
    }
}
