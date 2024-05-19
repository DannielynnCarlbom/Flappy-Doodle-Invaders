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

        public void Fall(int wallsFallSpeed, int screenHeight)
        {
            Y += wallsFallSpeed;
            if (Y >= screenHeight)
            {
                Y = 0;
            }
        }
    }

    //public bool IsCollision(Player player)
    // {

    //}

    public Wall[] CreateWalls(int wallsPerRow, int numRows, int gapWidth, int bossHeight, int startY)
    {
        int totalWalls = wallsPerRow * numRows;
        Wall[] walls = new Wall[totalWalls];
        Random random = new Random();
        int wallWidth = 2;
        int screenWidth = Console.BufferWidth;

   
        for (int row = 0; row < numRows; row++)
        {
            
            int y = startY + row;

            // Generate a random start position for the gap for each row
            int gapStart = random.Next(screenWidth - gapWidth);

            for (int i = 0; i < wallsPerRow; i++)
            {
                int x = i * wallWidth;
                if (x < gapStart || x >= gapStart + gapWidth)
                {
                    int wallIndex = row * wallsPerRow + i;
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
            if (wall != null && wall.Y >= 0 && wall.Y < Console.WindowHeight)
            {
              Console.SetCursorPosition(wall.X, wall.Y);
              Console.Write(wall.Symbol);
            }   
        }
    }
}

    

     
    