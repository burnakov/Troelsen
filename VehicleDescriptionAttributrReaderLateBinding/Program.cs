using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace VehicleDescriptionAttributrReaderLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Value of VehicleDescriptionAttribute ****");
            ReflectAttributesUsingLateBinding();

            Console.ReadLine();
        }

        private static void ReflectAttributesUsingLateBinding()
        {
            try
            {
                Assembly asm = Assembly.Load("AttributedCarLibrary");
                Type vehicleDesc = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute");
                PropertyInfo descProp = vehicleDesc.GetProperty("Description");
                Type[] types = asm.GetTypes();
                foreach (Type t in types)
                {
                    object[] customAttr = t.GetCustomAttributes(vehicleDesc, false);
                    foreach(object attr in customAttr)
                        Console.WriteLine("-> {0}: {1}", t.Name, descProp.GetValue(attr, null));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
