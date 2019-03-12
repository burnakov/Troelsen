﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Mick", 55);
            carArray[2] = new Car("Peter", 80);
            carArray[3] = new Car("Jack", 28);
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}
