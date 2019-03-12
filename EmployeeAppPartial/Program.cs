using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAppPartial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with encapsulation ****");
            Employee emp = new Employee("Marvin", 456, 100);
            emp.GiveBonus(30000);
            emp.DisplayStatus();
            Console.WriteLine();

            Employee jay = new Employee();
            jay.EmpAge++;
            jay.DisplayStatus();
            Console.WriteLine();

            emp.EmpName = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.EmpName);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
