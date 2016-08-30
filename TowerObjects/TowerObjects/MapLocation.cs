namespace TowerDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this)) //if this point is not on map 
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map."); 
            }
        }

        //In range of for tower 
        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range; 
        }
    }
}