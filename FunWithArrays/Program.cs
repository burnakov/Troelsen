using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with arrays ***");
            //SimpleArrays();
            //ArrayInitialisation();
            //DeclareImplicedArrays();
            //ArrayOfObjects();
            //RectMultidimensionalArray();
            //JuggetMultidimensionalArray();
            //PassAndReceiveArrays();
            SystemArrayFunctionality();
            Console.ReadLine();
        }

        private static void SystemArrayFunctionality()
        {
            string[] myGrpoups = new string[] { "Nirvana", "DEFTONES", "System of a down" };
            Console.WriteLine("Target array:");
            foreach (string group in myGrpoups)
            {
                Console.Write(group + ", ");
            }
            Console.WriteLine();
            Array.Reverse(myGrpoups);
            Console.WriteLine("Reverse array:");
            foreach (string group in myGrpoups)
            {
                Console.Write(group + ", ");
            }
            Console.WriteLine();
            Array.Clear(myGrpoups, 1, 2);
            Console.WriteLine("Cleared array:");
            for(int i = 0; i < myGrpoups.Length; i++)
            {
                Console.Write(myGrpoups[i] + ", ");
            }
            Console.WriteLine();
        }

        private static void PassAndReceiveArrays()
        {
            int[] intArray = { 1, 5, 7, 3, 89 };
            PrintArray(intArray);
            string[] strArray = GetStringArray();
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }

        private static string[] GetStringArray()
        {
            string[] strArray = new string[] { "one", "two", "three" };
            return strArray;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine("Element {0} is {1}", i, array[i]);
        }
        private static void JuggetMultidimensionalArray()
        {
            int[][] jagArray = new int[5][];
            for (int i = 0; i < jagArray.Length; i++)
            {
                jagArray[i] = new int[i + 7];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < jagArray[i].Length; j++)
                {
                    Console.Write(jagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void RectMultidimensionalArray()
        {
            int[,] myArray = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myArray[i, j] = i * j;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}\t", myArray[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }

        private static void ArrayOfObjects()
        {
            object[] obj = { 1, "string", 2.3, false, DateTime.Now };
            foreach (object item in obj)
            {
                Console.WriteLine("Type: {0}, Value: {1}", item.GetType(), item);
            }
            Console.WriteLine();
        }

        private static void DeclareImplicedArrays()
        {
            var a = new[] { 1, 3, 7, 8 };
            Console.WriteLine("a is: {0}", a.ToString());
            var b = new[] { 1, 2.3, 4.5 };
            Console.WriteLine("b is: {0}", b.ToString());
            var c = new[] { "ham", "sosusege", "meat" };
            Console.WriteLine("c is: {0}", c.ToString());
            Console.WriteLine();
        }

        private static void ArrayInitialisation()
        {
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);
            bool[] boolArray = { true, false };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);
            int[] intArray = new int[3] { 34, 56, 1 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        private static void SimpleArrays()
        {
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
                Console.WriteLine(i);

            string[] myStrings = new string[100];
            Console.WriteLine();
        }
    }
}
