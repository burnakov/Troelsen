using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Car
    {
        public int CurrSpeed { get; set; }
        public string PetName { get; set; }

        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrSpeed = speed;
        }

        public override string ToString()
        {
            return string.Format("{0} is going {1} KPH", PetName, CurrSpeed);
        }
    }
}
