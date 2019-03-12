using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        private string empName;
        private int empAge;
        private int empID;
        private float currPay;

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

        public Employee()
        { }

        public Employee(string name, int id, float pay) : this(name, 0, id, pay)
        { }

        public Employee(string name, int age, int id, float pay)
        {
            EmpName = name;
            EmpAge = age;
            EmpID = id;
            CurrPay = pay;
        }

        public void GiveBonus(float bonus)
        {
            CurrPay += bonus;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", EmpName);
            Console.WriteLine("Age: {0}", EmpAge);
            Console.WriteLine("ID: {0}", EmpID);
            Console.WriteLine("Pay: {0}", CurrPay);
        }
    }
}
