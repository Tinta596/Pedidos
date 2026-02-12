using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.Ports.In
{
    public interface ICancelarPedidoUseCase
    {
        void Ejecutar(int pedidoId);
    }
}
