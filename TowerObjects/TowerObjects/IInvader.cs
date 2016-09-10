using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    interface IInvader
    {
        MapLocation Location { get; }

        //Invader Health 
        double Health { get;} //Abstract Health set for set classes of Invader

        //True if Invader has reached end of path. 
        bool HasScored { get; }

        //True if Invaders Health = 0 
        bool IsNeutralized { get; }

        bool IsActive { get; }

        //Tell invader to move 
        void Move();

        void DecreaseHealth(double factor);
    }
}
