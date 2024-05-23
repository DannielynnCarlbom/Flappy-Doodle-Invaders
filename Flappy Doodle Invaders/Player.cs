using System;

class Player : Doodleship
{
    public Player(char ship) : base (ship)
    {
        pos.X = Console.WindowWidth / 2;
        pos.Y = Console.WindowHeight - 2;
    }

    public void Update()
    {
        HandlePlayerInput();
    }

    void HandlePlayerInput()
    {
        if(Console.KeyAvailable)
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if(keyInfo.Key == ConsoleKey.A||keyInfo.Key == ConsoleKey.LeftArrow)
            {
                MoveX(-1);
            }
            if(keyInfo.Key == ConsoleKey.D||keyInfo.Key==ConsoleKey.RightArrow)
            {
                MoveX(1);
            }
            if(keyInfo.Key == ConsoleKey.W||keyInfo.Key==ConsoleKey.UpArrow)
            {
                MoveY(1);
            }
            if (keyInfo.Key == ConsoleKey.S||keyInfo.Key==ConsoleKey.DownArrow)
            {
                MoveY(-1);
            }
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                //Shoot();
            }
        }
    }

}


