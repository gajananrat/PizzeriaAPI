using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model.PizzaCrust
{
    public class FreshPanPizza : IPizzaCrust
    {
        public decimal getCost()
        {
            return 140.00M;
        }
    }
}
