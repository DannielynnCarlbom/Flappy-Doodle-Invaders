using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Walls
{
   public Walls[] walls = new Walls[4];
   double spawntimer = 2;
    public string WallSegment { get; set; }


    public Walls(int position, int height, string wallSegment)
    {
        Position = position;
        Height = height;
        WallSegment = wallSegment;
    }

    public bool IsWithinBounds(int y)
    {
        return y >= 0 && y < Height;
    }

    public void Render()
    {
        Console.SetCursorPosition(Position, 0);
    }

}