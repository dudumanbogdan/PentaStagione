using PentaStagione.Domain;
using System.Collections.Generic;

namespace PentaStagione.Repository.Contracts
{
    public class PizzaReadDTO
    {
        public string Name { get; set; }

        public IEnumerable<PizzaIngredient> Ingredients { get; set; }
    }
}