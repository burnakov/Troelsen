using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Car
    {
        private bool carIsDead;

        public string PetName { get; set; }
        public int CurrSpeed { get; set; }
        public int MaxSpeed { get; set; }

        public Car()
        {
            MaxSpeed = 100;
        }
        public Car(string name, int currSpeed, int maxSpeed)
        {
            PetName = name;
            CurrSpeed = currSpeed;
            MaxSpeed = maxSpeed;
        }

        public delegate void CarEngineHandler(string msgForCaller);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Exploded != null)
                    Exploded("Sorry, the car is dead...");
            }
            else
            {
                CurrSpeed += delta;
                if ((MaxSpeed - CurrSpeed) == 10 && AboutToBlow != null)
                    AboutToBlow("Carefull, car is gonna blow");
                if (CurrSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("Current speed: {0}", CurrSpeed);
            }
        }
    }
}
