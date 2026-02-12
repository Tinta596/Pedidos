using Pedidos.Domain.ValueObjects;

namespace Pedidos.Domain.Events
{
    public class PedidoCreadoEvent : IDomainEvent
    {
        public PedidoId PedidoId { get; set; }
        public DateTime OccurredOn { get; set; }

        public PedidoCreadoEvent(PedidoId pedidoId, DateTime occurredOn)
        {
            PedidoId = pedidoId;
            OccurredOn = occurredOn;
        }
    }
}
