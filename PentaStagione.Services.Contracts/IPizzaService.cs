using PentaStagione.Services.Contracts.DTOs.PizzaDTOs;

namespace PentaStagione.Services.Contracts
{
    public interface IPizzaService
    {
        void Save(PizzaDto pizza);
    }
}