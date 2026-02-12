using Pedidos.Domain.Entities;

namespace Pedidos.Domain.Services.Interfaces
{
    public interface IClienteDomainService
    {
        bool PuedeRealizarPedido(Cliente cliente);
    }
}
