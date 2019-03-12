using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresionsMultipleParams
{
    class Program
    {
        public delegate string VerySimpleDelegate();

        static void Main(string[] args)
        {
            SimpleMath sm = new SimpleMath();
            sm.SetMathMessage((string message, int result) => Console.WriteLine("Message: {0}, Result: {1}", message, result));
            sm.Add(1, 5);
            VerySimpleDelegate d = new VerySimpleDelegate(() => { return "Simple sting"; });
            Console.WriteLine(d.Invoke());

            Console.ReadLine();
        }
    }
}
