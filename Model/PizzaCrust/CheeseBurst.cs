using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model.PizzaCrust
{
    public class CheeseBurst : IPizzaCrust
    {
        public decimal getCost()
        {
            return 180.00M;
        }
    }
}
