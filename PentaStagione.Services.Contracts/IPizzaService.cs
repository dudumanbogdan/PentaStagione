using PentaStagione.Repository.Contracts;

namespace PentaStagione.Services.Contracts
{
    public interface IPizzaService
    {
        void Save(object pizza);

        PizzaReadDTO GetById(string pizzaId)
    }
}