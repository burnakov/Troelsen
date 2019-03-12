using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConFigureCUI();
            Console.ReadLine();
        }

        private static void ConFigureCUI()
        {
            Console.Title = "My console title";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************");
            Console.WriteLine("*** Welcome to boring console. ***");
            Console.WriteLine("**********************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
