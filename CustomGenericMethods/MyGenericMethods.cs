using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    static class MyGenericMethods
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("Type of swaped objects: {0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }
        public static void DisplayType<T>()
        {
            Console.WriteLine("Base class of {0} is {1}", typeof(T), typeof(T).BaseType);
        }
    }
}
