using System;
using System.Collections.Generic;
using PentaStagione.Services.Contracts.DTOs.PizzaIngredientDTOs;

namespace PentaStagione.Services.Contracts.DTOs.PizzaDTOs
{
    public class PizzaDto
    {
        public PizzaDto()
        {
            Ingredients=new List<PizzaIngredientDto>();
        }

        public List<PizzaIngredientDto> Ingredients { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}