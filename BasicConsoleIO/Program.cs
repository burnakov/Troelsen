using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("*** Basic console IO ***");
            //GetUserData();
            //FormatNumericalData();
            DisplayMessage();
            Console.ReadLine();
        }

        private static void DisplayMessage()
        {
            string userMessage = String.Format("10000 in hex is: {0:X}", 10000);
            System.Windows.MessageBox.Show(userMessage);
        }

        private static void GetUserData()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            ConsoleColor prevConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your name is: {0}, and age is: {1}.", userName, userAge);
            Console.ForegroundColor = prevConsoleColor;
        }
        private static void FormatNumericalData()
        {
            Console.WriteLine("Various numerical formats for 99999:");
            Console.WriteLine("C for 99999: {0:C}", 99999);
            Console.WriteLine("c for 99999: {0:c}", 99999);
            Console.WriteLine("D for 99999: {0:D}", 99999);
            Console.WriteLine("d for 99999: {0:d}", 99999);
            Console.WriteLine("D9 for 99999: {0:D9}", 99999);
            Console.WriteLine("d9 for 99999: {0:d9}", 99999);
            Console.WriteLine("F for 99999: {0:F}", 99999);
            Console.WriteLine("f for 99999: {0:f}", 99999);
            Console.WriteLine("F3 for 99999: {0:F3}", 99999);
            Console.WriteLine("f3 for 99999: {0:f3}", 99999);
            Console.WriteLine("N for 99999: {0:N}", 99999);
            Console.WriteLine("n for 99999: {0:n}", 99999);
            Console.WriteLine("E for 99999: {0:E}", 99999);
            Console.WriteLine("e for 99999: {0:e}", 99999);
            Console.WriteLine("X for 99999: {0:X}", 99999);
            Console.WriteLine("x for 99999: {0:x}", 99999);
        }
    }
}
