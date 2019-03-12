using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person("Kevin", "Right", 82),
                new Person("Ray", "Burns", 32)
            };
            people.CollectionChanged += people_CollectionChanged;
            people.Add(new Person("Mike", "Nillsen", 43));
            people.RemoveAt(0);

            Console.ReadLine();
        }
        
        private static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Action for this event: {0}", e.Action);
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the old items:");
                foreach (Person p in e.OldItems)
                    Console.WriteLine(p.ToString());
                Console.WriteLine();
            }
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the new items:");
                foreach (Person p in e.NewItems)
                    Console.WriteLine(p.ToString());
                Console.WriteLine();
            }
        }
    }
}
