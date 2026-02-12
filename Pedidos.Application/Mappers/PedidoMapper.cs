using Pedidos.Application.DTOs;
using Pedidos.Domain.Entities;


namespace Pedidos.Application.Mappers
{
    public static class PedidoMapper
    {
        public static PedidoResponse ToResponse(Pedido pedido)
        {
            return new PedidoResponse()
            {
                Id = pedido.Id,
                Nombre = pedido.Nombre,
                Estado = pedido.Estado.ToString(),
            };
        }
    }
}
