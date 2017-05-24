using System;
using PentaStagione.Domain;

namespace PentaStagione.Repository.Contracts.ReadModel
{
    public interface IPizzaReadRepository
    {
        Pizza Get(Guid pizzaId);
    }
}