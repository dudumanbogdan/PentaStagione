using PentaStagione.Domain;
using PentaStagione.Domain.Repository;
using PentaStagione.Services.Contracts;
using PentaStagione.Repository.Contracts.ReadModel;
using PentaStagione.Repository.Contracts;
using System;
using System.Collections.Generic;

namespace PetnaStagione.Services
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepository _repository;
        private IPizzaReadRepository _readRepository;

        public PizzaService(IPizzaRepository repository, IPizzaReadRepository readRepository)
        {
            if (repository == null || readRepository == null) throw new ArgumentNullException();

            _repository = repository;
            _readRepository = readRepository;
        }

        public object GetById(int pizzaId)
        {
            return _readRepository.GetById(pizzaId);
        }

        public void Save(PizzaDTO pizzaDTO)
        {
            if (pizzaDTO == null) throw new ArgumentNullException();

            Pizza pizza = new Pizza();
        }

        public PizzaReadDTO GetById(string pizzaId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PizzaReadDTO> GetAllPizzas()
        {
            throw new NotImplementedException();
        }
    }
}