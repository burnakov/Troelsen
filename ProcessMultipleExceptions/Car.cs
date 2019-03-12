using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Car
    {
        public const int MaxSpeed = 100;
        private bool carIsDead;
        private Radio theMusicBox = new Radio();

        public string PetName { get; set; }
        public int CurrSpeed { get; set; }

        public Car()
        {

        }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrSpeed = speed;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "Speed must be greter then zero");

            if(carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrSpeed += delta;
                if (CurrSpeed > MaxSpeed)
                {
                    carIsDead = true;
                    CurrSpeed = 0;
                    CarIsDeadException cEx = new CarIsDeadException(String.Format("{0} has overheated", PetName), "Rules ignorance", DateTime.Now);
                    cEx.HelpLink = "www.google.com";
                    throw cEx;
                }
                else
                    Console.WriteLine("=> Current speed is: {0}", CurrSpeed);
            }
        }
    }
}
