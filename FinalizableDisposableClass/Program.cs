using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Dispose / Destructor Combo Platter ****");
            MyResourceWrapper rw1 = new MyResourceWrapper();
            rw1.Dispose(); // If Dispose() was invoked, destructor will be suppressed
            MyResourceWrapper rw2 = new MyResourceWrapper();
        }
    }
}
