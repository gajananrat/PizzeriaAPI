using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Converters;
using PizzeriaAPI.Model;
using PizzeriaAPI.Model.Sides;
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
    public class ExtrasController : ControllerBase
    {
        // GET: api/<BestSellerPizzasController>
        [HttpGet("/SidesItem")]
        //[EnableCors("AllowOrigin")]
        public IEnumerable<SidesItem> GetPizzaSize()
        {
            return new List<SidesItem>
            {
                new SidesItem(){ ID = Guid.NewGuid(), Name = "Garlic Bread", Description = "This is description for Garlic Bread", Price = 120.000M },
                new SidesItem(){ ID = Guid.NewGuid(), Name = "Veg Pasta Italiano White", Description = "Penne Pasta tossed with extra virgin olive oil, exotic herbs & a generous helping of new flavoured sauce.", Price = 240.000M },
                new SidesItem(){ ID = Guid.NewGuid(), Name = "Cheese Jalapeno Dip", Description = "A soft creamy cheese dip spiced with jalapeno.", Price = 90.000M },
                new SidesItem(){ ID = Guid.NewGuid(), Name = "Cheese Dip", Description = "A dreamy creamy cheese dip to add that extra tang to your snack.", Price = 50.000M },
                new SidesItem(){ ID = Guid.NewGuid(), Name = "Lava Cake", Description = "Filled with delecious molten chocolate inside.", Price = 150.000M }
            };
        }                
    }
}
