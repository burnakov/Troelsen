using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with generic structures ****");
            Point<int> intPoint = new Point<int>(10, 17);
            Console.WriteLine("intPoint.ToString(): {0}", intPoint.ToString());
            intPoint.ResetPoint();
            Console.WriteLine("intPoint.ToString(): {0}", intPoint.ToString());

            Point<double> dPoint = new Point<double>(5.2, 7.9);
            Console.WriteLine("dPoint.ToString(): {0}", dPoint.ToString());
            dPoint.ResetPoint();
            Console.WriteLine("dPoint.ToString(): {0}", dPoint.ToString());

            Console.ReadLine();
        }
    }
}
