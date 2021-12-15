using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model.PizzaCrust
{
    public class WheatThinCrust : IPizzaCrust
    {
        public decimal getCost()
        {
            return 160.00M;
        }
    }
}
