using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkRetValues
{
    class LINQBaseFieldsAreClunky
    {
        private static string[] games = { "Fallout 2", "Morrowind", "Dexer", "The Long Dark", "The Witcher 3" };
        private IEnumerable<string> subset = from g in games where g.Contains(" ") orderby g select g;

        public void PrintGames()
        {
            foreach(string game in subset)
                Console.WriteLine("Item: {0}", game);
        }
    }
}
