using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    public class Point
    {
        public double x { get; private set; }
        public double y { get; private set; }
        int boardSize = 10;

        public Point(bool addFloat = false)
        {
            Random random = new Random();
            x = random.Next(-boardSize, boardSize) + (addFloat ? random.NextDouble() : 0.0);
            y = random.Next(-boardSize, boardSize) + (addFloat ? random.NextDouble() : 0.0);
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
        }
        public bool IsLeft(Point p, bool sameY = false)
        {
            return x < p.x && y == p.y || !sameY;
        }
        public bool IsRight(Point p, bool sameY = false)
        {
            return x > p.x && y == p.y || !sameY;
        }
        public bool IsAbove(Point p, bool sameX = false)
        {
            return y > p.y && x == p.x || !sameX;
        }
        public bool IsBelow(Point p, bool sameX = false)
        {
            return y < p.y && x == p.x || !sameX;
        }
        public int Quardrant()
        {
            if (x < boardSize / 2 && y > boardSize / 2) return 1;
            if (x > boardSize / 2 && y > boardSize / 2) return 2;
            if (x < boardSize / 2 && y < boardSize / 2) return 3;
            if (x > boardSize / 2 && y < boardSize / 2) return 4;
            return 4;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public bool Equals(Point p)
        {
            return x == p.x && y == p.y;
        }
        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(p.y - y, 2) + Math.Pow(p.x - x, 2));
        }
        public Point Mirror()
        {
            return new Point(x * -1, y * -1);
        }
        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
