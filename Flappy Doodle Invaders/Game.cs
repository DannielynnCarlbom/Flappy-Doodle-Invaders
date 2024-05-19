using System;
using System.Threading;
using System.Timers;

class Game
{
    Walls.Wall[] walls;
    Walls wallsInstance;
    int wallFallSpeed = 2;
    int numRows = 4;    
    int wallsPerRow;
    int[] rowFallTimers;
    int fallDelay = 2000;
    int screenHeight;
    Boss boss;
    int bossHeight = 2;


    public Game()
    {     
        wallsInstance = new Walls();            
        screenHeight = Console.WindowHeight;
        wallsPerRow = Console.WindowWidth / 2;
        walls = wallsInstance.CreateWalls(wallsPerRow, numRows, 8, bossHeight);
        rowFallTimers = new int[numRows];
        InitializeTimers();

        //Initalizing the boss
        boss = new Boss(Console.WindowWidth / 2, bossHeight - 1, "B");
    }

    public void Run()
    {
        Initializer();
        {
            while (true)
            {
                Update();
                Thread.Sleep(300); // Ta bort
            }
        }

    }
    public void Update()
    {
        int currentTime = Environment.TickCount;

        for (int row = 0; row < numRows; row++)
        {
            if (currentTime >= rowFallTimers[row])
            {
                int rowStartIndex = row * wallsPerRow;
                for (int i = 0; i < wallsPerRow; i++)
                {
                    var wall = walls[rowStartIndex + i];
                    if (wall != null)
                    {
                        wall.Fall(wallFallSpeed, screenHeight);
                    }
                }
                
            }
        }

        Console.Clear();
        Walls.Render(walls);
        boss.Render();
    }


    public void Initializer()
    {
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    private void InitializeTimers()
    {
        int initialDelay = 0;
        for (int i = 0; i < numRows; i++)
        {
            rowFallTimers[i] = Environment.TickCount + initialDelay;
            initialDelay += fallDelay;
        }
    }

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
}



