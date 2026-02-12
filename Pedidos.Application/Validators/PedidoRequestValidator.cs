using Pedidos.Application.DTOs;

namespace Pedidos.Application.Validators
{
    public class PedidoRequestValidator
    {
        public void Validate(PedidoRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (request.ClienteId <= 0)
                throw new ArgumentException("ClienteId inválido.");
        }
    }
}
