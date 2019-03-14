using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtentions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Extending interface compatible types ****");
            string[] data = { "Wow", "this", "is", "sort", "of", "annoying", "but", "in", "a", "wierd", "way", "fun!" };
            data.PrintDataAndBeep();
            Console.WriteLine();

            List<int> ints = new List<int> { 10, 15, 20 };
            ints.PrintDataAndBeep();

            Console.ReadLine();
        }
    }
}
