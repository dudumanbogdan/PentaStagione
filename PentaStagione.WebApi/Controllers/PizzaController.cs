using System.Web.Http;
using PentaStagione.Services.Contracts;

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
        public dynamic Get(string id)
        {
            return null;
        }

        [HttpGet]
        public dynamic Get()
        {
            return null;
        }

        [HttpPost]
        public void Post(dynamic pizza)
        {
            _pizzaService.Save(pizza);
        }
    }
}