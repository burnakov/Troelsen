using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with yield keyword ****");
            Garage carLot = new Garage();

            foreach (Car c in carLot)
                Console.WriteLine("{0} is going {1} KPH", c.PetName, c.CurrSpeed);
            Console.WriteLine();

            Console.WriteLine("Get cars in reversed:");
            foreach (Car c in carLot.GetTheCars(true))
                Console.WriteLine("{0} is going {1} KPH", c.PetName, c.CurrSpeed);

            Console.ReadLine();
        }
    }
}
