using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            int ans = c.Add(5, 1);
            Console.WriteLine("5 + 1 is {0}.", ans);
            Console.ReadLine();
        }
    }
    class Calc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
