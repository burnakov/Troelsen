using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DefaultAppDomainapp
{
    class Program
    {
        static void Main(string[] args)
        {
            InitDAD();
            Console.WriteLine("**** Fun with default AppDomain ****");
            DisplayDADStats();
            ListAllAssembliesInAppDomain();

            Console.ReadLine();
        }

        private static void InitDAD()
        {
            AppDomain currDom = AppDomain.CurrentDomain;
            currDom.AssemblyLoad += (o, s) =>
            {
                Console.WriteLine("{0} assembly loaded", s.LoadedAssembly.GetName().Name);
            };
        }

        private static void ListAllAssembliesInAppDomain()
        {
            AppDomain currDom = AppDomain.CurrentDomain;
            var allAsm = from asm in currDom.GetAssemblies() orderby asm.GetName().Name select asm;
            Console.WriteLine("**** Here are all assemblies in {0} ****", currDom.FriendlyName);
            foreach(Assembly asm in allAsm)
            {
                Console.WriteLine("-> Name: {0}", asm.GetName().Name);
                Console.WriteLine("-> Version: {0}", asm.GetName().Version);
                Console.WriteLine();
            }
        }

        private static void DisplayDADStats()
        {
            AppDomain defAd = AppDomain.CurrentDomain;
            Console.WriteLine("Name of this domain: {0}", defAd.FriendlyName);
            Console.WriteLine("ID of this domain: {0}", defAd.Id);
            Console.WriteLine("Is this a default domain: {0}", defAd.IsDefaultAppDomain());
            Console.WriteLine("Base directory of this domain: {0}", defAd.BaseDirectory);
            Console.WriteLine();
        }
    }
}
