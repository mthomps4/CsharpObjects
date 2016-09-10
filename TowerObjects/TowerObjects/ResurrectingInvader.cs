using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class ResurrectingInvader : IInvader
    {
        private ShieldedInvader _incarnation1;
        private StrongInvader _incarnation2;

        public ResurrectingInvader(Path path)
        {
            _incarnation1 = new ShieldedInvader(path);
            _incarnation2 = new StrongInvader(path);
        }

        public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;

        //Invader Health 
        public double Health => _incarnation1.IsNeutralized ? _incarnation2.Health : _incarnation1.Health;

        //True if Invader has reached end of path. 
        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;

        //True if Invaders Health = 0 
        public bool IsNeutralized => _incarnation1.IsNeutralized && _incarnation2.IsNeutralized;

        public bool IsActive => !(IsNeutralized || HasScored);

        public void Move() {
            _incarnation1.Move();
            _incarnation2.Move(); //pickup where 1 left off. 
        }

        public void DecreaseHealth(double factor)
        {
            if (!_incarnation1.IsNeutralized)
            {
                _incarnation1.DecreaseHealth(factor);
            }
            else {
                _incarnation2.DecreaseHealth(factor);
            }
        }

    }
}
