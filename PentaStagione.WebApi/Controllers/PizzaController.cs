using System;
using System.Collections.Generic;
using System.Web.Http;
using PentaStagione.Services.Contracts;
using PentaStagione.Services.Contracts.DTOs.PizzaDTOs;

namespace PentaStagione.WebApi.Controllers
{
    [RoutePrefix("api/pizza")]
    public class PizzaController : ApiController
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        [Route("{id}")]
        public PizzaDto Get(Guid id)
        {
            return _pizzaService.Get(id);
        }

        [HttpGet]
        public ICollection<PizzaDto> Get()
        {
            return null;
        }

        [HttpPost]
        public void Post(PizzaDto pizza)
        {
            _pizzaService.Save(pizza);
        }
    }
}