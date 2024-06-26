﻿using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
abstract class Doodleship
{

    protected int hitpoints = 1;
    public Point2d pos = new();
    char ship = 'A';
    public bool Exist = true;

    //public Bullet[] bullets = new Bullet[10];
    //public int bulletCounter = 0;
    //protected int maxBullets = 2;

    public Doodleship(char ship)
    {
        this.ship = ship; // Ship kan ändras om classen ärvs
    }

    protected virtual void MoveX(int x) // Flyttar karaktären upp och ner
    {
        pos.X += x;

        // När du går utanför skärmen teleporteras du till andra sidan
        if (pos.X < 1)
        {
            pos.X = Console.WindowWidth;
        }

        if (pos.X > Console.WindowWidth)
        {
            pos.X = 1;
        }

    }

    protected virtual void MoveY(int y) // Flyttar 
    {
        pos.Y += y;

        // Behövs inte längre eftersom målet med spelet nu är att ta sig till toppen
        /*if (pos.Y >= 30) // INTE KLAR!! Vad kommer max och min vara för Y position
        {
            pos.Y = 30;
        }
        if (pos.Y <= 1)
        {
            pos.Y = 1;
        }*/
    }
    public void Draw()
    {
        Console.SetCursorPosition((int)pos.X, (int)pos.Y);
        Console.Write(ship);
        //Loops through the bullets and draws them if they exist.
        //Could be optimised with a for-loop from 0 to bulletcount-1
        /*foreach (Bullet bullet in bullets)
        {
            if (bullet != null)
                bullet.Draw();
        }*/
    }
    /*protected void BulletEraser()
    {
        //loopar igenom array med bullets
        for (int i = 0; i <= bulletCounter; i++)
        {
            if (bullets[i] == null)
            {
                return;
            }
            //Kollar om bullet fortfarande lever
            if (!bullets[i].Exist)
            {
                //flyttar resten ett steg åt vänster
                for (int j = i; j < bulletCounter - 1; j++)
                    bullets[j] = bullets[j + 1];

                bulletCounter--; //Uppdatera antal kulor

                bullets[bulletCounter] = null; //Ta bort sista kulan
            }
        }
    }*/

    public void Eraser()
    {
        hitpoints--;
        if (hitpoints <= 0)
        {
            Exist = false;
        }
    }

}
