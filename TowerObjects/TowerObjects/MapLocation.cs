namespace TowerDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map firstMap) : base(x, y)
        {
            if (!firstMap.OnMap(this)) //if this point is not on firstMap 
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map."); 
            }
        }
    }
} 