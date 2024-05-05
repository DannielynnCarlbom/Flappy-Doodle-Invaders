using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    public Player (string name)
    {
        //pos.X = Console.WindowWidth / 2;


    }

    public void Update()
    {
        HandlePlayerInput();
        HandleBulletDestruction();

        foreach(Bullet bullet in bullets)
        {
            if (bullet != null)
            {
                bullet.Move();
            }
        }
    }
}

