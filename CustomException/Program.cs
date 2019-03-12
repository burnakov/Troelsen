using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with custom exceptions ****");
            Car c = new Car("Test", 90);
            try
            {
                c.Accelerate(50);
            }
            catch (CarIsDeadException ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Cause: {0}", ex.CauseOfError);
                Console.WriteLine("Time: {0}", ex.ErrorTimeStamp);
                Console.WriteLine("Help link: {0}", ex.HelpLink);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
