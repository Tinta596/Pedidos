using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.ValueObjects
{
    public class PedidoId
    {
        public int Value { get; set; }

        public PedidoId(int value)
        {
            if (value <= 0)
                throw new ArgumentException("El Id del pedido debe ser mayor a cero.", nameof(value));

            Value = value;
        }

        public override bool Equals(object? obj) => obj is PedidoId other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
