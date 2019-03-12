using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Method overloading:");
            Console.WriteLine(Add(10,12));
            Console.WriteLine(Add(900000000000000, 90000000000000000));
            Console.WriteLine(Add(2.3, 3.0).GetType());
            Console.ReadLine();
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static double Add(double x, double y)
        {
            return x + y;
        }
        private static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
