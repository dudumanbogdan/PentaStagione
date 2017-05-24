using PentaStagione.Domain;
using PentaStagione.Domain.Repository;

namespace PentaStagione.Repository
{
    public class PizzaRepository : IPizzaRepository
    {
        public void Save(Pizza pizzaAggregate)
        {
            //todo save in db
            throw new System.NotImplementedException();
        }
    }
}