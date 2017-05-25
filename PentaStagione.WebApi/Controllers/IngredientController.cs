using PentaStagione.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PentaStagione.WebApi.Controllers
{
    [RoutePrefix("api/pizza/ingredients")]
    public class IngredientController : ApiController
    {
        private readonly IIngredientService _ingredientsService;

        public IngredientController(IIngredientService ingredientsService)
        {
            _ingredientsService = ingredientsService;
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
        public void Post(dynamic ingredient)
        {
            _ingredientsService.Save(ingredient);
        }
    }
}
