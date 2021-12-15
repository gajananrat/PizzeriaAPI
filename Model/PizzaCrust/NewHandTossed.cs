using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model.PizzaCrust
{
    public class NewHandTossed : IPizzaCrust
    {
        public decimal getCost()
        {
            return 120.00M;
        }
    }
}
