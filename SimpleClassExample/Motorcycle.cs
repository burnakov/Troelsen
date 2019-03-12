using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntencity;
        public string driverName;

        public Motorcycle()
        {
            Console.WriteLine("In default ctor");
        }

        public Motorcycle(string name) : this(name, 0)
        {
            Console.WriteLine("In ctor taking a string");
        }

        public Motorcycle(int intencity) : this("", intencity)
        {
            Console.WriteLine("in ctor taking an int");
        }

        public Motorcycle(string name, int intencity)
        {
            Console.WriteLine("In master ctor");
            driverName = name;
            if (intencity > 10)
            {
                driverIntencity = 10;
            }
            driverIntencity = intencity;
        }

        public void SetDriverName(string name)
        {
            driverName = name;
        }


        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntencity; i++)
            {
                Console.WriteLine("Yeeeeeeeeeee Haaaaaaaaaaeeeew!"); 
            }
        }
    }
}
