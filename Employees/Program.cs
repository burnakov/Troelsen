using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Yhe employee class hierarchy ****");
            SalesPerson fred = new SalesPerson();
            fred.EmpName = "Fred";
            fred.EmpAge = 32;
            fred.SalesNumber = 210;
            fred.CurrPay = 100;
            fred.GiveBonus(1000);
            fred.DisplayStatus();
            Console.WriteLine();

            Manager chuky = new Manager("Chuky", 42, 10010, 30000, 52);
            Console.WriteLine("Benefit: {0}", chuky.GetBenefitCost().ToString());
            chuky.GiveBonus(300);
            chuky.DisplayStatus();
            Console.WriteLine();

            Console.ReadLine();
        }
        static void CastingExamples()
        {
            object frank = new Manager("Frank", 93, 12, 34.3f, 18);
            Employee kurt = new Manager("Kurt", 23, 1, 13, 8);
            GivePromotion(kurt);
            SalesPerson nick = new PTSalesPerson("Nick", 45, 15, 18, 29);
            GivePromotion(nick);
            GivePromotion((Manager)frank);
            PTSalesPerson pt = frank as PTSalesPerson;
            if(pt == null)
            {
                Console.WriteLine("Frank is not a sales manager");
            }
        }
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("Employee {0} was promoted", emp);
            if(emp is SalesPerson)
            {
                Console.WriteLine("{0} has {1} sales\n", emp.EmpName, ((SalesPerson)emp).SalesNumber);
            }
            else
            {
                if(emp is Manager)
                {
                    Console.WriteLine("{0} has {1} optiopns\n", emp.EmpName, ((Manager)emp).StockOptions);
                }
            }
        }
    }
}