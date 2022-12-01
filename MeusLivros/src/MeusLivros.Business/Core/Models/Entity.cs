using System;

namespace MeusLivros.Business.Core.Models
{
    public abstract class Entity
    {
        protected Entity() => Id = Guid.NewGuid();

        public Guid Id { get; set; }
    }
}