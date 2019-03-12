using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with custom generic methods ****");
            int i1 = 10;
            int i2 = 5;
            Console.WriteLine("Before swaping: {0} {1}", i1, i2);
            MyGenericMethods.Swap<int>(ref i1, ref i2);
            Console.WriteLine("After swaping: {0} {1}", i1, i2);
            Console.WriteLine();

            string str1 = "Hello";
            string str2 = "there";
            Console.WriteLine("Before swaping: {0} {1}", str1, str2);
            MyGenericMethods.Swap<string>(ref str1, ref str2);
            Console.WriteLine("After swaping: {0} {1}", str1, str2);
            Console.WriteLine();

            MyGenericMethods.DisplayType<bool>();
            MyGenericMethods.DisplayType<string>();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
