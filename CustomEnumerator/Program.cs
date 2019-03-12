using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with IEnumerable / IEnumerator ****");
            Garage carLot = new Garage();
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} KPH", c.PetName, c.CurrSpeed);
            }
            Console.WriteLine();

            IEnumerator iEnum = carLot.GetEnumerator();
            iEnum.MoveNext();
            Car myCar = (Car)iEnum.Current;
            Console.WriteLine("{0} is going {1}", myCar.PetName, myCar.CurrSpeed);

            Console.ReadLine();
        }
    }
}
