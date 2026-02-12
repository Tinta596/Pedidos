using Pedidos.Application.Ports.Out;
using Pedidos.Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Pedidos.Infrastructure.Persistencia.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;

        public PedidoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Guardar(Pedido pedido)
        {
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();
        }

        public Pedido? ObtenerPorId(int id)
        {
            return _appDbContext.Pedidos
                .Include(p => p.Items)
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
