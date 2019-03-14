using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with anonymous types ****");
            var car = new { Color = "Pink", Make = "Saab", Speed = 55 };
            Console.WriteLine("My car {0} {1}", car.Color, car.Make);

            BuildAnonType("BMW", "Red", 100);

            ReflectOverAnonymousTypes(car);

            EqualityTest();

            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new { Color = "Red", Make = "BMW", Speed = 55 },
                Price = 34.000
            };
            ReflectOverAnonymousTypes(purchaseItem);

            Console.ReadLine();
        }
        static void EqualityTest()
        {
            var firstCar = new { Color = "Red", Make = "BMW", Speed = 55 };
            var secondCar = new { Color = "Red", Make = "BMW", Speed = 55 };

            if (firstCar.Equals(secondCar))
                Console.WriteLine("Same anonymous objects");
            else
                Console.WriteLine("Not the same anonymous objects");

            if (firstCar == secondCar)
                Console.WriteLine("Same anonymous objects");
            else
                Console.WriteLine("Not the same anonymous objects");

            if (firstCar.GetType().Name == secondCar.GetType().Name)
                Console.WriteLine("The same type");
            else
                Console.WriteLine("Not the same type");
            Console.WriteLine();

            ReflectOverAnonymousTypes(firstCar);
            ReflectOverAnonymousTypes(secondCar);
            Console.WriteLine();
        }
        static void ReflectOverAnonymousTypes(object obj)
        {
            Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashcode() == {0}", obj.GetHashCode());
            Console.WriteLine();
        }
        static void BuildAnonType(string make, string color, int currSp)
        {
            var car = new { Make = make, Color = color, Speed = currSp };
            Console.WriteLine("Your {0} {1} going {2} KPH", car.Color, car.Make, car.Speed);
            Console.WriteLine("ToString() == {0}", car.ToString());
            Console.WriteLine();
        }
    }
}
