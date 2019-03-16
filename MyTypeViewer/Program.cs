using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to my TypeViewer ****");
            string userInput = "";
            do
            {
                Console.WriteLine("\n\"Q\" to exit application...");
                Console.Write("Type to exam: ");
                userInput = Console.ReadLine();
                try
                {
                    Type t = Type.GetType(userInput);
                    ListVariousStats(t);
                    ListFields(t);
                    ListProps(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch
                {
                    Console.WriteLine("Sorry type not found!");
                }
            } while (userInput.ToUpper() != "Q");
        }
        static void ListMethods(Type t)
        {
            Console.WriteLine("**** Methods ****");
            //MethodInfo[] methods = t.GetMethods();
            //if (methods.Length > 0)
            //{
            //    foreach (MethodInfo m in methods)
            //    {
            //        string retVal = m.ReturnType.FullName;
            //        StringBuilder sb = new StringBuilder("(");
            //        foreach (ParameterInfo p in m.GetParameters())
            //        {
            //            sb.Append(string.Format("{0} {1}, ", p.ParameterType, p.Name));
            //        }
            //        if (sb.Length > 1)
            //        {
            //            sb.Remove(sb.Length - 2, 2);
            //        }
            //        sb.Append(")");
            //        Console.WriteLine("-> {0} {1} {2}", retVal, m.Name, sb);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("- no methods -");
            //}
            //OR
            var mthds = from m in t.GetMethods() select m;
            if(mthds.Count() > 0)
            {
                foreach(MethodInfo m in mthds)
                    Console.WriteLine("-> {0}", m.ToString());
            }
            else
            {
                Console.WriteLine("- no methods -");
            }
            Console.WriteLine();
        }
        static void ListFields(Type t)
        {
            Console.WriteLine("**** Fields ****");
            var fieldsNames = from n in t.GetFields() select n.Name;
            if (fieldsNames.Count() > 0)
            {
                foreach (var name in fieldsNames)
                    Console.WriteLine("=> {0}", name);
            }
            else
            {
                Console.WriteLine("- no fields -");
            }
            Console.WriteLine();
        }
        static void ListProps(Type t)
        {
            Console.WriteLine("**** Poperties ****");
            var propsNames = from n in t.GetProperties() select n.Name;
            if (propsNames.Count() > 0)
            {
                foreach (var name in propsNames)
                    Console.WriteLine("=> {0}", name);
            }
            else
            {
                Console.WriteLine("- no properties -");
            }
            Console.WriteLine();
        }
        static void ListInterfaces(Type t)
        {
            Console.WriteLine("**** Interfaces ****");
            var iNames = from n in t.GetInterfaces() select n.Name;
            if (iNames.Count() > 0)
            {
                foreach (var name in iNames)
                    Console.WriteLine("=> {0}", name);
            }
            else
            {
                Console.WriteLine("- no interfaces -");
            }
            Console.WriteLine();
        }
        static void ListVariousStats(Type t)
        {
            Console.WriteLine("**** Various statistics ****");
            Console.WriteLine("Base class: {0}", t.BaseType);
            Console.WriteLine("Is abstract: {0}", t.IsAbstract);
            Console.WriteLine("Is sealed: {0}", t.IsSealed);
            Console.WriteLine("Is generic: {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Is type is class type: {0}", t.IsClass);
            Console.WriteLine();
        }
    }
}
