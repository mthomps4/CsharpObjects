using System; 

namespace TowerDefense {
    class Game {
        public static void Main(){
            Map firstMap = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new [] {
                    new MapLocation(0, 2, firstMap),
                    new MapLocation(1, 2, firstMap),
                    new MapLocation(2, 2, firstMap),
                    new MapLocation(3, 2, firstMap),
                    new MapLocation(4, 2, firstMap),
                    new MapLocation(5, 2, firstMap),
                    new MapLocation(6, 2, firstMap),
                    new MapLocation(7, 2, firstMap)
                    }
                 );

                MapLocation location = path.GetLocationAt(8);

                if (location != null)
                {
                    Console.WriteLine(location.X + "," + location.Y);
                }
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (TowerDefenseExceptions)
            {
                Console.WriteLine("Unhandled Tower Defense Exeption");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex); 
            }
        }
    }



    /*

# int area = firstMap.Width * firstMap.Height;
# System.Console.WriteLine(area);
#
# Point point = new Point(4, 2);
# bool isOnMap = firstMap.OnMap(point);
# Console.WriteLine(isOnMap);
#
#
# point = new Point(8, 5);
# isOnMap = firstMap.OnMap(point);
# Console.WriteLine(isOnMap);
#
# point = new Point(4, 2);
# Console.WriteLine(point.DistanceTo(5, 5));
 
    Inheritance Example 
     
    class Polygon
    {
        public readonly int NumSides;

        public Polygon(int numSides)
        {
            NumSides = numSides;
        }
    }

        class Square : Polygon 
        {
            public readonly int SideLength; 
            public Square(int sideLength) : base(4) 
            {
                SideLength = sideLength; 
            }
        }

     */




}