using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model.PizzaCrust
{
    public class ClassicHandTossed : IPizzaCrust
    {
        public decimal getCost()
        {
            return 100.00M;
        }
    }
}
