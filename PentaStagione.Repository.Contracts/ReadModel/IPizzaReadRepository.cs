using PentaStagione.Domain;

namespace PentaStagione.Repository.Contracts.ReadModel
{
    public interface IPizzaReadRepository
    {
        Pizza GetById(int pizzaId);
    }
}