using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace CustomAppDomains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with custom AppDomain ****\n");
            AppDomain currDom = AppDomain.CurrentDomain;
            currDom.ProcessExit += (o, s) => Console.WriteLine("Main domain unloaded");
            ListAllAssembliesInAppDomain(currDom);
            MakeNewAppDomain();

            Console.ReadLine();
        }

        private static void MakeNewAppDomain()
        {
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");
            newAD.DomainUnload += (o, s) => Console.WriteLine("Second domain unloaded");
            try
            {
                newAD.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            ListAllAssembliesInAppDomain(newAD);
            AppDomain.Unload(newAD);
        }

        private static void ListAllAssembliesInAppDomain(AppDomain currDom)
        {
            Console.WriteLine("**** Here are all assemblies in {0} ****", currDom.FriendlyName);
            var allAsm = from asm in currDom.GetAssemblies() orderby asm.GetName().Name select asm;
            foreach (Assembly asm in allAsm)
            {
                Console.WriteLine("-> Name: {0}", asm.GetName().Name);
                Console.WriteLine("-> Version: {0}", asm.GetName().Version);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
