using System;
using PentaStagione.Infrastructure.Domain;

namespace PentaStagione.Domain
{
    public class PizzaIngredient : IEntity
    {
        public PizzaIngredient()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; }

        public string Name { get; set; }
    }
}