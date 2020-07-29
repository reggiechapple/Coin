using System;
using Coin.Domain.Interfaces;

namespace Coin.Domain
{
    public class Entity : IEntity
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}