using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with indexers ****");

            PeopleCollection myPeople = new PeopleCollection();
            myPeople[0] = new Person("Homer", "Simpson", 50);
            myPeople[1] = new Person("Marge", "Simpson", 48);
            myPeople[2] = new Person("Bart", "Simpson", 8);
            myPeople[3] = new Person("Lisa", "Simpson", 7);
            myPeople[4] = new Person("Meggie", "Simpson", 3);

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }
            Console.WriteLine();

            UseGenericListOfPeople();
            Console.ReadLine();
        }

        private static void UseGenericListOfPeople()
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Bart", "Simpson", 8));
            myPeople.Add(new Person("Lisa", "Simpson", 7));
            myPeople[0] = new Person("Maggie", "Simpson", 3);

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
