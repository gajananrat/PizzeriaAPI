using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model.PizzaSize
{
    public class Medium : IPizzaSize
    {
        public decimal getCost()
        {
            return 150.00M;
        }
    }
}
