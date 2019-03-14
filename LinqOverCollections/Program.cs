using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** LINQ Over Generic collections ****");
            List<Car> cars = new List<Car>
            {
                new Car { PetName="Jack", Color="Red", Speed=100, Make="BMW" },
                new Car { PetName="Jill", Color="Silver", Speed=55, Make="VW" },
                new Car { PetName="Kurt", Color="Green", Speed=9, Make="Ford" },
                new Car { PetName="Mellisa", Color="Black", Speed=65, Make="KIA" }
            };
            GetFastCars(cars);
            GetFastBMWs(cars);
            LinqOverArrayList(cars);
            OfTypeAsFilter();

            Console.ReadLine();
        }

        private static void OfTypeAsFilter()
        {
            ArrayList aList = new ArrayList { 1, "3", true, new Car(), 45, "string" };
            var eType = aList.OfType<int>();
            foreach (int item in eType)
                Console.WriteLine("Int value: {0}", item);
            Console.WriteLine("Type: {0}, Location: {1}", eType.GetType().Name, eType.GetType().Assembly.GetName().Name);
            Console.WriteLine();
        }
        static void LinqOverArrayList(List<Car> cars)
        {
            ArrayList aList = new ArrayList(cars);
            var enumCars = aList.OfType<Car>();
            var fastCars = from c in enumCars where c.Speed > 55 select c;
            foreach (var car in fastCars)
                Console.WriteLine("{0} is going too fast", car.PetName);
            Console.WriteLine();
        }
        static void GetFastCars(List<Car> cars)
        {
            var fast = from c in cars where c.Speed > 55 select c;
            foreach (var car in fast)
                Console.WriteLine("{0} is going too fast", car.PetName);
            Console.WriteLine();
        }
        static void GetFastBMWs(List<Car> cars)
        {
            var bmw = from c in cars where c.Speed > 90 && c.Make == "BMW" select c;
            foreach(var car in bmw)
                Console.WriteLine("{0} the fast one BMW", car.PetName);
            Console.WriteLine();
        }
    }
}
