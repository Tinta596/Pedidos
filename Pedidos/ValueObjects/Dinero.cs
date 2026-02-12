using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.ValueObjects
{
    public sealed class Dinero
    {
        public decimal Monto { get; }
        public string Moneda { get; }

        public Dinero(decimal monto, string moneda)
        {
            if (monto < 0)
                throw new ArgumentException("El monto no puede ser negativo.", nameof(monto));
            if (string.IsNullOrWhiteSpace(moneda))
                throw new ArgumentException("La moneda no puede estar vacía.", nameof(moneda));

            Monto = monto;
            Moneda = moneda;
        }
    }
}