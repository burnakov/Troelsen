using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return (new Point(p1.X + p2.X, p1.Y + p2.Y));
        }
        public static Point operator -(Point p1, Point p2)
        {
            return (new Point(p1.X - p2.X, p1.Y - p2.Y));
        }
        public static Point operator +(Point p, int change)
        {
            return (new Point(p.X + change, p.Y + change));
        }
        public static Point operator -(Point p, int change)
        {
            return (new Point(p.X - change, p.Y - change));
        }
        public static Point operator +(int change, Point p)
        {
            return (new Point(p.X + change, p.Y + change));
        }
        public static Point operator -(int change, Point p)
        {
            return (new Point(p.X - change, p.Y - change));
        }
        public static Point operator ++(Point p)
        {
            return (new Point(p.X + 1, p.Y + 1));
        }
        public static Point operator --(Point p)
        {
            return (new Point(p.X - 1, p.Y - 1));
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) > 0);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) < 0);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) >= 0);
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) <= 0);
        }

        public int CompareTo(Point p)
        {
            if (this.X > p.X && this.Y > p.Y)
                return 1;
            if (this.X < p.X && this.Y < p.Y)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return String.Format("[{0}, {1}]", X, Y);
        }
        public override bool Equals(object obj)
        {
            return (obj.ToString() == this.ToString());
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
