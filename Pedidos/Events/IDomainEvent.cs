namespace Pedidos.Domain.Events
{
    public interface IDomainEvent
    {
        DateTime OccurredOn { get; set; }
    }
}
