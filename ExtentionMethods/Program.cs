using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with extention methods ****");
            int myInt = 123456789;
            myInt.DisplayDefiningAssembley();

            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembley();

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembley();

            Console.WriteLine("Value of myInt: {0}", myInt.ToString());
            Console.WriteLine("Reversed digits of my int: {0}", myInt.ReverseDigits());

            Console.ReadLine();
        }
    }
}
