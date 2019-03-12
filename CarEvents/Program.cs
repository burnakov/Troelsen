using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Events ****");
            Car myCar = new Car("Mikky", 10, 100);

            myCar.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
            myCar.AboutToBlow += new Car.CarEngineHandler(CarAboutToBlow);
            Car.CarEngineHandler exploded = new Car.CarEngineHandler(CarExploded);
            myCar.Exploded += exploded;

            //OR
            //myCar.AboutToBlow += CarIsAlmostDoomed;
            //myCar.AboutToBlow += CarAboutToBlow;
            //myCar.Exploded += CarExploded;


            Console.WriteLine("Speeding up:");
            for (int i = 0; i < 6; i++)
            {
                myCar.Accelerate(20);
            }

            myCar.Exploded -= exploded;

            //OR
            //myCar.Exploded -= CarExploded;

            Console.WriteLine("Speeding up:");
            for (int i = 0; i < 6; i++)
            {
                myCar.Accelerate(20);
            }

            Console.ReadLine();
        }

        private static void CarExploded(string msgForCaller)
        {
            Console.WriteLine("3. " + msgForCaller);
        }

        private static void CarAboutToBlow(string msgForCaller)
        {
            Console.WriteLine("2. " + msgForCaller);
        }

        private static void CarIsAlmostDoomed(string msgForCaller)
        {
            Console.WriteLine("1. => Critical message from car: {0}", msgForCaller);
        }
    }
}
