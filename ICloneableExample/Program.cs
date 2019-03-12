using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** A First Look at Interfaces ****");
            string myString = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection SqlCnn = new System.Data.SqlClient.SqlConnection();
            CloneMe(myString);
            CloneMe(unixOS);
            CloneMe(SqlCnn);

            Console.ReadLine();
        }
        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine("The clone is: {0}", theClone.GetType().Name);
        }
    }
}
