using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string name, int age, int id, float pay, int salesNmb) : base(name, age, id, pay, 5)
        { }
    }
}
