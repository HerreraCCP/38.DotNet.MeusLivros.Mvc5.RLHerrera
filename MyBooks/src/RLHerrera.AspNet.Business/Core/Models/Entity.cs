using System;

namespace RLHerrera.AspNet.Business.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        protected Entity() => Id = Guid.NewGuid();
    }
}