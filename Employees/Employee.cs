using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        public string EmpName
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Employee name must be less than 16 characters!");
                else
                    empName = value;
            }
        }

        public int EmpAge
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float CurrPay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public BenefitPackage EmpBenefit
        {
            get { return empBenefit; }
            set { empBenefit = value; }
        }

        public virtual void GiveBonus(float bonus)
        {
            CurrPay += bonus;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", EmpName);
            Console.WriteLine("Age: {0}", EmpAge);
            Console.WriteLine("ID: {0}", EmpID);
            Console.WriteLine("Pay: {0}", CurrPay);
        }

        public double GetBenefitCost()
        {
            return empBenefit.ComputePayDeduction();
        }
    }
}
