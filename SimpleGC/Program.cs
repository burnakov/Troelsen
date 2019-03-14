using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With System GC ****");
            Console.WriteLine("Estemates bytes on heap: {0}", GC.GetTotalMemory(false));
            Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));

            Car refToMyCar = new Car("Zippy", 55);
            Console.WriteLine(refToMyCar.ToString());
            Console.WriteLine("Generation refToMyCar: {0}\n", GC.GetGeneration(refToMyCar));

            object[] tonOfObj = new object[50000];
            for (int i = 0; i < 50000; i++)
                tonOfObj[i] = new object();

            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();


            Console.WriteLine("Generation refToMyCar: {0}", GC.GetGeneration(refToMyCar));
            if (tonOfObj[9000] != null)
                Console.WriteLine("Generation tonOfObj[9000]: {0}", GC.GetGeneration(tonOfObj[9000]));
            else
                Console.WriteLine("tonOfObj[9000] is no longer alive");

            Console.WriteLine("\nGen 0 has been sweped {0} times", GC.CollectionCount(0));
            Console.WriteLine("\nGen 1 has been sweped {0} times", GC.CollectionCount(1));
            Console.WriteLine("\nGen 2 has beed sweped {0} times", GC.CollectionCount(2));

            Console.ReadLine();
        }
        static void MakeCar()
        {
            Car c = new Car();
            c = null;
        }
    }
}
