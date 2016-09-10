namespace TowerDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual double Power{get;} = 1.0;
        protected virtual double Accuracy{get;} = .75; //75% hit rate 
 
        //for tower miss 
        private static readonly System.Random _random = new System.Random(); 
        
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location; 
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy; 
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                //Do Stuff 
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        if (invader.IsNeutralized)
                        {
                            System.Console.WriteLine("He GONE! Invader was shot down at " + invader.Location);
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