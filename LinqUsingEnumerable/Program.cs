using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Fallout 2", "Morrowing", "The Long Dark", "Dirt 2" };
            QueryStringsWithOperators(games);
            QueryStringsWithEnumerablesAndLambdas(games);
            QueryStringsWithAnonymousMethods(games);
            VeryComplexQueryExpression.QueryStringsWithRawDelegates();

            Console.ReadLine();
        }

        private static void QueryStringsWithAnonymousMethods(string[] games)
        {
            Console.WriteLine("**** Using Anonymous Methods ****");
            Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" "); };
            Func<string, string> itemToProcces = delegate (string game) { return game; };
            var subset = games.Where(searchFilter).OrderBy(itemToProcces).Select(itemToProcces);
            foreach (string game in subset)
                Console.WriteLine(game);
            Console.WriteLine();
        }

        private static void QueryStringsWithEnumerablesAndLambdas(string[] games)
        {
            Console.WriteLine("**** Using enumerable / Lambda expressions ****");
            var subset = games.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);
            foreach (string game in subset)
                Console.WriteLine(game);
            Console.WriteLine();
        }

        private static void QueryStringsWithOperators(string[] games)
        {
            Console.WriteLine("**** Using Query Operators ****");
            var subset = from g in games where g.Contains(" ") orderby g select g;
            foreach (string game in subset)
                Console.WriteLine(game);
            Console.WriteLine();
        }
    }
}
