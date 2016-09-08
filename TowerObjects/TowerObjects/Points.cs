using System;

namespace TowerDefense
{
    class Point
    {
        //Create Width and Height Grid variables 
        //Assign accessability level (public, private)

        public readonly int X; //readonly modifier stops from Width being changed after start
        public readonly int Y; //Private by default if no accessabliity assigned 

        //Constructor Method 

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }

            Point that = obj as Point;

            return this.X == that.X && this.Y == that.Y;
        }

        public int DistanceTo(int x, int y)
        {
            //int xDiff = (X - x); //subtracts x and y passed into method from X and Y from the Point this method was called on. 
            //int yDiff = (Y - y);

            //int xDiffSquared = xDiff * xDiff;
            //int yDiffSquared = yDiff * yDiff;
        
            //return (int)Math.Sqrt(xDiffSquared + yDiffSquared);


            //refactored 
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}