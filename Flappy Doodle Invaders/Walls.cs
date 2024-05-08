using System;

public class Walls
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

    public static Wall[] CreateWalls(int maxWalls)
    {
        Wall[] walls = new Wall[maxWalls];
        Random random = new Random();
        for (int i = 0; i < maxWalls; i++)
        {
            walls[i] = new Wall(random.Next(Console.WindowWidth), 2, "[]");
        }
        return walls;
    }
    public static void Render(Wall[] walls)
    {
        foreach (var wall in walls)
        {
            Console.SetCursorPosition(wall.X, wall.Y);
            Console.Write(wall.Symbol);
        }
    }
}

    

     
    