using Newtonsoft.Json.Converters;
using PizzeriaAPI.Model.PizzaCrust;
using PizzeriaAPI.Model.PizzaSize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PizzeriaAPI.Model
{
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum PizzaNameEnum
    {
        Margherita, FarmHouse
    }

    //[JsonConverter(typeof(StringEnumConverter))]
    public enum PizzaSizeEnum
    {
        Regular, Medium, Large
    }
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum PizzaCrustEnum
    {
        NewHandTossed, WheatThinCrust, CheeseBurst, FreshPanPizza, ClassicHandTossed
    }

    public abstract class AbstractPizza
    {
        public abstract string getName();
        public abstract string getDescription();
        public abstract decimal getBasePrice();
        public abstract IPizzaSize FinalizaPizzaSize(PizzaSizeEnum pizzaSizeEnum);
        public abstract IPizzaCrust FinalizaPizzaCrust(PizzaCrustEnum pizzaCrustEnum);        
        public abstract decimal getPrice(PizzaCrustEnum pizzaCrustEnum, PizzaSizeEnum pizzaSizeEnum);

    }
}
