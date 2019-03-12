using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Welcome to my application ***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            ShowEnviromentDetails();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void ShowEnviromentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.Version);
        }
    }
}
