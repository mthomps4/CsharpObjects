using System;


namespace TowerDefense
{
    class StrongInvader : Invader
    {
        public override double Health { get; protected set; } = 5;

        public StrongInvader(Path path) :base(path)
        {
            Console.WriteLine("That Guy is HUUUGE!");
        }


        public override void DecreaseHealth(double factor) 
        {
            Health -= factor;
            if (IsNeutralized) { Console.WriteLine("GAHHHHHH!!!"); }
            else
            {Console.WriteLine("Strong Invader Laughs at Puny Tower");}
        }

    }
}
