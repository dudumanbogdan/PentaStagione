using PentaStagione.Infrastructure.Domain;
using System;

namespace PentaStagione.Domain
{
    public class PizzaIngredient : IEntity
    {
        public string Id { get; }

        public PizzaIngredient()
        {
        }

        public PizzaIngredient(string name)
        {
            Id = name;
        }

        public bool Equals(PizzaIngredient other)
        {
            return Id == other.Id;
        }
    }
}