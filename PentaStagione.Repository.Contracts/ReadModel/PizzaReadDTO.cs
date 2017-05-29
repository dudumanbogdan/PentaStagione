using PentaStagione.Domain;
using System.Collections.Generic;

namespace PentaStagione.Repository.Contracts
{
    public class PizzaReadDTO
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public IEnumerable<PizzaIngredient> Ingredients { get; set; }
    }
}