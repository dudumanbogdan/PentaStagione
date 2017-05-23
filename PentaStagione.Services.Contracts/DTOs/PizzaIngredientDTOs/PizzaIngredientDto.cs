using System;

namespace PentaStagione.Services.Contracts.DTOs.PizzaIngredientDTOs
{
    public class PizzaIngredientDto
    {
        public PizzaIngredientDto()
        {
            Id=Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
