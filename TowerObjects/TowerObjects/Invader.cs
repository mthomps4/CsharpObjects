namespace TowerDefense
{
    class Invader
    {
        private MapLocation _location;

        public MapLocation GetLocation()
        { return _location; }

        public void SetLocatoin(MapLocation value)
        { _location = value; }
    }
}