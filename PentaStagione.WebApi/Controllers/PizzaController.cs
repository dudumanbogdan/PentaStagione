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
        public dynamic Get(string id)
        {
            return null;
        }

        [HttpGet]
        public dynamic Get()
        {
            return null;
        }

        //localhost:49900/api/pizza?id=EEED800C-9E0B-460D-8444-9A627497E51C
        //{ "Name": "new pizza", "Ingredients":[{"Id":"111111","Name":"sare"}, {"Id":"2222222","Name":"piper"}]}
        [HttpPost]
        public void Post([FromUri]string id, [FromBody]PizzaDto pizza)
        {
            _pizzaService.Save(pizza);
        }
    }
}