using Pedidos.Domain.Entities;

namespace Pedidos.Application.Ports.Out
{
    public interface IPedidoRepository
    {
        void Guardar(Pedido pedido);
        Pedido? ObtenerPorId(int id);
    }
}
