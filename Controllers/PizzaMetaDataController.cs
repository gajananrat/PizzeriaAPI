using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Converters;
using PizzeriaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace PizzeriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class PizzaMetaDataController : ControllerBase
    {
        // GET: api/<BestSellerPizzasController>
        [HttpGet("/PizzaSize")]
        //[EnableCors("AllowOrigin")]
        public IEnumerable<string> GetPizzaSize()
        {
            return new List<string>
            {
                Convert.ToString(PizzaSizeEnum.Regular),
                Convert.ToString(PizzaSizeEnum.Medium),
                Convert.ToString(PizzaSizeEnum.Large)
            };
        }

        // GET: api/<BestSellerPizzasController>
        [HttpGet("/PizzaCrust")]
        //[EnableCors("AllowOrigin")]
        public IEnumerable<string> GetPizzaCrust()
        {
            return new List<string>
            {
                Convert.ToString(PizzaCrustEnum.ClassicHandTossed),
                Convert.ToString(PizzaCrustEnum.FreshPanPizza),
                Convert.ToString(PizzaCrustEnum.NewHandTossed),
                Convert.ToString(PizzaCrustEnum.WheatThinCrust),
                Convert.ToString(PizzaCrustEnum.CheeseBurst)
            };
        }        
    }
}
