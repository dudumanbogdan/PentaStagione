using System;

namespace PentaStagione.Infrastructure.Domain
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}