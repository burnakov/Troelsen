using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
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
            if(carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrSpeed += delta;
                if (CurrSpeed > MaxSpeed)
                {
                    carIsDead = true;
                    CurrSpeed = 0;
                    Exception ex = new Exception(String.Format("{0} has overheated...", PetName));
                    ex.HelpLink = "www.google.com";
                    ex.Data.Add("TimeStamp", String.Format("The car exploded at: {0}", DateTime.Now));
                    ex.Data.Add("Cause", "Rules ignorance");
                    throw ex;
                }
                else
                    Console.WriteLine("=> Current speed is: {0}", CurrSpeed);
            }
        }
    }
}
