using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson()
        { }

        public SalesPerson(string name, int age, int id, float pay, int salesNmb) : base(name, age, id, pay)
        {
            SalesNumber = salesNmb;
        }

        public override void GiveBonus(float bonus)
        {
            int salesBonus = 0;
            if (SalesNumber >=0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }
            }
            base.GiveBonus(bonus * salesBonus);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Sales number: {0}", SalesNumber);
        }
    }
}
