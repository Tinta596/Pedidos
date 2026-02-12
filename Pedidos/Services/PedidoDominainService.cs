using Pedidos.Domain.Entities;
using Pedidos.Domain.Enums;
using Pedidos.Domain.Services.Interfaces;
using Pedidos.Domain.ValueObjects;


namespace Pedidos.Domain.Services
{
    public class PedidoDominainService : IPedidoDomainService
    {
        public void CambiarEstado(Pedido pedido, EstadoPedido nuevoEstado)
        {
            pedido.Estado = nuevoEstado;
        }

        public Dinero CalcularTotal(Pedido pedido)
        {
            decimal total = 0;
            foreach(var item in pedido.Items)
            {
                total += item.Precio.Monto;
            }
            return new Dinero(total, "COP");
        }
    }
}
