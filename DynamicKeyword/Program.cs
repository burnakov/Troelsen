using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplicitlyTypedVaewable();
            PrintThreeStrings();
            ChangeDynamicDataType();
            InvokeMembersOnDynamicData();

            Console.ReadLine();
        }

        private static void InvokeMembersOnDynamicData()
        {
            dynamic t = "hello";

            try
            {
                Console.WriteLine(t.ToUpper());

                Console.WriteLine(t.toupper());
                Console.WriteLine(t.Foo(9, true, "string"));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }

        private static void ChangeDynamicDataType()
        {
            dynamic t = "Hello";
            Console.WriteLine(t.GetType());

            t = true;
            Console.WriteLine(t.GetType());

            t = new List<int>();
            Console.WriteLine(t.GetType());
            Console.WriteLine();
        }

        private static void PrintThreeStrings()
        {
            var str1 = "";
            object str2 = "";
            dynamic str3 = "";
            Console.WriteLine("str1 type: {0}", str1.GetType());
            Console.WriteLine("str2 type: {0}", str2.GetType());
            Console.WriteLine("str3 type: {0}", str3.GetType());
            Console.WriteLine();
        }

        private static void ImplicitlyTypedVaewable()
        {
            var list = new List<int>();
            list.Add(90);
            //list = "";
        }
    }
}
