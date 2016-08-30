namespace TowerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75; //75% hit rate 
 
        //for tower miss 
        private static readonly System.Random _random = new System.Random(); 
        
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location; 
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy; 
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                //Do Stuff 
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        System.Console.WriteLine("Shot and hit an invader!");

                        if (invader.IsNeutralized)
                        {
                            System.Console.WriteLine("He GONE!");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Missed... "); 
                    }

                    break;

                }
            }
        } 
    }
}