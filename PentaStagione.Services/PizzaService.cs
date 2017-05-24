using System;
using System.Linq;
using PentaStagione.Domain;
using PentaStagione.Domain.Repository;
using PentaStagione.Repository.Contracts.ReadModel;
using PentaStagione.Services.Contracts;
using PentaStagione.Services.Contracts.DTOs.PizzaDTOs;
using PentaStagione.Services.Contracts.DTOs.PizzaIngredientDTOs;


namespace PentaStagione.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _repository;
        private readonly IPizzaReadRepository _readRepository;
        private readonly IPizzaIngredientReadRepository _ingredientReadRepository;

        public PizzaService(IPizzaRepository repository, IPizzaReadRepository readRepository, IPizzaIngredientReadRepository ingredientReadRepository)
        {
            _repository = repository;
            _readRepository = readRepository;
            _ingredientReadRepository = ingredientReadRepository;
        }

        public void Save(PizzaDto pizzaDto)
        {

            Pizza pizzaAggregate = new Pizza
            {
                Name = pizzaDto.Name
            };
            foreach (var ingredientDto in pizzaDto.Ingredients)
            {
                pizzaAggregate.AddIngredient(_ingredientReadRepository.Get(ingredientDto.Id));
            }
            _repository.Save(pizzaAggregate);
        }

        public PizzaDto Get(Guid pizzaId)
        {
            var pizza = _readRepository.Get(pizzaId);
            var pizzaDto=new PizzaDto
            {
                Id = pizza.Id,
                Name = pizza.Name
            };
            pizzaDto.Ingredients.AddRange(
                pizza.Ingredients.Select(ingredient => new PizzaIngredientDto {Name = ingredient.Name}));

            return pizzaDto;
        }
    }
}