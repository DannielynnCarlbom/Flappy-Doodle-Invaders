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

    public Wall[] CreateWalls(int maxWallsPerRow, int numRows)
    {
        int totalWalls = maxWallsPerRow * numRows;

        Wall[] walls = new Wall[totalWalls];
        Random random = new Random();
        int wallwidth = 2;
        int gapWidth = 4; // Width of the gap between walls


        // Calculate the total width available for walls and gaps
        int totalWidth = Console.WindowWidth - (maxWalls * wallwidth) - ((maxWalls - 1) * gapWidth);

        // Calculate the number of gaps between walls
        int numGaps = maxWalls - 1;

        // Calculate the width of each gap
        int gapSize = totalWidth / numGaps;

        // Ensure the gap size is at least 1
        gapSize = Math.Max(gapSize, 1);

        // Initialize gap position to a random value within the range of gaps
        int gapPosition = random.Next(numGaps);

        int x = 0; // Initialize x coordinate for the first wall

        for (int i = 0; i < maxWalls; i++)
        {
            // If this is not the first wall, add a gap before it
            if (i > 0)
            {
                x += gapSize;
            }

            // Create the wall at the current position
            walls[i] = new Wall(x, 0, "^");

            // Move x coordinate to the position for the next wall
            x += wallwidth;
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

    

     
    