using PentaStagione.Domain;
using PentaStagione.Domain.Repository;
using PentaStagione.Services.Contracts;
using PentaStagione.Repository.Contracts.ReadModel;
using PentaStagione.Repository.Contracts;

namespace PetnaStagione.Services
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepository _repository;
        private IPizzaReadRepository _readRepository;

        public PizzaService(IPizzaRepository repository)
        {
            _repository = repository;
        }

        public void Save(object pizzaDto)
        {
            Pizza pizzaAggregate = null; // = map from pizza dto
            _repository.Save(pizzaAggregate);
        }

        public PizzaReadDTO GetById(string pizzaId)
        {
            return _readRepository.GetById(pizzaId);
        }
    }
}