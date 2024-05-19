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

        public void Fall(int wallsFallSpeed)
        {
            Y += wallsFallSpeed;
        }
    }

    //public bool IsCollision(Player player)
    // {

    //}

    public Wall[] CreateWalls(int wallsPerRow, int numRows, int gapWidth)
    {
        int totalWalls = wallsPerRow * numRows;
        Wall[] walls = new Wall[totalWalls];
        Random random = new Random();
        int wallWidth = 2;  // Corrected from `wallwidth` to `wallWidth`
        int screenHeight = Console.WindowHeight;
        int screenWidth = Console.WindowWidth;
        int wallHeight = screenHeight / numRows;

        for (int row = 0; row < numRows; row++)
        {
            int gapStart = random.Next(screenWidth - gapWidth);
            int y = row * wallHeight;

            for (int x = 0; x < screenWidth; x += wallWidth)
            {
                if (x < gapStart || x > gapStart + gapWidth)
                {
                    int wallIndex = row * wallsPerRow + (x / wallWidth);
                    if (wallIndex < totalWalls)  // Ensure we do not go out of bounds
                    {
                        walls[wallIndex] = new Wall(x, y, "^");
                    }
                }
            }
        }
        return walls;
    }

    public static void Render(Wall[] walls)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var wall in walls)
        { 
            if (wall != null)
            {
              Console.SetCursorPosition(wall.X, wall.Y);
              Console.Write(wall.Symbol);
            }   
        }
    }
}

    

     
    