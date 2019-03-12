using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with object cloning ****");
            Point p1 = new Point(12, 43);
            Point p2 = p1;
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine();

            Console.WriteLine("Cloned p3 and stored in new Point p4");
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            Console.WriteLine();

            p4.desc.PetName = "New name";
            p4.X = 56;
            Console.WriteLine("Changed p4.desc.PetName and p4.X");
            Console.WriteLine("After midification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
