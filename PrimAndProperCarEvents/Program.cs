using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimAndProperCarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Car Events ****");
            Car c = new Car("Super Car", 10, 100);
            c.AboutToBlow += CarAboutToBlow;
            c.Exploded += CarExploded;

            Console.WriteLine("Speeding up:");
            for (int i = 0; i < 6; i++)
            {
                c.Accelerate(20);
            }

            Console.ReadLine();
        }

        private static void CarExploded(object sender, CarEventArgs e)
        {
            if (sender is Car)
            {
                Car c = (Car)sender;
                Console.WriteLine("{0} is exploded. {1}", c.PetName, e.msg);
            }
        }

        private static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says {1}", sender, e.msg);
        }
    }
}
