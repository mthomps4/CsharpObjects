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

        //DRY Coding 
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

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
        public void Move()
        {
            _pathStep += 1;
            //Use objects instance of path 
        }
    }
}

//Invader Class 
//path 
//pathStep 
//location property 
//Move method 