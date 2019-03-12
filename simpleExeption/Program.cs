using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Simple exeption ****");
            Car myCar = new Car("Nick", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("\n*** Error ***");
                Console.WriteLine("Member: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Messsage: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Help link: {0}", e.HelpLink);
                Console.WriteLine("\nCustom data:");
                if (e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("=> {0} : {1}", de.Key, de.Value);
                }
            }
            Console.WriteLine("\n*** Out of exception logic ***");
            Console.ReadLine();
        }
    }
}
