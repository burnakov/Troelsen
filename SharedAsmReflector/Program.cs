using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SharedAsmReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Shared Assemblies Reflector Application ****");
            string asmName = "System.Windows.Forms,Version=4.0.0.0,PublicKeyToken=b77a5c561934e089," + @"Culture=""";
            Assembly asm = Assembly.Load(asmName);
            DisplayInfo(asm);
            Console.WriteLine("Done");

            Console.ReadLine();
        }
        static void DisplayInfo(Assembly asm)
        {
            Console.WriteLine("**** Assembly Info ****");
            Console.WriteLine("Loaded from GAC: {0}", asm.GlobalAssemblyCache);
            Console.WriteLine("Assembly name: {0}", asm.GetName().Name);
            Console.WriteLine("Assembly version: {0}", asm.GetName().Version);
            Console.WriteLine("Assembly culture: {0}", asm.GetName().CultureInfo.DisplayName);
            Console.WriteLine("\nPublic enums:");
            var pEnums = from t in asm.GetTypes() where t.IsPublic && t.IsEnum select t;
            foreach(var item in pEnums)
                Console.WriteLine(item.FullName);
        }
    }
}
