using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEventsWithLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Car Events ****");
            Car c = new Car("Super Car", 10, 100);
            c.AboutToBlow += (sender, e) => { Console.WriteLine(e.msg); };
            c.Exploded += (sender, e) => { Console.WriteLine(e.msg); };

            Console.WriteLine("Speeding up:");
            for (int i = 0; i < 6; i++)
            {
                c.Accelerate(20);
            }

            Console.ReadLine();
        }
    }
}
