using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    static class VeryComplexQueryExpression
    {
        public static bool Filter(string game)
        {
            return game.Contains(" ");
        }
        public static string ProccesItem(string game)
        {
            return game;
        }
        public static void QueryStringsWithRawDelegates()
        {
            Console.WriteLine("**** Using Raw Delegates ****");
            string[] games = { "Fallout 2", "Morrowing", "The Long Dark", "Dirt 2" };
            Func<string, bool> SearchFilter = new Func<string, bool>(Filter);
            Func<string, string> ItemToProcces = new Func<string, string>(ProccesItem);
            var subset = games.Where(SearchFilter).OrderBy(ItemToProcces).Select(ItemToProcces);
            foreach (string game in subset)
                Console.WriteLine(game);
            Console.WriteLine();
        }
    }
}
