using System;
using System.Collections.Generic;
using PentaStagione.Services.Contracts.DTOs.PizzaDTOs;

namespace PentaStagione.Services.Contracts
{
    public interface IPizzaService
    {
        void Save(PizzaDto pizza);
        PizzaDto Get(Guid id);
    }
}