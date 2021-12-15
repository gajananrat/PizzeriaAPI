using PizzeriaAPI.Model.PizzaCrust;
using PizzeriaAPI.Model.PizzaSize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model
{    
    public class FarmhousePizza : AbstractPizza
    {
        public override string getName()
        {
            return "Farmhouse Pizza";
        }

        public override string getDescription()
        {
            return "This is description for FarmhousePizza";
        }
        public override decimal getBasePrice()
        {
            return 100.00M;
        }
        public override IPizzaCrust FinalizaPizzaCrust(PizzaCrustEnum pizzaCrustEnum)
        {
            switch (pizzaCrustEnum)
            {
                case PizzaCrustEnum.NewHandTossed:
                    return new NewHandTossed();
                case PizzaCrustEnum.WheatThinCrust:
                    return new WheatThinCrust();
                case PizzaCrustEnum.CheeseBurst:
                    return new CheeseBurst();
                case PizzaCrustEnum.FreshPanPizza:
                    return new FreshPanPizza();
                case PizzaCrustEnum.ClassicHandTossed:
                    return new ClassicHandTossed();
                default:
                    return null;
            }
        }

        public override IPizzaSize FinalizaPizzaSize(PizzaSizeEnum pizzaSizeEnum)
        {
            switch (pizzaSizeEnum)
            {                
                case PizzaSizeEnum.Regular:
                    return new Regular();
                case PizzaSizeEnum.Medium:
                    return new Medium();
                case PizzaSizeEnum.Large:
                    return new Large();
                default:
                    return null;
            }
        }
        
        public override decimal getPrice(PizzaCrustEnum pizzaCrustEnum, PizzaSizeEnum pizzaSizeEnum)
        {
            return getBasePrice() + FinalizaPizzaCrust(pizzaCrustEnum).getCost() + FinalizaPizzaSize(pizzaSizeEnum).getCost();
        }
    }
}
