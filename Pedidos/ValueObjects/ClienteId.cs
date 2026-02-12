using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.ValueObjects
{
    public sealed class ClienteId
    {
        public int Value { get; }

        public ClienteId(int value)
        {
            if (value <= 0)
                throw new ArgumentException("El Id del cliente debe ser mayor a cero.", nameof(value));

            Value = value;
        }

        public override bool Equals(object? obj) => obj is ClienteId other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
