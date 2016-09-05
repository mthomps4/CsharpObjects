using System; 

namespace TowerDefense {
    class Game {
        public static void Main(){
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new [] {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                    }
                 );

                //New levels would normally be read from individual file but for example ... 
                Invader[] invaders =
                {
                    //new ShieldedInvader(path),
                    //new Invader(path),
                    //new FastInvader(path),
                   // new ShieldedInvader(path),
                    new StrongInvader(path)
                };

                //No graphical element for placing towers yet. 
                Tower[] towers =
                {
                    //new LongRangeTower(new MapLocation(7,3, map)),
                    new PowerTower(new MapLocation(3,3, map)),
                    //new Tower(new MapLocation(5,3, map))
                };

                Level level = new Level(invaders)
                {
                    //initialize Towers created 
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));


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

# int area = map.Width * map.Height;
# System.Console.WriteLine(area);
#
# Point point = new Point(4, 2);
# bool isOnMap = map.OnMap(point);
# Console.WriteLine(isOnMap);
#
#
# point = new Point(8, 5);
# isOnMap = map.OnMap(point);
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