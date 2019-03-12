using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunWithStructures;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Value and Reference types ****");
            //ValueTypeAssignment();
            //ReferenceTypeAssignment();
            ValueTypeConteiningRefType();
            Console.ReadLine();
        }

        private static void ValueTypeConteiningRefType()
        {
            Console.WriteLine("=> Creating first rectangle");
            Rectangle rect1 = new Rectangle("Firt rect", 10, 12, 34, 55);
            Console.WriteLine("=> Assigning to second rectangle");
            Rectangle rect2 = rect1;
            Console.WriteLine("=> Changing info in rect2");
            rect2.rectInfo.infoString = "New rect info";
            rect2.rectBottom = 777;
            rect1.Display();
            rect2.Display();
        }

        private static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assainging reference types");
            RefPoint p1 = new RefPoint(10, 24);
            RefPoint p2 = p1;

            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("p1.X has chaneged");
            p1.Display();
            p2.Display();
        }

        private static void ValueTypeAssignment()
        {
            Console.WriteLine("Assainging value types");
            Point p1 = new Point(10, 24);
            Point p2 = p1;

            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("p1.X has chaneged");
            p1.Display();
            p2.Display();
        }
        
    }
    class RefPoint
    {
        public int X;
        public int Y;
        public RefPoint(int XPos, int YPos)
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
    class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }
    struct Rectangle
    {
        public ShapeInfo rectInfo;
        public int rectTop, rectBottom, rectLeft, rectRight;

        public Rectangle(string info, int top, int bottom, int left, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectBottom = bottom;
            rectLeft = left;
            rectRight = right;
        }
        public void Display()
        {
            Console.WriteLine("Info: {0}, Top: {1}, Bottom: {2}, Left: {3}, Right: {4}", rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }
}
