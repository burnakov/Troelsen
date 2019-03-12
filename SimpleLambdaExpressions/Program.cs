using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with lambdas ****");
            TraditionalsDelegateSyntax();
            AnonymousMethodSyntax();
            LambdaExpressionSyntax();

            Console.ReadLine();
        }

        private static void LambdaExpressionSyntax()
        {
            List<int> intList = new List<int> { 2, 100, 34, 57, 89, 22 };

            List<int> evenNumbers = intList.FindAll(
                (i) =>
                {
                    Console.WriteLine("The value of i is: {0}", i);
                    bool isEven = ((i % 2) == 0);
                    return isEven;
                });
            //OR
            //List<int> evenNumbers = intList.FindAll(i => (i % 2) == 0);

            Console.WriteLine("3). Here is even numbers:");
            foreach (int i in evenNumbers)
                Console.Write("{0}\t", i);
            Console.WriteLine();
        }

        private static void AnonymousMethodSyntax()
        {
            List<int> intList = new List<int> { 2, 100, 34, 57, 89, 22 };
            List<int> evenNumbers = intList.FindAll(
                delegate (int i)
                {
                    return (i % 2) == 0;
                });

            Console.WriteLine("2). Here is even numbers:");
            foreach (int i in evenNumbers)
                Console.Write("{0}\t", i);
            Console.WriteLine();
        }

        private static void TraditionalsDelegateSyntax()
        {
            List<int> intList = new List<int>();
            intList.AddRange(new int[] { 2, 100, 34, 57, 89, 22 });

            Predicate<int> callback = new Predicate<int>(IsEvenNumber);
            List<int> evenNumbers = intList.FindAll(callback);

            Console.WriteLine("1). Here is even numbers:");
            foreach (int i in evenNumbers)
                Console.Write("{0}\t", i);
            Console.WriteLine();
        }

        private static bool IsEvenNumber(int obj)
        {
            return (obj % 2) == 0;
        }
    }
}
