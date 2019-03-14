using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** LINQ Transformations ****");
            IEnumerable<string> subset = GetStringSubset();
            foreach (string color in subset)
                Console.WriteLine("Color: {0}", color);
            Console.WriteLine();

            foreach (string color in GetStringSubsetAsArray())
                Console.WriteLine("Color: {0}", color);
            Console.WriteLine();

            Console.ReadLine();
        }

        private static IEnumerable<string> GetStringSubsetAsArray()
        {
            string[] colors = { "Red", "Green", "Light Red", "Yellow", "Black", "Dark Red" };
            var subset = from c in colors where c.Contains("Red") select c;
            return subset.ToArray();
        }

        private static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Red", "Green", "Yellow", "Dark red", "Black", "Light red" };
            IEnumerable<string> redColors = from c in colors where c.Contains("red") select c;
            return redColors;
        }
    }
}
