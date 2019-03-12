using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with object sorting ****");
            Car[] carArray = new Car[4];
            carArray[0] = new Car("Jack", 80, 123);
            carArray[1] = new Car("Bob", 27, 563);
            carArray[2] = new Car("Mary", 77, 96);
            carArray[3] = new Car("Peter", 17, 228);
            Console.WriteLine("Here is my unsorted array:");
            foreach(Car c in carArray)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            Console.WriteLine();

            Array.Sort(carArray);
            Console.WriteLine("Here is my sorted array:");
            foreach(Car c in carArray)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            Console.WriteLine();

            Array.Sort(carArray, new PetNameComparer());
            Console.WriteLine("Array sorted by PetName:");
            foreach(Car c in carArray)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            Console.WriteLine();

            Array.Sort(carArray, Car.SortByPetName);

            Console.ReadLine();
        }
    }
}
