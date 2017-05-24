using System;
using PentaStagione.Domain;
using PentaStagione.Repository.Contracts.ReadModel;

namespace PentaStagione.Repository.ReadModel
{
    public class PizzaReadRepository : IPizzaReadRepository
    {
        public Pizza Get(Guid pizzaId)
        {
            throw new System.NotImplementedException();
        }
    }
}