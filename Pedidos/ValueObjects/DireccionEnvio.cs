using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.ValueObjects
{
    public sealed class DireccionEnvio
    {
        public string Calle { get; }
        public string Ciudad { get; }
        public string CodigoPostal { get; }

        public DireccionEnvio(string calle, string ciudad, string codigoPostal)
        {
            if (string.IsNullOrWhiteSpace(calle))
                throw new ArgumentException("La calle no puede estar vacía.", nameof(calle));
            if (string.IsNullOrWhiteSpace(ciudad))
                throw new ArgumentException("La ciudad no puede estar vacía.", nameof(ciudad));
            if (string.IsNullOrWhiteSpace(codigoPostal))
                throw new ArgumentException("El código postal no puede estar vacío.", nameof(codigoPostal));

            Calle = calle;
            Ciudad = ciudad;
            CodigoPostal = codigoPostal;
        }

        public override bool Equals(object? obj) => obj is DireccionEnvio d && Calle == d.Calle && Ciudad == d.Ciudad && CodigoPostal == d.CodigoPostal;
        public override int GetHashCode() => HashCode.Combine(Calle, Ciudad, CodigoPostal);
    }
}
