using PentaStagione.Domain;

namespace PentaStagione.Repository.Contracts.ReadModel
{
    public interface IPizzaIngredientReadRepository
    {
        PizzaIngredient GetById(string pizzaId);

    }
}
