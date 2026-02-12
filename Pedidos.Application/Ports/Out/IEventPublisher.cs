using Pedidos.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.Ports.Out
{
    public interface IEventPublisher
    {
        void Publicar(IDomainEvent domainEvent);
    }
}
