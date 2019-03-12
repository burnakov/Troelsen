using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Nullable types ****");
            //LocalNullableVariables();
            DatabaseReader dbr = new DatabaseReader();

            int? i = dbr.GetIntFromDatabase();
            if (i.HasValue)
            {
                Console.WriteLine("Value of \"i\" is {0}", i.Value);
            }
            else
            {
                Console.WriteLine("Value of \"i\" is undefined");
            }

            bool? b = dbr.GetBoolFromDatabase();
            if (b != null)
                Console.WriteLine("Value of \"b\" is {0}", b);
            else
                Console.WriteLine("Value of \"b\" is undefined");

            int myInt = dbr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of \"myInt\" is {0}", myInt);

            int? moreInt = dbr.GetIntFromDatabase();
            if (!moreInt.HasValue)
                moreInt = 100;
            Console.WriteLine("Value of \"moreInt\" is {0}", myInt);
            Console.ReadLine();
        }

        private static void LocalNullableVariables()
        {
            //int? nullableInt = 10;
            //double? nullableDouble = 2.3;
            //bool? nullableBool = true;
            //int?[] arrayOfNullableInts = new int?[10];

            //Nullable<int> nInt = 12;
            //Nullable<double> nDouble = 3.3;
            //Nullable<bool> nBool = false;
            //Nullable<int>[] nArray = new Nullable<int>[10];
            //Nullable<int>[] nArray2 = new int?[10];
        }
    }
    class DatabaseReader
    {
        public int? intValue = null;
        public bool? boolValue = true;

        public int? GetIntFromDatabase()
        {
            return intValue;
        }
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}
