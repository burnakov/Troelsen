using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with const ****");
            Console.WriteLine("The value of PI: {0}", MyMathClass.PI);

            //MyMathClass.PI = 3.143;
            Console.ReadLine();
        }
    }
}
