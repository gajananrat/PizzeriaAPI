using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model.PizzaSize
{
    public class Large : IPizzaSize
    {
        public decimal getCost()
        {
            return 200.00M;
        }
    }
}
