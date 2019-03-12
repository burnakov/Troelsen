using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Agh! No encapsulation ****");
            Car c = new Car();
            c.listOfHandlers = new Car.CarEngineHandler(CallWhenExplode);
            c.Accelerate(20);

            c.listOfHandlers = new Car.CarEngineHandler(CallHereToo);
            c.Accelerate(5);

            c.listOfHandlers.Invoke("he he he");

            Console.ReadLine();
        }

        private static void CallWhenExplode(string msgForCaller)
        {
            Console.WriteLine("1. " + msgForCaller);
        }
        private static void CallHereToo(string msg)
        {
            Console.WriteLine("2. " + msg);
        }
    }
}
