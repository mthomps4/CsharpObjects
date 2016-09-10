using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{

    interface IMappable {
        MapLocation Location { get; }
    }

    interface IMovable {
        //Tell invader to move 
        void Move();
    }

    interface IInvader : IMappable, IMovable
    {
        //Invader Health 
        double Health { get;} //Abstract Health set for set classes of Invader

        //True if Invader has reached end of path. 
        bool HasScored { get; }

        //True if Invaders Health = 0 
        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(double factor);
    }
}
