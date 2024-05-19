using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Boss
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Symbol { get; set; }

    public Boss(int x, int y, string symbol)
    {
        X = x;
        Y = y;
        Symbol = symbol;
    }

    public void Render()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(Symbol);
    }

}
