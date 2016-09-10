using System;


namespace TowerDefense
{
    class ShieldedInvader : Invader
    {
        public override double Health { get; protected set; } = 3;//Set Health of FastInvader to 2

        public ShieldedInvader(Path path) : base(path)
        {
            Console.WriteLine("He's Got a SHIELD!");
        } //Use same path 

        public override void DecreaseHealth(double factor) //override "overrides" initial Invader DecreaseHealth 
        {
            if (Random.NextDouble() < .5) //Decreases 50% of the time. 
            {
                base.DecreaseHealth(factor);
            }
            else {
                Console.WriteLine("Sheild deflected shot fired!");
            }
        }
    }
}
