using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Anonymous Methods ****");

            int aboutToBlowCounter = 0;
            Car myCar = new Car("Slug bug", 10, 100);

            myCar.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Going to fast!");
            };
            myCar.AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine("Message from Car: {0}", e.msg);
            };
            myCar.Exploded += delegate (object sender, CarEventArgs e)
            {
                Console.WriteLine("Fatal message from Car: {0}", e.msg);
            };

            for (int i = 0; i < 6; i++)
            {
                myCar.Accelerate(20);
            }

            Console.WriteLine("AboutToBlow Event fired {0} times", aboutToBlowCounter);
            Console.ReadLine();
        }
    }
}
