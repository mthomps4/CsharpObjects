namespace TowerDefense {
    class Game {
        public static void Main(){
            Map firstMap = new Map(8, 5);

            int area = firstMap.Width * firstMap.Height;
            System.Console.WriteLine(area); 

        }
    }
}