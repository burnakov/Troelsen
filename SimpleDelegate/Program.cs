using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Simple delegate example ****");
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);
            Console.WriteLine("10 + 10 = {0}", b(10, 10));
            Console.WriteLine();

            DisplayDelegateInfo(b);
            //BinaryOp b2 = new BinaryOp(SimpleMath.SquareNumber); // Can't be compiled
            Console.WriteLine();

            Console.ReadLine();
        }
        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method: {0}", d.Method);
                Console.WriteLine("Type: {0}", d.Target);
            }
        }
    }

    public delegate int BinaryOp(int x, int y);

    public class SimpleMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Substract(int x, int y)
        {
            return x - y;
        }
        public int SquareNumber(int x)
        {
            return x * x;
        }
    }
}
