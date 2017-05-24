using System.Collections.Generic;
using System.Linq;
using PentaStagione.Infrastructure.Domain;
using System;

namespace PentaStagione.Domain
{
    public class Pizza : IAggregateRoot
    {
        private readonly List<PizzaIngredient> _ingredients;

        //TODO: generate a new GUID only once
        public string Id { get; private set; }

        //TODO: display this on the UI
        public string Name { get; set; }

        public IEnumerable<PizzaIngredient> Ingredients => new List<PizzaIngredient>(_ingredients);

        public void AddIngredient(PizzaIngredient ingredient)
        {
            // interception
            _ingredients.Add(ingredient);
        }

        public Pizza(string name )
        {
           Id = Guid.NewGuid().ToString();
           Name = name;
        }
    }
}
