using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Multiple exceptions ****");
            Car myCar = new Car("BMW", 70);
            myCar.CrankTunes(true);
            try
            {
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadException e)
            {
                try
                {
                    Console.WriteLine(e.Message);
                    FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
                }
                catch (Exception e2)
                {
                    throw new CarIsDeadException(e.Message, e2);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.CrankTunes(false);
            }
            Console.ReadLine();
        }
    }
}
