using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaStagione.Domain.Repository
{
    public interface IIngredientRepository
    {
        void Save(Pizza pizzaAggregate);
    }
}
