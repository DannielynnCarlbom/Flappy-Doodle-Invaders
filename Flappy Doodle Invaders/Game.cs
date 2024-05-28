using System;
using System.Threading;
using System.Timers;

// Class responsible for managing the game logic
class Game
{
    bool loop = true;


    // Array of walls in the game
    Walls.Wall[] walls;
    
    // Instance of the Walls class
    Walls wallsInstance;

    Player player = new('A');
    
    // Speed at which walls fall
    int wallFallSpeed = 3;
    
    // Number of rows of walls
    int numRows = 2;
    
    // Number of walls per row
    int wallsPerRow;
    
    // Array to store timers for each row
    int[] rowFallTimers;

    // Delay between rows falling
    int fallDelay = 2000;

    // Height of the game screen
    int screenHeight;

    // Boss boss; (commented out for now because of not using the boss class)
    // int bossHeight = 2; (commented out for now because of not using the boss class)

    
    // Constructor for the Game class
    public Game()
    {
        player.Draw();
        wallsInstance = new Walls();            
        screenHeight = Console.WindowHeight;
        wallsPerRow = Console.WindowWidth / 2;
        // Create walls using Walls class instance
        walls = wallsInstance.CreateWalls(wallsPerRow, numRows, 8, 0); //bossHeight); (commented out for now because of not using the boss class)
        rowFallTimers = new int[numRows];
        InitializeTimers(); // Initialize timers for each row

        //Initalizing the boss
        // boss = new Boss(Console.WindowWidth / 2, bossHeight - 1, "B");
        //(commented out for now because of not using the boss class)
    }

    // Method to start the game loop
    public void Run()
    {

        
        Initializer();
        {
            while (true)
            {
                Console.Clear();
                //if (looptime == 0)
                UpdateWall();
                //player.Update();
                // Update game state       
                Thread.Sleep(300); // Pause for a short time before updating again
                /*if (looptime == 20)
                    looptime = 0;
                else
                    looptime++;*/

                Render();
            }
        }
    }

    
    public void UpdateWall()//Method made for updating the state of the game
    {
        int currentTime = Environment.TickCount;

        // Iterate over each row of walls
        for (int row = 0; row < numRows; row++)
        {
            if (currentTime >= rowFallTimers[row])
            {
                int rowStartIndex = row * wallsPerRow;
                for (int i = 0; i < wallsPerRow; i++) // Iterate over each wall in the row
                {
                    var wall = walls[rowStartIndex + i];
                    if (wall != null)
                    {
                        wall.Fall(wallFallSpeed, screenHeight); // Make the wall fall
                    }
                }
                
            }
        }

        //boss.Render(); (commented out for now because of not using the boss class)
    }

    public void Render()
    {
        // Clear the console and render the walls
        Console.Clear();
        Walls.Render(walls);
        player.HandlePlayerInput();
        player.Draw();
    }

    
    public void Initializer()// Method to initialize the game settings
    {
        Console.CursorVisible = false; //Made for hiding the cursor
        Console.BufferHeight = Console.WindowHeight; 
        Console.BufferWidth = Console.WindowWidth;
    }

    // Method to initialize timers for each row
    private void InitializeTimers()
    {
        int initialDelay = 0;
        for (int i = 0; i < numRows; i++)
        {
            rowFallTimers[i] = Environment.TickCount + initialDelay;
            initialDelay += fallDelay;
        }
    }

    // Method to reset a row of walls (not currently used)
    private void ResetRow(int row)
    {
        int rowStartIndex = row * wallsPerRow;
        for (int i = 0; i < wallsPerRow; i++)
        {
            var wall = walls[rowStartIndex + i];
            if (wall != null)
            {
                wall.Y = -1;  // Start just above the screen
            }
        }
    }

    /*public void CheckCollision()
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < numRows; j++)
            {
                // Inte klart
                int WallPosX = (int)Walls.pos.X;  // Väggar har inte pos
                int WallPosY = (int)Walls.pos.Y;

                if (player.pos.X == WallPosX)
                {
                    if (player.pos.Y == WallPosY)
                    {

                        loop = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("YOU LOST!!...");
                        Thread.Sleep(3000);
                        Menu.StartMenu();

                    }
                }
            }
        }
    }*/
}



