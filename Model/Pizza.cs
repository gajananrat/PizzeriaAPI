using PizzeriaAPI.Model;
using System;

namespace PizzeriaAPI.Controllers
{
    public class Pizza
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
}