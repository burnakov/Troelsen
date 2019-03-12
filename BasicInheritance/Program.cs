using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Basic inharitance ****");
            Car c = new Car(80);
            c.CurrSpeed = 50;
            Console.WriteLine("My car is going {0} MPH", c.CurrSpeed);
            Console.WriteLine();

            MiniVan van = new MiniVan();
            van.CurrSpeed = 30;
            Console.WriteLine("My van is going {0} MPH. Max speed: {1}", van.CurrSpeed, van.maxSpeed);
            Console.WriteLine("My car is going {0} MPH", c.CurrSpeed);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
