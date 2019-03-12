using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Car : IComparable
    {
        public const int MaxSpeed = 100;
        private bool carIsDead;
        private Radio theMusicBox = new Radio();

        public string PetName { get; set; }
        public int CurrSpeed { get; set; }
        public int CarID { get; set; }
        public static IComparer SortByPetName
        {
            get { return (IComparer)new PetNameComparer(); }
        }

        public Car()
        {

        }
        public Car(string name, int speed, int carID)
        {
            PetName = name;
            CurrSpeed = speed;
            CarID = carID;
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

        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (obj != null)
            {
                if (this.CarID > temp.CarID)
                    return 1;
                if (this.CarID < temp.CarID)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Parameter is not a Car");

            /*
             * Car temp = obj as Car;
             * if (temp != null)
             *      return temp.CarID.ComareTo(obj.CarID);
             * else
             *      throw new ArgumentException("Parameter is not a Car");
             */
        }
    }
}
 