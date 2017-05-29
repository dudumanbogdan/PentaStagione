namespace PentaStagione.Repository.Contracts.ReadModel
{
    public interface IPizzaReadRepository
    {
        PizzaReadDTO GetById(string pizzaId);
    }
}