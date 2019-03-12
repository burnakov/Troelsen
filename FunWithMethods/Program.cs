using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Methods and parameters:");
            int x = 9, y = 10;
            Console.WriteLine("Befor call: x = {0}, y = {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: x = {0}, y ={1}", x, y);
            Console.WriteLine();
            int ans;
            Add(x, y, out ans);
            Console.WriteLine("Another Add: {0}", ans);
            Console.WriteLine();
            int a;
            string b;
            bool c;
            FillTheseValues(out a, out b, out c);
            Console.WriteLine("a is: {0}", a);
            Console.WriteLine("b is: {0}", b);
            Console.WriteLine("c is: {0}", c);
            Console.WriteLine();
            string s1 = "Flip";
            string s2 = "Flop";
            Console.WriteLine("Before: {0} {1}", s1, s2);
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After: {0} {1}", s1, s2);
            Console.WriteLine();
            double average;
            average = CalculateAverage(3.0, 4.0, 1.0, 3.4);
            Console.WriteLine("Average is: {0}", average);
            double[] paramArr = { 3.2, 5.0, 6.6 };
            average = CalculateAverage(paramArr);
            Console.WriteLine("Average is: {0}", average);
            Console.WriteLine("Average for 0 is: {0}", CalculateAverage());
            Console.WriteLine();
            EnterLogData("I will be the best programmer ever");
            EnterLogData("Yoy will be reach", "Wife");
            Console.WriteLine();
            DisplayFancyMessage(backgroundColor: ConsoleColor.Red, foregroundColor: ConsoleColor.Gray, message: "Hello everyone");
            DisplayFancyMessage(message: "It works too", foregroundColor: ConsoleColor.Yellow, backgroundColor: ConsoleColor.Magenta);
            Console.WriteLine();
            DisplayFancyMessage2(message: "Not test message");
            Console.ReadLine();
        }

        private static void DisplayFancyMessage(ConsoleColor backgroundColor, ConsoleColor foregroundColor, string message)
        {
            ConsoleColor oldBackgroundColor = backgroundColor;
            ConsoleColor oldTextColor = foregroundColor;

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);

            Console.BackgroundColor = oldBackgroundColor;
            Console.ForegroundColor = oldTextColor;
        }
        private static void DisplayFancyMessage2(ConsoleColor backgroundColor = ConsoleColor.Blue, ConsoleColor foregroundColor = ConsoleColor.White, string message = "Test message")
        {
            ConsoleColor oldBackgroundColor = backgroundColor;
            ConsoleColor oldTextColor = foregroundColor;

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);

            Console.BackgroundColor = oldBackgroundColor;
            Console.ForegroundColor = oldTextColor;
        }

        private static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Statment: {0}", message);
            Console.WriteLine("Owner: {0}", owner);
        }

        private static double CalculateAverage(params double[] array)
        {
            Console.WriteLine("You sent me {0} params", array.Length);
            double summ = 0;
            if (array.Length == 0)
            {
                return summ;
            }
            foreach (double param in array)
            {
                summ += param;
            }
            return (summ / array.Length);
        }

        private static void SwapStrings(ref string s1, ref string s2)
        {
            string tmp = s1;
            s1 = s2;
            s2 = tmp;
        }

        private static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 20;
            b = "Again";
            c = false;
        }

        private static int Add(int x, int y) // Parameters by value
        {
            int answer = x + y;
            x = 5000;
            y = 8000;
            return answer;
        }
        private static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
    }
}
