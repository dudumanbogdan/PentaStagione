using PentaStagione.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PentaStagione.WebApi.Controllers
{
    public class HomeController : Controller
    {
        IPizzaService _service;

        public HomeController(IPizzaService service)
        {
            _service = service;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Route("{id}")]
        public ActionResult Details(string id)
        {
            var pizza = _service.GetById(id);

            return View(pizza);
        }
    }
}