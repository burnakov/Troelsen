using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Iterations and conditions:");
            //ForLoopExample();
            //ForeachLoopExample();
            //WhileLoopExample();
            //DoWhileLoopExamlpe();
            //IfElseExample();
            //SwitchExample();
            SwitchOnEnumExample();
            Console.ReadLine();
        }

        private static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter your favorite day of week:");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Friday rules");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Another great day indeed");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost friday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least not monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Midle of the week");
                    break;
            }
        }

        private static void SwitchExample()
        {
            Console.WriteLine("How many Nirvana songs do you know:");
            int n = int.Parse(Console.ReadLine());
            switch (n > 0)
            {
                case true:
                    Console.WriteLine("Your'e on a long road of excitement");
                    break;
                default:
                    Console.WriteLine("Fuck off you miserable raper!");
                    break;
            }
            Console.WriteLine();
        }

        private static void IfElseExample()
        {
            string myString = "Another string";
            if (myString.Length > 0)
                Console.WriteLine("string is grater then 0 characters.");
            Console.WriteLine();
        }

        private static void DoWhileLoopExamlpe()
        {
            string response = "";
            do
            {
                Console.WriteLine("Is it Enough? [yes] [no]:");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");
            Console.WriteLine();
        }

        private static void WhileLoopExample()
        {
            string response = "";
            while (response.ToLower() != "yes") 
            {
                Console.WriteLine("Is it enough? [yes] [no]: ");
                response = Console.ReadLine();
            }
            Console.WriteLine();
        }

        private static void ForeachLoopExample()
        {
            string[] games = { "Fallout", "The Long Dark", "The Witcher", "Overcooked" };
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            int[] myInts = { 12, 123, 345, 45, 34, 656, 7 };
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        private static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}", i);
            }
            Console.WriteLine();
        }
    }
}
