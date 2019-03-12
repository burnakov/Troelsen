using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager()
        { }

        public Manager(string name, int age, int id, float pay, int stockOpts) : base(name, age, id, pay)
        {
            StockOptions = stockOpts;
        }

        public override void GiveBonus(float bonus)
        {
            base.GiveBonus(bonus);
            Random r = new Random();
            StockOptions = r.Next(500);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Stock options: {0}", StockOptions);
        }
    }
}
