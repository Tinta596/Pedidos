using Pedidos.Domain.Entities;

namespace Pedidos.Application.Ports.In
{
    public interface IConsultarPedidoUseCase
    {
        Pedido? Ejecutar(int pedidoId);
    }
}
