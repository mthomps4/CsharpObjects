namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length; 

        public Path(MapLocation[] path)
        {
            _path = path; 
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            //if (pathStep < _path.Length)
            //{
            //   return _path[pathStep];
            //}
            //else
            //{
            //   return null; 
            //}

            //Simplified 
            return (pathStep < _path.Length) ? _path[pathStep] : null; 
        }
        
    }
}