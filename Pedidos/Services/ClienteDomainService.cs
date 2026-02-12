using Pedidos.Domain.Entities;
using Pedidos.Domain.Services.Interfaces;


namespace Pedidos.Domain.Services
{
    public class ClienteDomainService : IClienteDomainService
    {
        public bool PuedeRealizarPedido(Cliente cliente)
        {
            return true;
        }
    }
}
