using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class PeopleCollection : IEnumerable
    {
        private ArrayList peopleArray = new ArrayList();

        public Person this[int index]
        {
            get { return (Person)peopleArray[index]; }
            set { peopleArray.Insert(index, value); }
        }

        public int Count
        {
            get { return peopleArray.Count; }
        }

        public Person GetPerson(int index)
        {
            return (Person)peopleArray[index];
        }
        public void AddPerson(Person p)
        {
            peopleArray.Add(p);
        }
        public void ClearPeople()
        {
            peopleArray.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return peopleArray.GetEnumerator();
        }
    }
}
