using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContextApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with object context ****");
            SportsCar car1 = new SportsCar();
            Console.WriteLine();

            SportsCar car2 = new SportsCar();
            Console.WriteLine();

            SportsCarTS car3 = new SportsCarTS();

            Console.ReadLine();
        }
    }
}
