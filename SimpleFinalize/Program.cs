using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinalize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun With Finalizers ****");
            Console.WriteLine("Hit enter to initiate finalize() method");

            Console.ReadLine();
            MyResourceWrapper rw = new MyResourceWrapper();
        }
    }
}
