using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Game
{
    

    public Game()
    {

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

    }

    public void Initializer()
    {
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

}


