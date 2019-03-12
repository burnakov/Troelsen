using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class SortPeopleByAge : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person x, Person y)
        {
            if (x.Age > y.Age)
                return 1;
            if (x.Age < y.Age)
                return -1;
            else
                return 0;
        }
    }
}
