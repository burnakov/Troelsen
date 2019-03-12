using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("**** Refernce and value types in params ****");
            //Console.WriteLine("=> Passing person by value");
            //Person fred = new Person("Fred", 12);
            //Console.WriteLine("Before by val call person is:");
            //fred.Display();
            //SendAPersonByValue(fred);
            //Console.WriteLine("After by val call person is:");
            //fred.Display();

            Console.WriteLine("=> Using out parameter:");
            int i;
            SendUsingOut(out i); // Must be assigned in called method

            Console.WriteLine("=> Using ref parameter:");
            int j;
            j = 1;
            SendUsingRef(ref j); // int must be assigned befor using

            Console.WriteLine("=> Passing person by ref");
            Person nick = new Person("Nick", 76);
            Console.WriteLine("Before by vref call person is:");
            nick.Display();
            SendAPersonByReference(ref nick); // nick must be assigned befor using
            Console.WriteLine("After by ref call person is:");
            nick.Display();

            Console.WriteLine("=> Passing person with out parameter:");
            Person jack;
            SendAPersonByOut(out jack); // jack must be assigned in called method
            jack.Display();
            Console.ReadLine();
        }

        private static void SendUsingRef(ref int i)
        {
            // Some code...
        }

        private static void SendUsingOut(out int i)
        {
            i = 1; // Must be aasigned befor leaving
        }

        private static void SendAPersonByOut(out Person p)
        {
            p = new Person("Nikky", 999); // Must be aasigned befor leaving
        }
        private static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 555;
            p = new Person("Nikky", 999);
        }

        private static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;
            p = new Person("Nikky", 32);
        }
    }
    class Person
    {
        public string personName;
        public int personAge;
        public Person()
        {

        }
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }
}
