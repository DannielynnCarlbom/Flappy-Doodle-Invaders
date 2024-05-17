using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player : Doodleship
{
    public Player(int initialX, int initialY) : base(initialX, initialY)
    {
        X = initialX;
        Y = initialY;
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

                if(keyInfo.Key == ConsoleKey.A)
                {
                   
                }
                if(keyInfo.Key == ConsoleKey.D)
                {
                   
            }
                if(keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Shoot();
                }
            }
        }

        void Shoot()
        {
         //   if (bulletCounter < maxBullets)
            {
           //     bullets[bulletCounter] = new(pos);
             //   bulletCounter++;
            }
        }
        public void Render()
        {
         
        }
     }


