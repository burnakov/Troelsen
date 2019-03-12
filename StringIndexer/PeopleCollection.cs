﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    class PeopleCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        public Person this[string name]
        {
            get { return listPeople[name]; }
            set { listPeople[name] = value; }
        }

        public int Count
        {
            get { return listPeople.Count; }
        }

        public void ClearPeople()
        {
            listPeople.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listPeople.GetEnumerator();
        }
    }
}
