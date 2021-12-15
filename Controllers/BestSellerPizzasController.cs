using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Converters;
using PizzeriaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzeriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class BestSellerPizzasController : ControllerBase
    {
        // GET: api/<BestSellerPizzasController>
        [HttpGet]
        //[EnableCors("AllowOrigin")]
        public IEnumerable<Pizza> Get()
        {
            return new List<Pizza>
            { 
                new Pizza(){ ID = Guid.NewGuid(), Name = "Margherita", Description = "This is new description for Mergherita Pizza" },
                new Pizza(){ ID = Guid.NewGuid(), Name = "FarmHouse", Description = "This is new description for Farmhouse Pizza" }
            };
        }

        
        [HttpGet("/{pizzaName}/{pizzaSize}/{pizzaCrust}")]
        public decimal GetPizzaPrice([FromRoute] string pizzaName, [FromRoute] string pizzaSize, [FromRoute] string pizzaCrust)
        {
            switch (Enum.Parse(typeof(PizzaNameEnum), pizzaName))
            {
                case PizzaNameEnum.Margherita:
                    return new MargheritaPizza().getPrice((PizzaCrustEnum)Enum.Parse(typeof(PizzaCrustEnum), pizzaCrust), (PizzaSizeEnum)Enum.Parse(typeof(PizzaSizeEnum), pizzaSize)); 
                case PizzaNameEnum.FarmHouse:
                    return new FarmhousePizza().getPrice((PizzaCrustEnum) Enum.Parse(typeof(PizzaCrustEnum), pizzaCrust), (PizzaSizeEnum) Enum.Parse(typeof(PizzaSizeEnum), pizzaSize));
                default:
                    return 0.00M;
            }
        }

        //// GET api/<BestSellerPizzasController>/PizzaNameEnum
        //[HttpGet("{PizzaNameEnum}")]
        //public string GetPizzaDescription(PizzaNameEnum pizzaNameEnum)
        //{
        //    switch (pizzaNameEnum)
        //    {
        //        case PizzaNameEnum.Margherita:
        //            return new MargheritaPizza().getDescription();
        //        case PizzaNameEnum.FarmHouse:
        //            return new FarmhousePizza().getDescription();
        //        default:
        //            return null;
        //    }
        //}

        #region notImplemented
        //// POST api/<BestSellerPizzasController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<BestSellerPizzasController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<BestSellerPizzasController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //} 
        #endregion
    }
}
