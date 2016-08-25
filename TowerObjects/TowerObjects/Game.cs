using System; 

namespace TowerDefense {
    class Game {
        public static void Main(){
            Map firstMap = new Map(8, 5);

            int area = firstMap.Width * firstMap.Height;
            System.Console.WriteLine(area);

            Point point = new Point(4, 2);       
            bool isOnMap = firstMap.OnMap(point);
            Console.WriteLine(isOnMap);


            point = new Point(8, 5);
            isOnMap = firstMap.OnMap(point);
            Console.WriteLine(isOnMap);

            point = new Point(4, 2);
            Console.WriteLine(point.DistanceTo(5, 5)); 
        }
    }
}