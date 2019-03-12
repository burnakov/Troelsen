using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with polymorphysm ****");
            Hexagon betty = new Hexagon("Betty");
            betty.Draw();

            Circle nikky = new Circle("Nikky");
            nikky.Draw();
            Console.WriteLine();

            Shape[] myShapes = { new Circle(), new Hexagon(), new Hexagon("Nikky"), new Circle("Betty"), new Hexagon("Jack") };
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.WriteLine();

            ThreeDCircle o = new ThreeDCircle();
            o.Draw();
            ((Circle)o).Draw();
            Console.ReadLine();
        }
    }
}
