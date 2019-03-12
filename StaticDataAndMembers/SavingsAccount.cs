using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;
        public static double currInterestRate;

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor");
            currInterestRate = 0.04;
        }

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
