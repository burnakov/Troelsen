using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Value of VehicleDescriptionAttribute ****");
            ReflectionOnAttributeUsingEarlyBinding();
            Console.ReadLine();
        }

        private static void ReflectionOnAttributeUsingEarlyBinding()
        {
            Type t = typeof(Winnebago);
            object[] attr = t.GetCustomAttributes(false);
            foreach(VehicleDescriptionAttribute a in attr)
                Console.WriteLine(a.Description);
        }
    }
}
