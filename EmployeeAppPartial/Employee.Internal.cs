using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAppPartial
{
    partial class Employee
    {
        private string empName;
        private int empAge;
        private int empID;
        private float currPay;

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
    }
}
