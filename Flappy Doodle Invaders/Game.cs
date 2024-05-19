using System;

 class Game
{
    Walls.Wall[] walls;
    Walls wallsInstance;

    public Game()
    {
        wallsInstance = new Walls();
        walls = wallsInstance.CreateWalls(Console.WindowWidth / 2, 5,8);
    }

    public void Run()
    {
        Initializer();
        {
            while (true)
            {
                Update();
            }
        }

    }
    public void Update()
    {
        Walls.Render(walls);
    }

    public void Initializer()
    {
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

}


