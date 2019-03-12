using System;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //LocalVarDeclarations();
            //NewingDataTypes();
            //ObjectFunctionality();
            DataTypeFunctionality();
            //CharFuntionality();
            //ParseFromStrings();
            //UseDatesAndTimes();
            //UseBigInteger();
            Console.ReadLine();
        }

        private static void UseBigInteger()
        {
            Console.WriteLine("=> BigInteger using:");
            BigInteger bigInt = BigInteger.Parse("999999999999999999999999999999");
            Console.WriteLine("Value of bI: {0}", bigInt);
            Console.WriteLine("Is bI an even number: {0}", bigInt.IsEven);
            Console.WriteLine("Is bI a power of 2: {0}", bigInt.IsPowerOfTwo);
            BigInteger veryBigInt = BigInteger.Multiply(bigInt, BigInteger.Parse("77777777777777777777777777777777777"));
            Console.WriteLine("The value of veryBigInt: {0}", veryBigInt);
            BigInteger anotherBigInt = bigInt * veryBigInt;
            Console.WriteLine("Another BigInteger: {0}", anotherBigInt);
            Console.WriteLine();
        }

        private static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and times:");
            DateTime dt = new DateTime(2019, 10, 1);
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(15, 20, 34);
            Console.WriteLine(ts);
            Console.WriteLine("Substract 17 minutes: {0}", ts.Subtract(new TimeSpan(0, 17, 0)));
        }

        private static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884", CultureInfo.InvariantCulture);
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Value of v: {0}", c);
            Console.WriteLine();
        }

        private static void CharFuntionality()
        {
            Console.WriteLine("=> Char type functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace(\"Hello there\", 5): {0}", char.IsWhiteSpace("Hello there", 5));
            Console.WriteLine("char.IsWhiteSpace(\"Hello there\", 6): {0}", char.IsWhiteSpace("Hello there", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        private static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Min of float: {0}", float.MinValue);
            Console.WriteLine("Max of float: {0}", float.MaxValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min if double: {0}", double.MinValue);
            Console.WriteLine("Epsilon of double: {0}:", double.Epsilon);
            Console.WriteLine("Positive infinity of double: {0}", double.PositiveInfinity);
            Console.WriteLine("Negative infinity of double: {0}", double.NegativeInfinity);
            Console.WriteLine("Bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine("Bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine();
        }

        private static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object funtionality:");
            Console.WriteLine("12.GetHashCode(): {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23): {0}", 12.Equals(23));
            Console.WriteLine("12.ToString(): {0}", 12.ToString());
            Console.WriteLine("12.GetType(): {0}", 12.GetType());
            Console.WriteLine();
        }

        private static void NewingDataTypes()
        {
            Console.WriteLine("=> Creating variables using new:");
            bool b = new bool();
            short s = new Int16();
            System.Int32 i = new Int32();
            System.Double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0} {1} {2} {3} {4}", b, i, d, dt, s);
            Console.WriteLine();
        }

        private static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data declarations:");

            int myInt = 5;
            string myString;
            myString = "This is my string.";
            bool b1 = true, b2 = false, b3 = b1;
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }
    }
}
