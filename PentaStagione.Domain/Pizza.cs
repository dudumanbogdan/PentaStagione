using System.Collections.Generic;
using System.Linq;
using PentaStagione.Infrastructure.Domain;
using System;

namespace PentaStagione.Domain
{
    public class Pizza : IAggregateRoot
    {
        private readonly List<PizzaIngredient> _ingredients;

        public string Id { get; private set; }

        public string Name { get; set; }

        public IEnumerable<PizzaIngredient> Ingredients
        {
            get { return new List<PizzaIngredient>(_ingredients); }
        }

        public Pizza(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException();

            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        public void AddIngredient(PizzaIngredient ingredient)
        {
            if (ingredient == null) throw new ArgumentNullException();

            if (!Ingredients.Contains(ingredient))
                _ingredients.Add(ingredient);
        }

        public Pizza(string name )
        {
           Id = Guid.NewGuid().ToString();
           Name = name;
        }
    }
}
