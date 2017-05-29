using PentaStagione.Domain;
using PentaStagione.Repository.Contracts;
using PentaStagione.Repository.Contracts.ReadModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace PentaStagione.Repository.ReadModel
{
    public class PizzaReadRepository : IPizzaReadRepository
    {
        private IDbConnection _db;

        public PizzaReadRepository()
        {
            _db = new SqlConnection(@"Data Source=DESKTOP-12KP9NN\SQLEXPRESS;Initial Catalog=PizzaDB;Integrated Security=True");
        }

        public PizzaReadDTO GetById(string pizzaId)
        {
            IEnumerable<PizzaIngredient> ingredients = null;
            using (IDbConnection cn = _db)
            {
                cn.Open();

                PizzaReadDTO pizza = cn.QueryFirst<PizzaReadDTO>($"SELECT * FROM Pizzas WHERE Id ={pizzaId}");

                if (pizza != null)
                {
                    ingredients = cn.Query<PizzaIngredient>($"SELECT Id, IsExtra FROM PizzaToIngredients pi JOIN Ingredients i ON  pi.IngredientId = i.Id WHERE pi.PizzaId = {pizzaId}");
                }
                else
                {
                    throw new KeyNotFoundException();
                }

                if (ingredients != null)
                {
                    pizza.Ingredients = ingredients;
                }

                return pizza;
            }
        }
    }
}