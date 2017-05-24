using System;
using PentaStagione.Domain;

namespace PentaStagione.Repository.Contracts.ReadModel
{
    public interface IPizzaIngredientReadRepository
    {
        PizzaIngredient Get(Guid pizzaId);

    }
}
