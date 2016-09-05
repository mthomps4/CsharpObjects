namespace TowerDefense
{
    class Invader
    {
        //private MapLocation _location;

        //public MapLocation Location
        //{
        //   get { return _location; }
        //  private set { _location = value;}
        //}
        //For C# auto make get and set with 'public MapLocation Location { get; private set; }' remove field. 

        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

        //Above can be rewritten as 'public MapLocation Location => _path.GetLocationAt(_pathStep);'

        //Invader Health 
        public int Health { get; private set; } = 2; //Health property Uses DecreaseHealth Method for setting new health status. 

        //True if Invader has reached end of path. 
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        //True if Invaders Health = 0 
        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        //Path object to be accessed later 
        private readonly Path _path; 

        //Path step to know when Invader makes it to end of path 
        private int _pathStep = 0; //initial value set to 0 
  
        //To keep from returning null initially use constructor 
        public Invader(Path path)
        {
            _path = path; //Used from above 
        }

        //Tell invader to move 
        public void Move() => _pathStep += 1;

        public virtual void DecreaseHealth(int factor) //Keyword virtual added for Polymorphic Object (ShieldedInvader) Tells code this is One possible solution and that subclasses can provide their own. 
        {
            Health -= factor;
            System.Console.WriteLine("Shot and hit an invader!");
        }
    }
}

//Invader Class 
//path 
//pathStep 
//location property 
//Move method 