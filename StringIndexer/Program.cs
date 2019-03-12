using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with indexers ****");
            PeopleCollection myPeople = new PeopleCollection();

            myPeople["homer"] = new Person("Homer", "Simpson", 59);
            myPeople["marge"] = new Person("Marge", "Simoson", 49);

            Person homer = myPeople["homer"];
            Console.WriteLine(homer.ToString());

            Console.ReadLine();
        }
    }
}
