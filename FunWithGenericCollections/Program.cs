using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseGenericList();
            //UseGenericStack();
            //UseGenericQueue();
            UseGenericSortedSet();

            Console.ReadLine();
        }
        static void UseGenericList()
        {
            List<Person> simpsons = new List<Person>
            {
                new Person("Homer", "Simpson", 40),
                new Person("Marge", "Simpsons", 30),
                new Person("Bart", "Simpson", 8),
                new Person("Lisa", "Simpson", 7)
            };
            Console.WriteLine("Items in list: {0}", simpsons.Count);
            foreach(Person p in simpsons)
                Console.WriteLine(p);
            Console.WriteLine("\nInserting new person");
            simpsons.Add(new Person("Maggie", "Simpson", 2));
            simpsons.Insert(2, new Person("Abe", "Simpson", 80));
            Console.WriteLine("Items in list: {0}", simpsons.Count);
            Person[] arrSimpsons = simpsons.ToArray();
            for(int i=0;i<arrSimpsons.Length; i++)
                Console.WriteLine("First name: {0}", arrSimpsons[i].FirstName);
        }
        static void UseGenericStack()
        {
            Stack<Person> people = new Stack<Person>();
            people.Push(new Person("Homer", "Simpson", 40));
            people.Push(new Person("Marge", "Simpson", 38));
            people.Push(new Person("Bart", "Simpson", 8));

            Console.WriteLine("First person: {0}", people.Peek());
            Console.WriteLine("Poped off {0}\n", people.Pop());
            Console.WriteLine("First person: {0}", people.Peek());
            Console.WriteLine("Poped off: {0}\n", people.Pop());
            Console.WriteLine("First person: {0}", people.Peek());
            Console.WriteLine("Poped off: {0}\n", people.Pop());

            try
            {
                Console.WriteLine("First person: {0}", people.Peek());
                Console.WriteLine("Poped off: {0}", people.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }
        }
        static void UseGenericQueue()
        {
            Queue<Person> people = new Queue<Person>();
            people.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 40 });
            people.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 38 });
            people.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 7 });

            Console.WriteLine("{0} is first in line", people.Peek().FirstName);
            GetCoffe(people.Dequeue());
            GetCoffe(people.Dequeue());
            GetCoffe(people.Dequeue());

            try
            {
                GetCoffe(people.Dequeue());
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine("\nError! {0}", ex.Message);
            }
        }
        static void UseGenericSortedSet()
        {
            SortedSet<Person> people = new SortedSet<Person> (new SortPeopleByAge())
            {
                new Person("Homer", "Simpason", 40),
                new Person("Maggie", "Simpson", 2),
                new Person("Lisa", "Simpson", 7)
            };
            foreach (Person p in people)
                Console.WriteLine(p);
            Console.WriteLine();

            people.Add(new Person("Abe", "Simpson", 80));
            people.Add(new Person("Bart", "Simpson", 8));
            foreach(Person p in people)
                Console.WriteLine(p);
        }
        static void GetCoffe(Person p)
        {
            Console.WriteLine("{0} got his coffe.", p.FirstName);
        }
    }
}
