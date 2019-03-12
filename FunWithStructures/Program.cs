using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** A first look at structures ****");
            Point myPoint;
            myPoint.X = 320;
            myPoint.Y = 7;
            myPoint.Display();
            myPoint.Increment();
            myPoint.Display();

            Point nextPoint = new Point();
            nextPoint.Display();

            Point p3 = new Point(56, 4);
            p3.Display();
            Console.ReadLine();
        }
    }
    public struct Point
    {
        public int X;
        public int Y;
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
        public void Increment()
        {
            X++; Y++;
        }
        public void Decrement()
        {
            X--; Y--;
        }
        public void Display()
        {
            Console.WriteLine("X: {0}, Y: {1}", X, Y);
        }
    }
}
