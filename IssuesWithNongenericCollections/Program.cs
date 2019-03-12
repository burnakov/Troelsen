using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Custom Person Collection ****");
            PeopleCollection myPeople = new PeopleCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Bart", "Simpson", 8));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            foreach(Person p in myPeople)
                Console.WriteLine(p);

            Console.ReadLine();
        }
        static void SimpleBoxUnboxOperation()
        {
            int myInt = 1;
            object boxedInt = myInt;
            int unboxedInt = (int)boxedInt;
            try
            {
                long failedUnbox = (long)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(67);
            myInts.Add(88); // Boxing

            int myInt = (int)myInts[2]; // Uboxing
            Console.WriteLine("The value {0}", myInt); // Boxing. WriteLine method works with objects
        }
        static void ArrayListWithRandomObjects()
        {
            ArrayList myObjects = new ArrayList();
            myObjects.Add(true);
            myObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version()));
            myObjects.Add(92);
            myObjects.Add(3.14);
        }
        static void UseGenericList()
        {
            Console.WriteLine("**** Fun with generics ****");
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Jack", "Black", 50));
            Console.WriteLine(morePeople[0]);

            List<int> myInts = new List<int>();
            myInts.Add(10);
            myInts.Add(8);
            int sum = myInts[0] + myInts[1];
        }
    }
}
