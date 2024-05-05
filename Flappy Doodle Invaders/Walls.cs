using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public  class Walls
 {
    public int Position { get; set; }
    public int Height { get; set; }
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

    public static Walls CreateWallSegment(int position, int height)
    {
        string wallSegment = "/\\/\\";
        return new Walls(position, height, wallSegment);
    }

 }
