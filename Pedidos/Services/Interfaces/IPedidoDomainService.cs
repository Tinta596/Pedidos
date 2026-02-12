using Pedidos.Domain.Entities;
using Pedidos.Domain.Enums;
using Pedidos.Domain.ValueObjects;

namespace Pedidos.Domain.Services.Interfaces
{
    public interface IPedidoDomainService
    {
        void CambiarEstado(Pedido pedido, EstadoPedido nuevoEstado);
        Dinero CalcularTotal(Pedido pedido);
    }
}
