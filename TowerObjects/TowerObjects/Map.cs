﻿namespace TowerDefense
{
    class Map
    {
        //Create Width and Height Grid variables 
        //Assign accessability level (public, private)

        public readonly int Width; //readonly modifier stops from Width being changed after start
        public readonly int Height; //Private by default if no accessabliity assigned 

        //Constructor Method 

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

    }
}