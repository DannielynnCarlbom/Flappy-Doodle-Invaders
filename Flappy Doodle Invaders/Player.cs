using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    public Player (string name)
    {
        pos.X = Console.WindowWidth / 2;


    }

    public void Update()
    {
        HandlePlayerInput();
        HandleBulletDestruction();

        //  foreach(Bullet bullet in bullets)
        {
            if (bullet != null)
            {
                bullet.Move();
            }
        }

        void HandlePlayerInput()
        {
            if(Console.KeyAvailable)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                if(keyInfo.Key == ConsoleKey.A)
                {
                    Move(-1);
                }
                if(keyInfo.Key == ConsoleKey.D)
                {
                    Move(1);
                }
                if(keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Shoot();
                }
            }
        }

        void Shoot()
        {
            if (bulletCounter < maxBullets)
            {
                bullets[bulletCounter] = new(pos);
                bulletCounter++;
            }
        }
    }
}

