using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with linq to objects ****");
            QueryOverStrings();
            QueryOverStringsLongHand();
            QueryOverInts();

            Console.ReadLine();
        }
        static void QueryOverInts()
        {
            int[] nums = { 12, 56, 82, 93, 1, 5, 23, 8, 1, 4 };
            var subset = from i in nums where i < 10 select i;
            foreach (var i in subset)
                Console.WriteLine("Item: {0}", i);
            Console.WriteLine();

            nums[0] = 6;
            foreach(var i in subset)
                Console.WriteLine("Item: {0}", i);
            ReflectionOverQueryResults(subset);
            Console.WriteLine();
        }
        static void ReflectionOverQueryResults(object set)
        {
            Console.WriteLine("=> Info about your query");
            Console.WriteLine("Type: {0}", set.GetType().Name);
            Console.WriteLine("Location: {0}", set.GetType().Assembly.GetName().Name);
        }
        private static void QueryOverStringsLongHand()
        {
            string[] games = { "Follout 2", "The Division", "The Long Dark", "Hunter 2", "Daxer", "Morrowind" };
            List<string> subset = new List<string>();
            foreach(string game in games)
            {
                if (game.Contains(" "))
                    subset.Add(game);
            }
            subset.Sort();
            foreach (string game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }

        static void QueryOverStrings()
        {
            string[] games = { "Follout 2", "The Division", "The Long Dark", "Hunter 2", "Daxer", "Morrowind" };
            IEnumerable<string> subset = from g in games where g.Contains(" ") orderby g select g;

            foreach (var item in subset)
                Console.WriteLine("Item: {0}", item);
            ReflectionOverQueryResults(subset);
            Console.WriteLine();
        }
    }
}
