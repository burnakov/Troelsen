using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T arg);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Generic Delegates ****");
            MyGenericDelegate<string> strTarger = new MyGenericDelegate<string>(StringTarget);
            StringTarget("Some string data");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntegerTarget);
            intTarget(9);

            Console.ReadLine();
        }

        private static void IntegerTarget(int arg)
        {
            Console.WriteLine("++arg is: {0}", ++arg);
        }

        private static void StringTarget(string arg)
        {
            Console.WriteLine("arg in upper case: {0}", arg.ToUpper());
        }
    }
}
