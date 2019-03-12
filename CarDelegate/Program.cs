using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Delegated as event enablers ****");
            Car c1 = new Car("Jimmy", 0, 110);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            Car.CarEngineHandler handler = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler);
            for (int i = 0; i < 7; i++)
                c1.Accelerate(20);

            c1.UnRegisterWithCarEngine(handler);
            c1.Accelerate(10);

            Console.ReadLine();
        }


        private static void OnCarEngineEvent(string msgForCaller)
        {
            Console.WriteLine("\n----- Message from Car object -----");
            Console.WriteLine("=> {0}", msgForCaller);
            Console.WriteLine("-----------------------------------\n");
        }
        private static void OnCarEngineEvent2(string msgForCaller)
        {
            Console.WriteLine("=> {0}", msgForCaller.ToUpper());
        }
    }
}
