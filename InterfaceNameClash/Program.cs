using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with interface name clashes ****");
            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            ((IDrawToMemory)oct).Draw();

            if (oct is IDrawToPrinter)
                ((IDrawToPrinter)oct).Draw();

            Console.ReadLine();
        }
    }
}
