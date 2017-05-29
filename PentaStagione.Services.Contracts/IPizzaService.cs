using PentaStagione.Repository.Contracts;
using System.Collections.Generic;

namespace PentaStagione.Services.Contracts
{
    public interface IPizzaService
    {
        void Save(PizzaDTO pizza);

        PizzaReadDTO GetById(string pizzaId);

        IEnumerable<PizzaReadDTO> GetAllPizzas();
    }
}