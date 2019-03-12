using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with type conversions ****");
            short numb1 = 10, numb2 = 5;
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

            short numb3 = 30000, numb4 = 30000;
            short result = (short)Add(numb3, numb4);
            Console.WriteLine("{0} + {1} = {2}", numb3, numb4, result);

            //NarrowingAttempt();
            ProcessBytes();
            Console.ReadLine();
        }

        private static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                checked
                {
                    byte summ = (byte)Add(b1, b2);
                    Console.WriteLine("summ = {0}", summ);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }

        private static void NarrowingAttempt()
        {
            byte myByte = 200;
            int myInt = myByte;
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
            Console.WriteLine();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
