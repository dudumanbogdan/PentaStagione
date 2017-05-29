using Dapper;
using PentaStagione.Domain;
using PentaStagione.Domain.Repository;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PentaStagione.Repository
{
    public class PizzaRepository : IPizzaRepository
    {
        private IDbConnection _db;

        public PizzaRepository()
        {
            _db = new SqlConnection(@"Data Source=DESKTOP-12KP9NN\SQLEXPRESS;Initial Catalog=PizzaDB;Integrated Security=True");
        }

        public void Save(Pizza pizzaAggregate)
        {
            int rows = 0;
            using (IDbConnection cn = _db)
            {
                cn.Open();
                using (IDbTransaction tran = cn.BeginTransaction())
                {
                    try
                    {
                        rows = cn.Execute("INSERT INTO Pizzas VALUES (@Id, @Name, @Price, @Sauce, @Size)", pizzaAggregate, tran);

                        PizzaIngredient ingredientCheck;

                        foreach (var ingr in pizzaAggregate.Ingredients)
                        {
                            ingredientCheck = cn.QueryFirstOrDefault<PizzaIngredient>("SELECT * FROM Ingredients WHERE Id = @Id", ingr, tran);

                            if (ingredientCheck == null)
                            {
                                rows = cn.Execute("INSERT INTO Ingredients VALUES (@Id, @IsExtra)", ingr, tran);
                            }
                            rows = cn.Execute("INSERT INTO PizzaToIngredients VALUES (@PizzaId, @IngredientId)", new { PizzaId = pizzaAggregate.Id, IngredientId = ingr.Id }, tran);
                        }

                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}