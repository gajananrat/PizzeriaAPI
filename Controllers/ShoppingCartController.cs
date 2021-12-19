using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzeriaAPI.Data;
using PizzeriaAPI.Model;
using PizzeriaAPI.Model;
using PizzeriaAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzeriaAPI.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingCartController : ControllerBase
    {

        private readonly IPizzaRepository _pizzaRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPizzaRepository pizzaRepository,
            ShoppingCart shoppingCart, AppDbContext context)
        {
            _pizzaRepository = pizzaRepository;
            _shoppingCart = shoppingCart;
        }
        

        [HttpGet]
        public async Task<ShoppingCartModel> Get()
        {
            var items =  await _shoppingCart.GetShoppingCartItemsAsync();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartModel = new ShoppingCartModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return shoppingCartModel;
        }

        [HttpPost]
        public async void AddToShoppingCart([FromQuery]int pizzaId)
        {
            var selectedPizza = await _pizzaRepository.GetByIdAsync(pizzaId);

            if (selectedPizza != null)
            {
                await _shoppingCart.AddToCartAsync(selectedPizza, 1);
            }
        }

        [HttpDelete]
        public async void RemoveFromShoppingCart(int pizzaId)
        {
            var selectedPizza = await _pizzaRepository.GetByIdAsync(pizzaId);

            if (selectedPizza != null)
            {
                await _shoppingCart.RemoveFromCartAsync(selectedPizza);
            }

        }

        [HttpPut]
        public async void ClearCart()
        {
            await _shoppingCart.ClearCartAsync();

        }

    }
}
