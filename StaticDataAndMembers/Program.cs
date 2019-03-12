using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with static data ****");
            SavingsAccount s1 = new SavingsAccount(10);
            SavingsAccount s2 = new SavingsAccount(1000);
            Console.WriteLine("Interest rate is {0}\n", SavingsAccount.GetInterestRate());

            SavingsAccount.SetInterestRate(0.08);
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest rate is {0}\n", SavingsAccount.GetInterestRate());
            Console.ReadLine();
        }
    }
}
