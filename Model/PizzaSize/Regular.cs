using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model.PizzaSize
{
    public class Regular : IPizzaSize
    {
        public decimal getCost()
        {
            return 100.00M;
        }
    }
}
