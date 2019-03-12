using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;

        public int CurrSpeed
        {
            get { return currSpeed; }
            set
            {
                if (value > maxSpeed)
                    currSpeed = maxSpeed;
                else
                    currSpeed = value;
            }
        }

        public Car()
        {
            maxSpeed = 55;
        }

        public Car(int max)
        {
            maxSpeed = max;
        }
    }
}
