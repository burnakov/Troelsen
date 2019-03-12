using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegateMethodGroupConversion
{
    class Car
    {
        private bool carIsDead;
        private CarEngineHandler listOfHandlers;

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
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            if (listOfHandlers == null)
                listOfHandlers = methodToCall;
            else
                listOfHandlers = (CarEngineHandler)Delegate.Combine(listOfHandlers, methodToCall);
            // OR
            //listOfHandlers += methodToCall;
        }
        public void UnRegisterWithCarEngine(CarEngineHandler methodToDelete)
        {
            listOfHandlers -= methodToDelete;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, the car is dead...");
            }
            else
            {
                CurrSpeed += delta;
                if ((MaxSpeed - CurrSpeed) == 10 && listOfHandlers != null)
                    listOfHandlers("Carefull, car is gonna blow");
                if (CurrSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("Current speed: {0}", CurrSpeed);
            }
        }
    }
}
