using System;
using PentaStagione.Domain;
using PentaStagione.Repository.Contracts.ReadModel;

namespace PentaStagione.Repository.ReadModel
{
    public class PizzaIngredientReadRepository : IPizzaIngredientReadRepository
    {
        public PizzaIngredient Get(Guid pizzaId)
        {
            //TODO return ingredient from db
            throw new NotImplementedException();
        }
    }
}
