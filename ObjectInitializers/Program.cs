using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with object init syntax ****");
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 12;
            firstPoint.DisplayStats();
            Console.WriteLine();

            Point anotherPoint = new Point(32, 3);
            anotherPoint.DisplayStats();
            Console.WriteLine();

            Point finalPoint = new Point { X = 2, Y = 5 };
            finalPoint.DisplayStats();
            Console.WriteLine();

            Point coloredPoint = new Point(PointColor.LightBlue) { X = 90, Y = 20 };
            coloredPoint.DisplayStats();
            Console.WriteLine();

            Rectangle rect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            rect.DisplayStats();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
