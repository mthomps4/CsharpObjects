namespace TowerDefense
{
    class Point
    {
        //Create Width and Height Grid variables 
        //Assign accessability level (public, private)

        public readonly int X; //readonly modifier stops from Width being changed after start
        public readonly int Y; //Private by default if no accessabliity assigned 

        //Constructor Method 

        public Map(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}