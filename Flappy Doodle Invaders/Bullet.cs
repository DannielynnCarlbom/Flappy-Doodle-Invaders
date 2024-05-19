
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bullet
{
    Vector3d hej;

    public Point3d pos = new();
    double lifeTime = 3;
    public bool Exist = true;

    public Bullet(int x, int y)
    {
        pos.X = x;
        pos.Y = y - 1;
    }
    public Bullet(Point3d p1)
    {
        pos.X = p1.X;
        pos.Y = p1.Y - 1; // För att den ska spawna ett steg framför player
    }

    public void Move()
    {
        pos.Y -= 1;
        if (pos.Y <= 1)
            Exist = false;
    }

    public void Draw()
    {
        if (Exist)
        {
            Console.SetCursorPosition((int)pos.X, (int)pos.Y);
            Console.Write("*");
        }
    }
    public Point3d getPos()
    {
        return pos;
    }
}
