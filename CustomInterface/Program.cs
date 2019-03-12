using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with interfaces ****");
            Triangle t = new Triangle();
            t.Draw();
            Console.WriteLine();

            Hexagon hex = new Hexagon("God");
            Console.WriteLine("Points: {0}", hex.Points);
            Console.WriteLine();

            Circle c = new Circle("Lisa");
            IPointy itfPn = null;
            try
            {
                itfPn = (IPointy)c;
                Console.WriteLine("Points: {0}", itfPn.Points);
            }
            catch (InvalidCastException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPn2 = hex2 as IPointy;
            if (itfPn2 != null)
                Console.WriteLine("Points: {0}", itfPn2.Points);
            else
                Console.WriteLine("Not pointy");
            Console.WriteLine();

            Shape[] shapes = { new Triangle(), new Circle(), new Triangle("Jill"), new Circle("Circle"), new Hexagon("Jim") };
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                    Console.WriteLine("Points: {0}", ((IPointy)s).Points);
                else
                    Console.WriteLine("{0} the {1} is not a IPointy", s.PetName, s.GetType().Name);

                if (s is IDraw3D)
                    DrawIn3D((IDraw3D)s);
                else
                    Console.WriteLine("{0} the {1} is not a IDraw", s.PetName, s.GetType().Name);
                Console.WriteLine();

            }
            Console.WriteLine();

            ThreeDCircle o = new ThreeDCircle();
            o.Draw(); // 3d circle method
            ((Circle)o).Draw(); // circle method
            Circle o1 = new ThreeDCircle();
            o1.Draw(); // circle method
            Circle o2 = new ThreeDCircle();
            o2.Test(); // 3d circle method
            Console.WriteLine();

            IPointy firstPointyItem = FindFirstPointyShape(shapes);
            if(firstPointyItem != null)
                Console.WriteLine("The item {0} has {1} points", firstPointyItem.GetType().Name, firstPointyItem.Points);
            else
                Console.WriteLine("There are no pointy items");
            Console.WriteLine();

            Console.ReadLine();
        }
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach(Shape s in shapes)
            {
                if (s is IPointy)
                    return s as IPointy;
            }
            return null;
        }
    }
}
