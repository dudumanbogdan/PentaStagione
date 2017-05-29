using PentaStagione.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaStagione.Repository.Contracts
{
    public class PizzaDTO
    {
        public string Name { get; set; }

        public IEnumerable<PizzaIngredient> Ingredients { get; set; }
    }
}
