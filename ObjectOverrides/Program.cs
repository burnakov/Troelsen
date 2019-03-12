using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with System.Object ****");
            Person p1 = new Person();
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("GetHashCode: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());
            Person p2 = p1;
            object o = p2;
            if (o.Equals(p1) && o.Equals(p2))
            {
                Console.WriteLine("Same instance!");
            }
            Console.WriteLine();

            Person p3 = new Person("Homer", "Simpson", 54);
            Person p4 = new Person("Homer", "Simpson", 54);
            Console.WriteLine("p3.ToString(): {0}", p3.ToString());
            Console.WriteLine("p4.ToString(): {0}", p4.ToString());
            Console.WriteLine("p3 = p4: {0}", p3.Equals(p4));
            Console.WriteLine("Same hashCodes: {0}", p3.GetHashCode() == p4.GetHashCode());
            Console.WriteLine();

            p4.Age = 23;
            Console.WriteLine("p3.ToString(): {0}", p3.ToString());
            Console.WriteLine("p4.ToString(): {0}", p4.ToString());
            Console.WriteLine("p3 = p4: {0}", p3.Equals(p4));
            Console.WriteLine("Same hashCodes: {0}", p3.GetHashCode() == p4.GetHashCode());
            Console.WriteLine();
            StaticMembersOfObject();
            Console.ReadLine();
        }

        static void StaticMembersOfObject()
        {
            Person p3 = new Person("Homer", "Simpson", 54);
            Person p4 = new Person("Homer", "Simpson", 54);
            Console.WriteLine("p3.ToString(): {0}", p3.ToString());
            Console.WriteLine("p4.ToString(): {0}", p4.ToString());
            Console.WriteLine("p3 = p4: {0}", object.Equals(p3, p4));
            Console.WriteLine("Point to same object: {0}", object.ReferenceEquals(p3, p4));
        }
    }
}
