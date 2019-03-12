using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with automatic props ****");
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 23;
            c.Color = "Red";

            Console.WriteLine("Your car name is {0}? That's odd...", c.PetName);
            c.DisplayStats();
            Console.WriteLine();

            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number of cars: {0}", g.NumberOfCars);
            Console.WriteLine("My car's name: {0}", g.MyAuto.PetName);
            Console.ReadLine();
        }
    }
}
