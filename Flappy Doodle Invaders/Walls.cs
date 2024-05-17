using System;

class Walls 
{
    public class Wall
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Symbol { get; set; }

        public Wall(int x, int y, string symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }
    }

    public Wall[] CreateWalls(int maxWalls)
    {
        Wall[] walls = new Wall[maxWalls];
        Random random = new Random();
        int wallwidth = 2;

        for (int i = 0; i < maxWalls; i++)
        {
            int x = random.Next(Console.WindowWidth - wallwidth);
            walls[i] = new Wall(x, 0, "^");
        }
        return walls;
    }

    public static void Render(Wall[] walls)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var wall in walls)
        {
            Console.SetCursorPosition(wall.X, wall.Y);
            Console.Write(wall.Symbol);

        }
    }
}

    

     
    