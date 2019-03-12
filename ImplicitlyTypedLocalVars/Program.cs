using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Implicitly typed local vars:");
            //DeclareImplicitVars();
            LinqQuaryOverInts();
            Console.ReadLine();
        }

        private static void LinqQuaryOverInts()
        {
            int[] numbers = { 10, 12, 3, 6, 34, 2, 7, 11 };
            var subset = from i in numbers where i < 10 select i;
            foreach (var i in subset)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine();
            Console.WriteLine("subset is: {0}", subset.GetType().Name);
            Console.WriteLine("subset defined in: {0}", subset.GetType().Namespace);
            Console.WriteLine();
        }

        private static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "My new string";
            Console.WriteLine("myInt is: \t{0}", myInt.GetType().Name);
            Console.WriteLine("myBool is: \t{0}", myBool.GetType().Name);
            Console.WriteLine("myString is: \t{0}", myString.GetType().Name);
            Console.WriteLine();
        }
    }
}
