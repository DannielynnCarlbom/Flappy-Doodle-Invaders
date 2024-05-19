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
        //Handles all changes in the playerclass
        HandlePlayerInput();
        /*BulletEraser();

        foreach (Bullet bullet in bullets)
        {
            if (bullet != null)
                bullet.Move();
        }*/
    }

    void HandlePlayerInput()
    {
        if(Console.KeyAvailable)
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if(keyInfo.Key == ConsoleKey.A) //ConsoleKey.LeftArrow
            {
                MoveY(-1);
            }
            if(keyInfo.Key == ConsoleKey.D) //ConsoleKey.RighttArrow
            {
                MoveX(1);
            }
            if(keyInfo.Key == ConsoleKey.W) //ConsoleKey.UpArrow
            {
                MoveY(1);
            }
            if (keyInfo.Key == ConsoleKey.S) //ConsoleKey.DownArrow
            {
                MoveX(-1);
            }
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                //Shoot();
            }
        }
    }

    /*void Shoot()
    {
        //Shoots if you can.
        if (bulletCounter < maxBullets)
        {
            bullets[bulletCounter] = new(pos);
            bulletCounter++;

        }
    }*/
        public void Render()
        {
         
        }

}


