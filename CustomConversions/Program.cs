using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with conversions ****");
            Rectangle r = new Rectangle(14, 5);
            Console.WriteLine(r.ToString());
            r.Draw();

            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            DrawSquare((Square)r);

            Square s2 = (Square)90;
            Console.WriteLine("s2 = {0}", s2);
            s2.Draw();

            int side = (int)s2;
            Console.WriteLine("Length of square side: {0}", side);

            Square s3 = new Square(83);
            Rectangle r2 = s3;
            Console.WriteLine("r2: {0}", r2.ToString());

            Square s4 = new Square(7);
            Rectangle r3 = (Rectangle)s4;
            Console.WriteLine("r3: {0}", r3);

            Console.ReadLine();
        }

        private static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}
