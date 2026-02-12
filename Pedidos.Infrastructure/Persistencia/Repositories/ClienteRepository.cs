using Infrastructure.Persistence.Context;
using Pedidos.Application.Ports.Out;
using Pedidos.Domain.Entities;

namespace Pedidos.Infrastructure.Persistencia.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public Cliente? ObtenerPorId(int id)
        {
            return _context.Clientes.Find(id);
        }
    }
}
