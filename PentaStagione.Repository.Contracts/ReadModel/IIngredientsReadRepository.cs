using PentaStagione.Repository.Contracts.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaStagione.Repository.Contracts
{
    public interface IIngredientsReadRepository
    {
        IngredientDto GetById(int ingredientId);

    }
}
