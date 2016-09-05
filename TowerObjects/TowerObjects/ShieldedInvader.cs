using System;


namespace TowerDefense
{
    class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random(); //Used for "Shield" 

        public ShieldedInvader(Path path) : base(path)
        {
            Console.WriteLine("He's Got a SHIELD!");
        } //Use same path 

        public override void DecreaseHealth(int factor) //override "overrides" initial Invader DecreaseHealth 
        {
            if (_random.NextDouble() < .5) //Decreases 50% of the time. 
            {
                base.DecreaseHealth(factor);
            }
            else {
                Console.WriteLine("Sheild deflected shot fired!");
            }
        }
    }
}
