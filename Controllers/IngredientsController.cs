using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzeriaAPI.Model;
using PizzeriaAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzeriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientsRepository _ingredientsRepository;
        public IngredientsController(IIngredientsRepository ingredientsRepository)
        {
            _ingredientsRepository = ingredientsRepository;
        }
        // GET: api/<IngredientsController>
        [HttpGet]
        public IEnumerable<Ingredients> Get()
        {
            return _ingredientsRepository.GetAll();
        }

        // GET api/<IngredientsController>/5
        [HttpGet("{id}")]
        public Ingredients Get(int id)
        {
            return _ingredientsRepository.GetById(id);
        }
    }
}
