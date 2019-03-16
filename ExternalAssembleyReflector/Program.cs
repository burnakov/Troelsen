using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ExternalAssembleyReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** External Assembly Viewer ****");
            string userInput = "";
            do
            {
                Console.WriteLine("\n\"Q\" to exit...");
                Console.Write("Assembly to exam: ");
                userInput = Console.ReadLine();
                try
                {
                    Assembly asm = Assembly.Load(userInput);
                    DisplayTypesInAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry, file not found");
                }
            } while (userInput.ToUpper() != "Q");
        }
        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("**** Types in assembly ****\n");
            Console.WriteLine("-> {0}:", asm.FullName);
            foreach (Type t in asm.GetTypes())
                Console.WriteLine(" - {0}", t.FullName);
            Console.WriteLine();
        }
    }
}
