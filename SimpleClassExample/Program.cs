using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with class types ****");
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.WriteLine();

            Car chuckCar = new Car();
            chuckCar.PrintState();
            Console.WriteLine();

            Car mary = new Car("Mary");
            mary.PrintState();
            Console.WriteLine();

            Car dasy = new Car("Dasy", 75);
            dasy.PrintState();
            Console.WriteLine();

            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();
            Console.WriteLine();

            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Driver name is {0}", c.driverName);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
