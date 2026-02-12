using Pedidos.Domain.Enums;
using Pedidos.Domain.Events;
using Pedidos.Domain.ValueObjects;

namespace Pedidos.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public Cliente? ClienteId { get; set; }
        public ICollection<PedidoItem> Items { get; set; } = new List<PedidoItem>();
        public EstadoPedido Estado { get; set; }
        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyCollection<IDomainEvent> domainEvents => _domainEvents.AsReadOnly();
        private void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent); 
        }
    }
}