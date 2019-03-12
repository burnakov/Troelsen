using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public override string ToString()
        {
            string state;
            state = String.Format("[FirstName: {0}, LastName: {1}, Age: {2}]", FirstName, LastName, Age);
            return state;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person && obj != null)
            {
                Person tmp = (Person)obj;
                if (tmp.FirstName == this.FirstName && tmp.LastName == this.LastName && tmp.Age == this.Age)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
